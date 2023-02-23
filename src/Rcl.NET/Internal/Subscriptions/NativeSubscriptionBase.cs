﻿using Rcl.Qos;
using Rcl.SafeHandles;
using Rosidl.Runtime;
using Rosidl.Runtime.Interop;
using System.Runtime.CompilerServices;
using System.Threading.Channels;

namespace Rcl.Internal.Subscriptions;

internal unsafe abstract class NativeSubscriptionBase :
    RclWaitObject<SafeSubscriptionHandle>,
    IRclNativeSubscription
{
    private readonly Channel<RosMessageBuffer> _messageChannel;
    private readonly QosProfile _actualQos;

    public NativeSubscriptionBase(
        RclNodeImpl node,
        string topicName,
        TypeSupportHandle typeSupport,
        QosProfile qos,
        int queueSize,
        BoundedChannelFullMode fullMode)
        : base(node.Context, new(node.Handle, typeSupport, topicName, qos))
    {
        TypeSupport = typeSupport;

        var opts = new BoundedChannelOptions(queueSize)
        {
            SingleWriter = true,
            SingleReader = false,
            FullMode = fullMode,
            AllowSynchronousContinuations = true
        };

        _messageChannel = Channel.CreateBounded<RosMessageBuffer>(opts, static x => x.Dispose());

        ref var actualQos = ref Unsafe.AsRef<rmw_qos_profile_t>(
            rcl_subscription_get_actual_qos(Handle.Object));
        _actualQos = QosProfile.Create(in actualQos);

        Name = StringMarshal.CreatePooledString(rcl_subscription_get_topic_name(Handle.Object))!;
    }

    protected TypeSupportHandle TypeSupport { get; }

    public QosProfile ActualQos => _actualQos;

    public string Name { get; }

    public int Publishers
    {
        get
        {
            size_t count;
            RclException.ThrowIfNonSuccess(
                rcl_subscription_get_publisher_count(Handle.Object, &count));
            return (int)count.Value;
        }
    }

    public bool IsValid
         => rcl_subscription_is_valid(Handle.Object);

    protected override void OnWaitCompleted()
    {
        var msg = TakeMessage();
        if (!msg.IsEmpty)
        {
            _messageChannel.Writer.TryWrite(msg);
        }
    }

    protected abstract RosMessageBuffer TakeMessage();

    public IAsyncEnumerable<RosMessageBuffer> ReadAllAsync(CancellationToken cancellationToken)
    {
        return _messageChannel.Reader.ReadAllAsync(cancellationToken);
    }

    public override void Dispose()
    {
        if (_messageChannel.Writer.TryComplete())
        {
            while (_messageChannel.Reader.TryRead(out var buffer))
            {
                buffer.Dispose();
            }
        }

        base.Dispose();
    }
}
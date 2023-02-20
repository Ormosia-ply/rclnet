﻿using Rcl.Interop;
using Rcl.Qos;
using Rcl.SafeHandles;
using Rosidl.Runtime;
using Rosidl.Runtime.Interop;
using System.Collections.Concurrent;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Channels;

namespace Rcl.Internal.Subscriptions;

internal unsafe class NativeSubscription<T> :
    NativeSubscriptionBase,
    IRclNativeSubscription where T : IMessage
{
    public NativeSubscription(
        RclNodeImpl node,
        string topicName,
        QosProfile qos,
        int queueSize,
        BoundedChannelFullMode fullMode)
        : base(node, topicName, T.GetTypeSupportHandle(), qos, queueSize, fullMode)
    {
    }

    protected override RosMessageBuffer TakeMessage()
    {
        // TODO: Parse this as RclFoxy.rmw_message_info_t
        // if need to access header fields on foxy.
        // Defined as RclHumble.rmw_message_info_t only because it has bigger size
        // to be compatible with both foxy and humble.
        RclHumble.rmw_message_info_t header;
        void* rosMessage;

        rosMessage = T.UnsafeCreate().ToPointer();
        if (rcl_ret_t.RCL_RET_OK ==
            rcl_take(Handle.Object, rosMessage, &header, null))
        {
            return new RosMessageBuffer(
                new(rosMessage), static (p, _) => T.UnsafeDestroy(p));
        }

        return RosMessageBuffer.Empty;
    }
}

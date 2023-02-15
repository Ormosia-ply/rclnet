﻿using Rcl.Interop;
using Rcl.Qos;
using Rosidl.Runtime;
using Rosidl.Runtime.Interop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Rcl.SafeHandles;

unsafe class SafeSubscriptionHandle : RclObjectHandle<rcl_subscription_t>
{
    private readonly SafeNodeHandle _node;

    public SafeSubscriptionHandle(
        SafeNodeHandle node, TypeSupportHandle typeSupportHandle, string topicName, QosProfile qos)
    {
        _node = node;
        * Object = rcl_get_zero_initialized_subscription();

        var opts = rcl_subscription_get_default_options();
        opts.qos = qos.ToRmwQosProfile();

        var nameSize = InteropHelpers.GetUtf8BufferSize(topicName);
        Span<byte> nameBuffer = stackalloc byte[nameSize];
        InteropHelpers.FillUtf8Buffer(topicName, nameBuffer);

        fixed (byte* pname = nameBuffer)
        {
            RclException.ThrowIfNonSuccess(
                rcl_subscription_init(
                    Object,
                    node.Object,
                    (rosidl_message_type_support_t*)typeSupportHandle.GetMessageTypeSupport(),
                    pname,
                    &opts));
        }

    }

    protected override void ReleaseHandleCore(rcl_subscription_t* ptr)
    {
        rcl_subscription_fini(ptr, _node.Object);
    }
}
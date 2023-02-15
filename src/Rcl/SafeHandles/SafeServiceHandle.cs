﻿using Rcl.Interop;
using Rcl.Qos;
using Rosidl.Runtime;

namespace Rcl.SafeHandles;

internal unsafe class SafeServiceHandle : RclObjectHandle<rcl_service_t>
{
    private readonly SafeNodeHandle _node;

    public SafeServiceHandle(
        SafeNodeHandle node, TypeSupportHandle typeSupportHandle, string serviceName, QosProfile qos)
    {
        _node = node;
        *Object = rcl_get_zero_initialized_service();

        var opts = rcl_service_get_default_options();
        opts.qos = qos.ToRmwQosProfile();

        var nameSize = InteropHelpers.GetUtf8BufferSize(serviceName);
        Span<byte> nameBuffer = stackalloc byte[nameSize];
        InteropHelpers.FillUtf8Buffer(serviceName, nameBuffer);

        fixed (byte* pname = nameBuffer)
        {
            RclException.ThrowIfNonSuccess(
                rcl_service_init(
                    Object,
                    node.Object,
                    (rosidl_service_type_support_t*)typeSupportHandle.GetServiceTypeSupport(),
                    pname,
                    &opts));
        }

    }

    protected override void ReleaseHandleCore(rcl_service_t* ptr)
    {
        rcl_service_fini(ptr, _node.Object);
    }
}
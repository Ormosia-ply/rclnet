//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by ros2cs.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;

#nullable enable

namespace Rosidl.Messages.Sensor
{
    /// <summary>
    /// Representation of state for joints with multiple degrees of freedom,
    /// following the structure of JointState which can only represent a single degree of freedom.
    /// 
    /// It is assumed that a joint in a system corresponds to a transform that gets applied
    /// along the kinematic chain. For example, a planar joint (as in URDF) is 3DOF (x, y, yaw)
    /// and those 3DOF can be expressed as a transformation matrix, and that transformation
    /// matrix can be converted back to (x, y, yaw)
    /// 
    /// Each joint is uniquely identified by its name
    /// The header specifies the time at which the joint states were recorded. All the joint states
    /// in one message have to be recorded at the same time.
    /// 
    /// This message consists of a multiple arrays, one for each part of the joint state.
    /// The goal is to make each of the fields optional. When e.g. your joints have no
    /// wrench associated with them, you can leave the wrench array empty.
    /// 
    /// All arrays in this message should have the same size, or be empty.
    /// This is the only way to uniquely associate the joint name with the correct
    /// states.
    /// </summary>
    /// <remarks>
    /// Message interface definition for <c>sensor_msgs/msg/MultiDOFJointState</c>.
    /// </remarks>
    [global::Rosidl.Runtime.TypeSupportAttribute("sensor_msgs/msg/MultiDOFJointState")]
    internal unsafe partial class MultiDOFJointState : global::Rosidl.Runtime.IMessage
    {
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Rosidl.Runtime.Generator.CSharp", "1.0.0")]
        public static string TypeSupportName => "sensor_msgs/msg/MultiDOFJointState";
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Rosidl.Runtime.Generator.CSharp", "1.0.0")]
        public static global::Rosidl.Runtime.TypeSupportHandle GetTypeSupportHandle()
        {
            return new global::Rosidl.Runtime.TypeSupportHandle(_PInvoke(), global::Rosidl.Runtime.HandleType.Message);
            
            [global::System.Runtime.InteropServices.SuppressGCTransitionAttribute]
            [global::System.Runtime.InteropServices.DllImportAttribute("sensor_msgs__rosidl_typesupport_c", EntryPoint = "rosidl_typesupport_c__get_message_type_support_handle__sensor_msgs__msg__MultiDOFJointState")]
            static extern nint _PInvoke();
        }
        
        /// <summary>
        /// Create a new instance of <see cref="MultiDOFJointState"/> with fields initialized to specified values.
        /// </summary>
        /// <param name='header'>
        /// Originally defined as: <c><![CDATA[std_msgs/Header header]]></c>
        /// </param>
        /// <param name='jointNames'>
        /// Originally defined as: <c><![CDATA[string[] joint_names]]></c>
        /// </param>
        /// <param name='transforms'>
        /// Originally defined as: <c><![CDATA[geometry_msgs/Transform[] transforms]]></c>
        /// </param>
        /// <param name='twist'>
        /// Originally defined as: <c><![CDATA[geometry_msgs/Twist[] twist]]></c>
        /// </param>
        /// <param name='wrench'>
        /// Originally defined as: <c><![CDATA[geometry_msgs/Wrench[] wrench]]></c>
        /// </param>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Rosidl.Runtime.Generator.CSharp", "1.0.0")]
        public MultiDOFJointState(
            global::Rosidl.Messages.Std.Header? @header = null,
            string[]? @jointNames = null,
            global::Rosidl.Messages.Geometry.Transform[]? @transforms = null,
            global::Rosidl.Messages.Geometry.Twist[]? @twist = null,
            global::Rosidl.Messages.Geometry.Wrench[]? @wrench = null
        )
        {
            Header = @header ?? new global::Rosidl.Messages.Std.Header();
            JointNames = @jointNames ?? global::System.Array.Empty<string>();
            Transforms = @transforms ?? global::System.Array.Empty<global::Rosidl.Messages.Geometry.Transform>();
            Twist = @twist ?? global::System.Array.Empty<global::Rosidl.Messages.Geometry.Twist>();
            Wrench = @wrench ?? global::System.Array.Empty<global::Rosidl.Messages.Geometry.Wrench>();
        }
        
        
        /// <summary>
        /// Create a new instance of <see cref="MultiDOFJointState"/>, and copy its data from the specified <see cref="Priv"/> structure.
        /// </summary>
        /// <param name="priv">The <see cref="Priv"/> structure to be copied from.</param>
        /// <param name="textEncoding">Text encoding of the strings in the <see cref="Priv"/> structure and its containing structures, if any.</param>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Rosidl.Runtime.Generator.CSharp", "1.0.0")]
        public MultiDOFJointState(in Priv priv, global::System.Text.Encoding textEncoding)
        {
            this.Header = new global::Rosidl.Messages.Std.Header(in priv.Header, textEncoding);
        
            this.JointNames = new string[priv.JointNames.Size];
            var JointNames_span = priv.JointNames.AsSpan();
            for (int __i = 0; __i < this.JointNames.Length; __i++)
            {
                this.JointNames[__i] = global::Rosidl.Runtime.Interop.StringMarshal.CreatePooledString(JointNames_span[__i].AsSpan(), textEncoding);
            }
        
            this.Transforms = new global::Rosidl.Messages.Geometry.Transform[priv.Transforms.Size];
            var Transforms_span = priv.Transforms.AsSpan();
            for (int __i = 0; __i < this.Transforms.Length; __i++)
            {
                this.Transforms[__i] = new global::Rosidl.Messages.Geometry.Transform(in Transforms_span[__i], textEncoding);
            }
        
            this.Twist = new global::Rosidl.Messages.Geometry.Twist[priv.Twist.Size];
            var Twist_span = priv.Twist.AsSpan();
            for (int __i = 0; __i < this.Twist.Length; __i++)
            {
                this.Twist[__i] = new global::Rosidl.Messages.Geometry.Twist(in Twist_span[__i], textEncoding);
            }
        
            this.Wrench = new global::Rosidl.Messages.Geometry.Wrench[priv.Wrench.Size];
            var Wrench_span = priv.Wrench.AsSpan();
            for (int __i = 0; __i < this.Wrench.Length; __i++)
            {
                this.Wrench[__i] = new global::Rosidl.Messages.Geometry.Wrench(in Wrench_span[__i], textEncoding);
            }
        }
        
        
        /// <summary>
        /// Originally defined as: <c><![CDATA[std_msgs/Header header]]></c>
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Rosidl.Runtime.Generator.CSharp", "1.0.0")]
        public global::Rosidl.Messages.Std.Header Header { get; set; }
        
        /// <summary>
        /// Originally defined as: <c><![CDATA[string[] joint_names]]></c>
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Rosidl.Runtime.Generator.CSharp", "1.0.0")]
        public string[] JointNames { get; set; }
        
        /// <summary>
        /// Originally defined as: <c><![CDATA[geometry_msgs/Transform[] transforms]]></c>
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Rosidl.Runtime.Generator.CSharp", "1.0.0")]
        public global::Rosidl.Messages.Geometry.Transform[] Transforms { get; set; }
        
        /// <summary>
        /// Originally defined as: <c><![CDATA[geometry_msgs/Twist[] twist]]></c>
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Rosidl.Runtime.Generator.CSharp", "1.0.0")]
        public global::Rosidl.Messages.Geometry.Twist[] Twist { get; set; }
        
        /// <summary>
        /// Originally defined as: <c><![CDATA[geometry_msgs/Wrench[] wrench]]></c>
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Rosidl.Runtime.Generator.CSharp", "1.0.0")]
        public global::Rosidl.Messages.Geometry.Wrench[] Wrench { get; set; }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Rosidl.Runtime.Generator.CSharp", "1.0.0")]
        public void WriteTo(nint data, global::System.Text.Encoding textEncoding)
        {
            WriteTo(ref global::System.Runtime.CompilerServices.Unsafe.AsRef<Priv>(data.ToPointer()), textEncoding);
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Rosidl.Runtime.Generator.CSharp", "1.0.0")]
        public void WriteTo(ref Priv priv, global::System.Text.Encoding textEncoding)
        {
            this.Header.WriteTo(ref priv.Header, textEncoding);
            
            priv.JointNames = new global::Rosidl.Runtime.Interop.CStringSequence(this.JointNames.Length);
            var JointNames_span = priv.JointNames.AsSpan();
            for (int __i = 0; __i < this.JointNames.Length; __i++)
            {
                JointNames_span[__i].CopyFrom(this.JointNames[__i], textEncoding);
            }
            
            priv.Transforms = new global::Rosidl.Messages.Geometry.Transform.PrivSequence(this.Transforms.Length);
            var Transforms_span = priv.Transforms.AsSpan();
            for (int __i = 0; __i < this.Transforms.Length; __i++)
            {
                this.Transforms[__i].WriteTo(ref Transforms_span[__i], textEncoding);
            }
            
            priv.Twist = new global::Rosidl.Messages.Geometry.Twist.PrivSequence(this.Twist.Length);
            var Twist_span = priv.Twist.AsSpan();
            for (int __i = 0; __i < this.Twist.Length; __i++)
            {
                this.Twist[__i].WriteTo(ref Twist_span[__i], textEncoding);
            }
            
            priv.Wrench = new global::Rosidl.Messages.Geometry.Wrench.PrivSequence(this.Wrench.Length);
            var Wrench_span = priv.Wrench.AsSpan();
            for (int __i = 0; __i < this.Wrench.Length; __i++)
            {
                this.Wrench[__i].WriteTo(ref Wrench_span[__i], textEncoding);
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Rosidl.Runtime.Generator.CSharp", "1.0.0")]
        public static global::Rosidl.Runtime.IMessage CreateFrom(nint data, global::System.Text.Encoding textEncoding)
        {
            return new MultiDOFJointState(in global::System.Runtime.CompilerServices.Unsafe.AsRef<Priv>(data.ToPointer()), textEncoding);
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Rosidl.Runtime.Generator.CSharp", "1.0.0")]
        public static nint UnsafeCreate()
        {
            return new(Priv.Create());
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Rosidl.Runtime.Generator.CSharp", "1.0.0")]
        public static void UnsafeDestroy(nint data)
        {
            Priv.Destroy((Priv*)data);
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Rosidl.Runtime.Generator.CSharp", "1.0.0")]
        public static bool UnsafeInitialize(nint data)
        {
            return Priv.TryInitialize(out System.Runtime.CompilerServices.Unsafe.AsRef<Priv>(data.ToPointer()));
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Rosidl.Runtime.Generator.CSharp", "1.0.0")]
        public static void UnsafeFinalize(nint data)
        {
            Priv.Finalize(ref System.Runtime.CompilerServices.Unsafe.AsRef<Priv>(data.ToPointer()));
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Rosidl.Runtime.Generator.CSharp", "1.0.0")]
        public static bool UnsafeInitializeSequence(int size, nint data)
        {
            return PrivSequence.TryInitialize(size, out System.Runtime.CompilerServices.Unsafe.AsRef<PrivSequence>(data.ToPointer()));
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Rosidl.Runtime.Generator.CSharp", "1.0.0")]
        public static void UnsafeFinalizeSequence(nint data)
        {
            PrivSequence.Finalize(ref System.Runtime.CompilerServices.Unsafe.AsRef<PrivSequence>(data.ToPointer()));
        }
        
        /// <summary>
        /// Representation of state for joints with multiple degrees of freedom,
        /// following the structure of JointState which can only represent a single degree of freedom.
        /// 
        /// It is assumed that a joint in a system corresponds to a transform that gets applied
        /// along the kinematic chain. For example, a planar joint (as in URDF) is 3DOF (x, y, yaw)
        /// and those 3DOF can be expressed as a transformation matrix, and that transformation
        /// matrix can be converted back to (x, y, yaw)
        /// 
        /// Each joint is uniquely identified by its name
        /// The header specifies the time at which the joint states were recorded. All the joint states
        /// in one message have to be recorded at the same time.
        /// 
        /// This message consists of a multiple arrays, one for each part of the joint state.
        /// The goal is to make each of the fields optional. When e.g. your joints have no
        /// wrench associated with them, you can leave the wrench array empty.
        /// 
        /// All arrays in this message should have the same size, or be empty.
        /// This is the only way to uniquely associate the joint name with the correct
        /// states.
        /// </summary>
        /// <remarks>
        /// Blittable native structure for <c>sensor_msgs/msg/MultiDOFJointState</c>.
        /// </remarks>
        [global::System.Runtime.InteropServices.StructLayoutAttribute(global::System.Runtime.InteropServices.LayoutKind.Sequential)]
        public partial struct Priv : global::System.IEquatable<Priv>, global::System.IDisposable
        {
            /// <summary>
            /// Originally defined as: <c><![CDATA[std_msgs/Header header]]></c>
            /// </summary>
            public global::Rosidl.Messages.Std.Header.Priv Header;
            
            /// <summary>
            /// Originally defined as: <c><![CDATA[string[] joint_names]]></c>
            /// </summary>
            public global::Rosidl.Runtime.Interop.CStringSequence JointNames;
            
            /// <summary>
            /// Originally defined as: <c><![CDATA[geometry_msgs/Transform[] transforms]]></c>
            /// </summary>
            public global::Rosidl.Messages.Geometry.Transform.PrivSequence Transforms;
            
            /// <summary>
            /// Originally defined as: <c><![CDATA[geometry_msgs/Twist[] twist]]></c>
            /// </summary>
            public global::Rosidl.Messages.Geometry.Twist.PrivSequence Twist;
            
            /// <summary>
            /// Originally defined as: <c><![CDATA[geometry_msgs/Wrench[] wrench]]></c>
            /// </summary>
            public global::Rosidl.Messages.Geometry.Wrench.PrivSequence Wrench;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Rosidl.Runtime.Generator.CSharp", "1.0.0")]
            public Priv()
            {
                ThrowIfNonSuccess(TryInitialize(out this));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Rosidl.Runtime.Generator.CSharp", "1.0.0")]
            public Priv(Priv src)
                : this(in src)
            {
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Rosidl.Runtime.Generator.CSharp", "1.0.0")]
            public Priv(in Priv src)
                : this()
            {
                CopyFrom(in src); 
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Rosidl.Runtime.Generator.CSharp", "1.0.0")]
            public Priv(Priv* src)
                : this()
            {
                CopyFrom(src); 
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Rosidl.Runtime.Generator.CSharp", "1.0.0")]
            public void Dispose()
            {
                Finalize(ref this);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Rosidl.Runtime.Generator.CSharp", "1.0.0")]
            public void CopyFrom(Priv src)
            {
                ThrowIfNonSuccess(TryCopy(in src, out this));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Rosidl.Runtime.Generator.CSharp", "1.0.0")]
            public void CopyFrom(in Priv src)
            {
                ThrowIfNonSuccess(TryCopy(in src, out this));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Rosidl.Runtime.Generator.CSharp", "1.0.0")]
            public void CopyFrom(Priv* src)
            {
                fixed (Priv* pThis = &this)
                {
                    ThrowIfNonSuccess(TryCopy(src, pThis));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Rosidl.Runtime.Generator.CSharp", "1.0.0")]
            private static bool TryCopy(in Priv input, out Priv output)
            {
                fixed (Priv* pInput = &input, pOutput = &output)
                {
                    return TryCopy(pInput, pOutput);
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Rosidl.Runtime.Generator.CSharp", "1.0.0")]
            public bool Equals(Priv other)
            {
                return Priv.AreEqual(in other, in this);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Rosidl.Runtime.Generator.CSharp", "1.0.0")]
            public override bool Equals(object? obj) => obj is Priv s ? this.Equals(s) : false;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Rosidl.Runtime.Generator.CSharp", "1.0.0")]
            public override int GetHashCode()
            {
                var __hashCode = new global::System.HashCode();
                __hashCode.Add(this.Header);
                __hashCode.Add(this.JointNames);
                __hashCode.Add(this.Transforms);
                __hashCode.Add(this.Twist);
                __hashCode.Add(this.Wrench);
                return __hashCode.ToHashCode();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Rosidl.Runtime.Generator.CSharp", "1.0.0")]
            public static bool operator ==(Priv lhs, Priv rhs)
            {
                return lhs.Equals(rhs);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Rosidl.Runtime.Generator.CSharp", "1.0.0")]
            public static bool operator !=(Priv lhs, Priv rhs)
            {
                return !(lhs == rhs);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Rosidl.Runtime.Generator.CSharp", "1.0.0")]
            public static Priv* Create()
            {
                return _PInvoke();
                
                [global::System.Runtime.InteropServices.SuppressGCTransitionAttribute]
                [global::System.Runtime.InteropServices.DllImportAttribute("sensor_msgs__rosidl_generator_c", EntryPoint = "sensor_msgs__msg__MultiDOFJointState__create")]
                static extern Priv* _PInvoke();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Rosidl.Runtime.Generator.CSharp", "1.0.0")]
            public static void Destroy(Priv* msg)
            {
                _PInvoke(msg);
                
                [global::System.Runtime.InteropServices.SuppressGCTransitionAttribute]
                [global::System.Runtime.InteropServices.DllImportAttribute("sensor_msgs__rosidl_generator_c", EntryPoint = "sensor_msgs__msg__MultiDOFJointState__destroy")]
                static extern void _PInvoke(Priv* msg);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Rosidl.Runtime.Generator.CSharp", "1.0.0")]
            public static bool TryInitialize(out Priv msg)
            {
                fixed (Priv* pMsg = &msg)
                {
                    return _PInvoke(pMsg);
                }
                
                [global::System.Runtime.InteropServices.SuppressGCTransitionAttribute]
                [global::System.Runtime.InteropServices.DllImportAttribute("sensor_msgs__rosidl_generator_c", EntryPoint = "sensor_msgs__msg__MultiDOFJointState__init")]
                static extern bool _PInvoke(Priv* msg);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Rosidl.Runtime.Generator.CSharp", "1.0.0")]
            public static void Finalize(ref Priv msg)
            {
                fixed (Priv* pMsg = &msg)
                {
                    _PInvoke(pMsg);
                }
                
                [global::System.Runtime.InteropServices.SuppressGCTransitionAttribute]
                [global::System.Runtime.InteropServices.DllImportAttribute("sensor_msgs__rosidl_generator_c", EntryPoint = "sensor_msgs__msg__MultiDOFJointState__fini")]
                static extern void _PInvoke(Priv* msg);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Rosidl.Runtime.Generator.CSharp", "1.0.0")]
            private static bool AreEqual(in Priv lhs, in Priv rhs)
            {
                fixed (Priv* plhs = &lhs, prhs = &rhs)
                {
                    return _PInvoke(plhs, prhs);
                }
                
                [global::System.Runtime.InteropServices.SuppressGCTransitionAttribute]
                [global::System.Runtime.InteropServices.DllImportAttribute("sensor_msgs__rosidl_generator_c", EntryPoint = "sensor_msgs__msg__MultiDOFJointState__are_qual")]
                static extern bool _PInvoke(Priv* lhs, Priv* rhs);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Rosidl.Runtime.Generator.CSharp", "1.0.0")]
            private static bool TryCopy(Priv* input, Priv* output)
            {
                return _PInvoke(input, output);
                
                [global::System.Runtime.InteropServices.SuppressGCTransitionAttribute]
                [global::System.Runtime.InteropServices.DllImportAttribute("sensor_msgs__rosidl_generator_c", EntryPoint = "sensor_msgs__msg__MultiDOFJointState__copy")]
                static extern bool _PInvoke(Priv* input, Priv* output);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Rosidl.Runtime.Generator.CSharp", "1.0.0")]
            public static void ThrowIfNonSuccess(bool ret, [global::System.Runtime.CompilerServices.CallerMemberNameAttribute]
            string caller = "")
            {
                if (!ret)
                {
                    throw new global::Rosidl.Runtime.RosidlException($"An error occurred when calling 'global::Rosidl.Messages.Sensor.MultiDOFJointState.Priv.{caller}'.");
                }
            }
        }
        
        /// <summary>
        /// Representation of state for joints with multiple degrees of freedom,
        /// following the structure of JointState which can only represent a single degree of freedom.
        /// 
        /// It is assumed that a joint in a system corresponds to a transform that gets applied
        /// along the kinematic chain. For example, a planar joint (as in URDF) is 3DOF (x, y, yaw)
        /// and those 3DOF can be expressed as a transformation matrix, and that transformation
        /// matrix can be converted back to (x, y, yaw)
        /// 
        /// Each joint is uniquely identified by its name
        /// The header specifies the time at which the joint states were recorded. All the joint states
        /// in one message have to be recorded at the same time.
        /// 
        /// This message consists of a multiple arrays, one for each part of the joint state.
        /// The goal is to make each of the fields optional. When e.g. your joints have no
        /// wrench associated with them, you can leave the wrench array empty.
        /// 
        /// All arrays in this message should have the same size, or be empty.
        /// This is the only way to uniquely associate the joint name with the correct
        /// states.
        /// </summary>
        /// <remarks>
        /// Blittable native sequence structure for <c>sensor_msgs/msg/MultiDOFJointState</c>.
        /// </remarks>
        [global::System.Runtime.InteropServices.StructLayoutAttribute(global::System.Runtime.InteropServices.LayoutKind.Sequential)]
        public partial struct PrivSequence : global::System.IEquatable<PrivSequence>, global::System.IDisposable
        {
            private Priv* __data;
            
            private nuint __size;
            
            private nuint __capacity;
            
            public int Size => (int)__size;
            
            public int Capcacity => (int)__capacity;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Rosidl.Runtime.Generator.CSharp", "1.0.0")]
            public PrivSequence()
                : this(0)
            {
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Rosidl.Runtime.Generator.CSharp", "1.0.0")]
            public PrivSequence(int size)
            {
                ThrowIfNonSuccess(TryInitialize(size, out this));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Rosidl.Runtime.Generator.CSharp", "1.0.0")]
            public PrivSequence(PrivSequence src)
                : this(in src)
            {
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Rosidl.Runtime.Generator.CSharp", "1.0.0")]
            public PrivSequence(in PrivSequence src)
                : this()
            {
                CopyFrom(in src); 
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Rosidl.Runtime.Generator.CSharp", "1.0.0")]
            public PrivSequence(PrivSequence* src)
                : this()
            {
                CopyFrom(src); 
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Rosidl.Runtime.Generator.CSharp", "1.0.0")]
            public PrivSequence(System.ReadOnlySpan<Priv> src)
                : this(src.Length)
            {
                src.CopyTo(AsSpan());
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Rosidl.Runtime.Generator.CSharp", "1.0.0")]
            public void Dispose()
            {
                Finalize(ref this);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Rosidl.Runtime.Generator.CSharp", "1.0.0")]
            public System.Span<Priv> AsSpan()
            {
                return new(__data, Size);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Rosidl.Runtime.Generator.CSharp", "1.0.0")]
            public void CopyFrom(System.ReadOnlySpan<Priv> src)
            {
                Finalize(ref this);
                ThrowIfNonSuccess(TryInitialize(src.Length, out this));
                src.CopyTo(AsSpan());
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Rosidl.Runtime.Generator.CSharp", "1.0.0")]
            public void CopyFrom(PrivSequence src)
            {
                ThrowIfNonSuccess(TryCopy(in src, out this));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Rosidl.Runtime.Generator.CSharp", "1.0.0")]
            public void CopyFrom(in PrivSequence src)
            {
                ThrowIfNonSuccess(TryCopy(in src, out this));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Rosidl.Runtime.Generator.CSharp", "1.0.0")]
            public void CopyFrom(PrivSequence* src)
            {
                fixed (PrivSequence* pThis = &this)
                {
                    ThrowIfNonSuccess(TryCopy(src, pThis));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Rosidl.Runtime.Generator.CSharp", "1.0.0")]
            private static bool TryCopy(in PrivSequence input, out PrivSequence output)
            {
                fixed (PrivSequence* pInput = &input, pOutput = &output)
                {
                    return TryCopy(pInput, pOutput);
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Rosidl.Runtime.Generator.CSharp", "1.0.0")]
            public bool Equals(PrivSequence other)
            {
                return PrivSequence.AreEqual(in other, in this);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Rosidl.Runtime.Generator.CSharp", "1.0.0")]
            public override bool Equals(object? obj) => obj is PrivSequence s ? this.Equals(s) : false;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Rosidl.Runtime.Generator.CSharp", "1.0.0")]
            public override int GetHashCode()
            {
                return global::System.HashCode.Combine((nint)__data, __size, __capacity);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Rosidl.Runtime.Generator.CSharp", "1.0.0")]
            public static bool operator ==(PrivSequence lhs, PrivSequence rhs)
            {
                return lhs.Equals(rhs);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Rosidl.Runtime.Generator.CSharp", "1.0.0")]
            public static bool operator !=(PrivSequence lhs, PrivSequence rhs)
            {
                return !(lhs == rhs);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Rosidl.Runtime.Generator.CSharp", "1.0.0")]
            public static PrivSequence* Create()
            {
                return _PInvoke();
                
                [global::System.Runtime.InteropServices.SuppressGCTransitionAttribute]
                [global::System.Runtime.InteropServices.DllImportAttribute("sensor_msgs__rosidl_generator_c", EntryPoint = "sensor_msgs__msg__MultiDOFJointState__Sequence__create")]
                static extern PrivSequence* _PInvoke();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Rosidl.Runtime.Generator.CSharp", "1.0.0")]
            public static void Destroy(PrivSequence* msg)
            {
                _PInvoke(msg);
                
                [global::System.Runtime.InteropServices.SuppressGCTransitionAttribute]
                [global::System.Runtime.InteropServices.DllImportAttribute("sensor_msgs__rosidl_generator_c", EntryPoint = "sensor_msgs__msg__MultiDOFJointState__Sequence__destroy")]
                static extern void _PInvoke(PrivSequence* msg);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Rosidl.Runtime.Generator.CSharp", "1.0.0")]
            public static bool TryInitialize(int size, out PrivSequence msg)
            {
                fixed (PrivSequence* pMsg = &msg)
                {
                    return _PInvoke(pMsg, (uint)size);
                }
                
                [global::System.Runtime.InteropServices.SuppressGCTransitionAttribute]
                [global::System.Runtime.InteropServices.DllImportAttribute("sensor_msgs__rosidl_generator_c", EntryPoint = "sensor_msgs__msg__MultiDOFJointState__Sequence__init")]
                static extern bool _PInvoke(PrivSequence* msg, nuint size);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Rosidl.Runtime.Generator.CSharp", "1.0.0")]
            public static void Finalize(ref PrivSequence msg)
            {
                fixed (PrivSequence* pMsg = &msg)
                {
                    _PInvoke(pMsg);
                }
                
                [global::System.Runtime.InteropServices.SuppressGCTransitionAttribute]
                [global::System.Runtime.InteropServices.DllImportAttribute("sensor_msgs__rosidl_generator_c", EntryPoint = "sensor_msgs__msg__MultiDOFJointState__Sequence__fini")]
                static extern void _PInvoke(PrivSequence* msg);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Rosidl.Runtime.Generator.CSharp", "1.0.0")]
            private static bool AreEqual(in PrivSequence lhs, in PrivSequence rhs)
            {
                fixed (PrivSequence* plhs = &lhs, prhs = &rhs)
                {
                    return _PInvoke(plhs, prhs);
                }
                
                [global::System.Runtime.InteropServices.SuppressGCTransitionAttribute]
                [global::System.Runtime.InteropServices.DllImportAttribute("sensor_msgs__rosidl_generator_c", EntryPoint = "sensor_msgs__msg__MultiDOFJointState__Sequence__are_qual")]
                static extern bool _PInvoke(PrivSequence* lhs, PrivSequence* rhs);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Rosidl.Runtime.Generator.CSharp", "1.0.0")]
            private static bool TryCopy(PrivSequence* input, PrivSequence* output)
            {
                return _PInvoke(input, output);
                
                [global::System.Runtime.InteropServices.SuppressGCTransitionAttribute]
                [global::System.Runtime.InteropServices.DllImportAttribute("sensor_msgs__rosidl_generator_c", EntryPoint = "sensor_msgs__msg__MultiDOFJointState__Sequence__copy")]
                static extern bool _PInvoke(PrivSequence* input, PrivSequence* output);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Rosidl.Runtime.Generator.CSharp", "1.0.0")]
            public static void ThrowIfNonSuccess(bool ret, [global::System.Runtime.CompilerServices.CallerMemberNameAttribute]
            string caller = "")
            {
                if (!ret)
                {
                    throw new global::Rosidl.Runtime.RosidlException($"An error occurred when calling 'global::Rosidl.Messages.Sensor.MultiDOFJointState.PrivSequence.{caller}'.");
                }
            }
        }
    }
}

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

namespace Rosidl.Messages.Geometry
{
    /// <summary>
    /// This represents a Point with reference coordinate frame and timestamp
    /// </summary>
    /// <remarks>
    /// Message interface definition for <c>geometry_msgs/msg/PointStamped</c>.
    /// </remarks>
    [global::Rosidl.Runtime.TypeSupportAttribute("geometry_msgs/msg/PointStamped")]
    public unsafe partial class PointStamped : global::Rosidl.Runtime.IMessage
    {
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Rosidl.Runtime.Generator.CSharp", "1.0.0")]
        public static string TypeSupportName => "geometry_msgs/msg/PointStamped";
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Rosidl.Runtime.Generator.CSharp", "1.0.0")]
        public static global::Rosidl.Runtime.TypeSupportHandle GetTypeSupportHandle()
        {
            return new global::Rosidl.Runtime.TypeSupportHandle(_PInvoke(), global::Rosidl.Runtime.HandleType.Message);
            
            [global::System.Runtime.InteropServices.SuppressGCTransitionAttribute]
            [global::System.Runtime.InteropServices.DllImportAttribute("geometry_msgs__rosidl_typesupport_c", EntryPoint = "rosidl_typesupport_c__get_message_type_support_handle__geometry_msgs__msg__PointStamped")]
            static extern nint _PInvoke();
        }
        
        /// <summary>
        /// Create a new instance of <see cref="PointStamped"/> with fields initialized to specified values.
        /// </summary>
        /// <param name='header'>
        /// Originally defined as: <c><![CDATA[std_msgs/Header header]]></c>
        /// </param>
        /// <param name='point'>
        /// Originally defined as: <c><![CDATA[geometry_msgs/Point point]]></c>
        /// </param>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Rosidl.Runtime.Generator.CSharp", "1.0.0")]
        public PointStamped(
            global::Rosidl.Messages.Std.Header? @header = null,
            global::Rosidl.Messages.Geometry.Point? @point = null
        )
        {
            Header = @header ?? new global::Rosidl.Messages.Std.Header();
            Point = @point ?? new global::Rosidl.Messages.Geometry.Point();
        }
        
        
        /// <summary>
        /// Create a new instance of <see cref="PointStamped"/>, and copy its data from the specified <see cref="Priv"/> structure.
        /// </summary>
        /// <param name="priv">The <see cref="Priv"/> structure to be copied from.</param>
        /// <param name="textEncoding">Text encoding of the strings in the <see cref="Priv"/> structure and its containing structures, if any.</param>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Rosidl.Runtime.Generator.CSharp", "1.0.0")]
        public PointStamped(in Priv priv, global::System.Text.Encoding textEncoding)
        {
            this.Header = new global::Rosidl.Messages.Std.Header(in priv.Header, textEncoding);
            this.Point = new global::Rosidl.Messages.Geometry.Point(in priv.Point, textEncoding);
        }
        
        
        /// <summary>
        /// Originally defined as: <c><![CDATA[std_msgs/Header header]]></c>
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Rosidl.Runtime.Generator.CSharp", "1.0.0")]
        public global::Rosidl.Messages.Std.Header Header { get; set; }
        
        /// <summary>
        /// Originally defined as: <c><![CDATA[geometry_msgs/Point point]]></c>
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Rosidl.Runtime.Generator.CSharp", "1.0.0")]
        public global::Rosidl.Messages.Geometry.Point Point { get; set; }
        
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
            this.Point.WriteTo(ref priv.Point, textEncoding);
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Rosidl.Runtime.Generator.CSharp", "1.0.0")]
        public static global::Rosidl.Runtime.IMessage CreateFrom(nint data, global::System.Text.Encoding textEncoding)
        {
            return new PointStamped(in global::System.Runtime.CompilerServices.Unsafe.AsRef<Priv>(data.ToPointer()), textEncoding);
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Rosidl.Runtime.Generator.CSharp", "1.0.0")]
        public static nint UnsafeCreate()
        {
            return new(global::Rosidl.Messages.Geometry.PointStamped.Priv.Create());
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Rosidl.Runtime.Generator.CSharp", "1.0.0")]
        public static void UnsafeDestroy(nint data)
        {
            Priv.Destroy((Priv*)data);
        }
        
        /// <summary>
        /// This represents a Point with reference coordinate frame and timestamp
        /// </summary>
        /// <remarks>
        /// Blittable native structure for <c>geometry_msgs/msg/PointStamped</c>.
        /// </remarks>
        [global::System.Runtime.InteropServices.StructLayoutAttribute(global::System.Runtime.InteropServices.LayoutKind.Sequential)]
        public partial struct Priv : global::System.IEquatable<Priv>, global::System.IDisposable
        {
            /// <summary>
            /// Originally defined as: <c><![CDATA[std_msgs/Header header]]></c>
            /// </summary>
            public global::Rosidl.Messages.Std.Header.Priv Header;
            
            /// <summary>
            /// Originally defined as: <c><![CDATA[geometry_msgs/Point point]]></c>
            /// </summary>
            public global::Rosidl.Messages.Geometry.Point.Priv Point;
            
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
                __hashCode.Add(this.Point);
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
                [global::System.Runtime.InteropServices.DllImportAttribute("geometry_msgs__rosidl_generator_c", EntryPoint = "geometry_msgs__msg__PointStamped__create")]
                static extern Priv* _PInvoke();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Rosidl.Runtime.Generator.CSharp", "1.0.0")]
            public static void Destroy(Priv* msg)
            {
                _PInvoke(msg);
                
                [global::System.Runtime.InteropServices.SuppressGCTransitionAttribute]
                [global::System.Runtime.InteropServices.DllImportAttribute("geometry_msgs__rosidl_generator_c", EntryPoint = "geometry_msgs__msg__PointStamped__destroy")]
                static extern void _PInvoke(Priv* msg);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Rosidl.Runtime.Generator.CSharp", "1.0.0")]
            private static bool TryInitialize(out Priv msg)
            {
                fixed (Priv* pMsg = &msg)
                {
                    return _PInvoke(pMsg);
                }
                
                [global::System.Runtime.InteropServices.SuppressGCTransitionAttribute]
                [global::System.Runtime.InteropServices.DllImportAttribute("geometry_msgs__rosidl_generator_c", EntryPoint = "geometry_msgs__msg__PointStamped__init")]
                static extern bool _PInvoke(Priv* msg);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Rosidl.Runtime.Generator.CSharp", "1.0.0")]
            private static void Finalize(ref Priv msg)
            {
                fixed (Priv* pMsg = &msg)
                {
                    _PInvoke(pMsg);
                }
                
                [global::System.Runtime.InteropServices.SuppressGCTransitionAttribute]
                [global::System.Runtime.InteropServices.DllImportAttribute("geometry_msgs__rosidl_generator_c", EntryPoint = "geometry_msgs__msg__PointStamped__fini")]
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
                [global::System.Runtime.InteropServices.DllImportAttribute("geometry_msgs__rosidl_generator_c", EntryPoint = "geometry_msgs__msg__PointStamped__are_qual")]
                static extern bool _PInvoke(Priv* lhs, Priv* rhs);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Rosidl.Runtime.Generator.CSharp", "1.0.0")]
            private static bool TryCopy(Priv* input, Priv* output)
            {
                return _PInvoke(input, output);
                
                [global::System.Runtime.InteropServices.SuppressGCTransitionAttribute]
                [global::System.Runtime.InteropServices.DllImportAttribute("geometry_msgs__rosidl_generator_c", EntryPoint = "geometry_msgs__msg__PointStamped__copy")]
                static extern bool _PInvoke(Priv* input, Priv* output);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Rosidl.Runtime.Generator.CSharp", "1.0.0")]
            public static void ThrowIfNonSuccess(bool ret, [global::System.Runtime.CompilerServices.CallerMemberNameAttribute]
            string caller = "")
            {
                if (!ret)
                {
                    throw new global::Rosidl.Runtime.RosidlException($"An error occurred when calling 'global::Rosidl.Messages.Geometry.PointStamped.Priv.{caller}'.");
                }
            }
        }
        
        /// <summary>
        /// This represents a Point with reference coordinate frame and timestamp
        /// </summary>
        /// <remarks>
        /// Blittable native sequence structure for <c>geometry_msgs/msg/PointStamped</c>.
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
                [global::System.Runtime.InteropServices.DllImportAttribute("geometry_msgs__rosidl_generator_c", EntryPoint = "geometry_msgs__msg__PointStamped__Sequence__create")]
                static extern PrivSequence* _PInvoke();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Rosidl.Runtime.Generator.CSharp", "1.0.0")]
            public static void Destroy(PrivSequence* msg)
            {
                _PInvoke(msg);
                
                [global::System.Runtime.InteropServices.SuppressGCTransitionAttribute]
                [global::System.Runtime.InteropServices.DllImportAttribute("geometry_msgs__rosidl_generator_c", EntryPoint = "geometry_msgs__msg__PointStamped__Sequence__destroy")]
                static extern void _PInvoke(PrivSequence* msg);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Rosidl.Runtime.Generator.CSharp", "1.0.0")]
            private static bool TryInitialize(int size, out PrivSequence msg)
            {
                fixed (PrivSequence* pMsg = &msg)
                {
                    return _PInvoke(pMsg, (uint)size);
                }
                
                [global::System.Runtime.InteropServices.SuppressGCTransitionAttribute]
                [global::System.Runtime.InteropServices.DllImportAttribute("geometry_msgs__rosidl_generator_c", EntryPoint = "geometry_msgs__msg__PointStamped__Sequence__init")]
                static extern bool _PInvoke(PrivSequence* msg, nuint size);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Rosidl.Runtime.Generator.CSharp", "1.0.0")]
            private static void Finalize(ref PrivSequence msg)
            {
                fixed (PrivSequence* pMsg = &msg)
                {
                    _PInvoke(pMsg);
                }
                
                [global::System.Runtime.InteropServices.SuppressGCTransitionAttribute]
                [global::System.Runtime.InteropServices.DllImportAttribute("geometry_msgs__rosidl_generator_c", EntryPoint = "geometry_msgs__msg__PointStamped__Sequence__fini")]
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
                [global::System.Runtime.InteropServices.DllImportAttribute("geometry_msgs__rosidl_generator_c", EntryPoint = "geometry_msgs__msg__PointStamped__Sequence__are_qual")]
                static extern bool _PInvoke(PrivSequence* lhs, PrivSequence* rhs);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Rosidl.Runtime.Generator.CSharp", "1.0.0")]
            private static bool TryCopy(PrivSequence* input, PrivSequence* output)
            {
                return _PInvoke(input, output);
                
                [global::System.Runtime.InteropServices.SuppressGCTransitionAttribute]
                [global::System.Runtime.InteropServices.DllImportAttribute("geometry_msgs__rosidl_generator_c", EntryPoint = "geometry_msgs__msg__PointStamped__Sequence__copy")]
                static extern bool _PInvoke(PrivSequence* input, PrivSequence* output);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Rosidl.Runtime.Generator.CSharp", "1.0.0")]
            public static void ThrowIfNonSuccess(bool ret, [global::System.Runtime.CompilerServices.CallerMemberNameAttribute]
            string caller = "")
            {
                if (!ret)
                {
                    throw new global::Rosidl.Runtime.RosidlException($"An error occurred when calling 'global::Rosidl.Messages.Geometry.PointStamped.PrivSequence.{caller}'.");
                }
            }
        }
    }
}

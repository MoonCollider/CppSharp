// ----------------------------------------------------------------------------
// <auto-generated>
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
// </auto-generated>
// ----------------------------------------------------------------------------
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using __CallingConvention = global::System.Runtime.InteropServices.CallingConvention;
using __IntPtr = global::System.IntPtr;

[assembly:InternalsVisibleTo("CppSharp.Parser.CSharp")]

[assembly:InternalsVisibleTo("CppSharp.CppParser")]

#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required

namespace Std
{
    namespace Vector
    {
        [StructLayout(LayoutKind.Sequential, Size = 12, Pack = 8)]
        public unsafe partial struct __Internalc__N_std_S_vector____N_std_S_basic_string__C___N_std_S_char_traits__C___N_std_S_allocator__C___N_std_S_allocator__S0_
        {
            internal global::Std.CompressedPair.__Internalc__N_std_S__Compressed_pair____N_std_S_allocator____N_std_S_basic_string__C___N_std_S_char_traits__C___N_std_S_allocator__C___N_std_S__Vector_val____N_std_S__Simple_types__S1__Vb1 _Mypair;
        }

        [StructLayout(LayoutKind.Sequential, Size = 12, Pack = 8)]
        public unsafe partial struct __Internalc__N_std_S_vector__i___N_std_S_allocator__i
        {
            internal global::Std.CompressedPair.__Internalc__N_std_S__Compressed_pair____N_std_S_allocator__i___N_std_S__Vector_val____N_std_S__Simple_types__i_Vb1 _Mypair;
        }
    }

    namespace VectorVal
    {
        [StructLayout(LayoutKind.Sequential, Size = 12, Pack = 8)]
        public unsafe partial struct __Internal
        {
            internal __IntPtr _Myfirst;
            internal __IntPtr _Mylast;
            internal __IntPtr _Myend;
        }
    }
}

namespace Std
{
    namespace CompressedPair
    {
        [StructLayout(LayoutKind.Sequential, Size = 24, Pack = 8)]
        public unsafe partial struct __Internalc__N_std_S__Compressed_pair____N_std_S_allocator__C___N_std_S__String_val____N_std_S__Simple_types__C_Vb1
        {
            internal global::Std.StringVal.__Internal _Myval2;
        }

        [StructLayout(LayoutKind.Sequential, Size = 12, Pack = 8)]
        public unsafe partial struct __Internalc__N_std_S__Compressed_pair____N_std_S_allocator____N_std_S_basic_string__C___N_std_S_char_traits__C___N_std_S_allocator__C___N_std_S__Vector_val____N_std_S__Simple_types__S1__Vb1
        {
            internal global::Std.VectorVal.__Internal _Myval2;
        }

        [StructLayout(LayoutKind.Sequential, Size = 12, Pack = 8)]
        public unsafe partial struct __Internalc__N_std_S__Compressed_pair____N_std_S_allocator__i___N_std_S__Vector_val____N_std_S__Simple_types__i_Vb1
        {
            internal global::Std.VectorVal.__Internal _Myval2;
        }
    }

    namespace Allocator
    {
        [StructLayout(LayoutKind.Sequential, Size = 1, Pack = 8)]
        public unsafe partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity, DllImport("Std-symbols", EntryPoint = "??0?$allocator@D@std@@QAE@XZ", CallingConvention = __CallingConvention.ThisCall)]
            internal static extern __IntPtr ctorc__N_std_S_allocator__C(__IntPtr __instance);
        }
    }

    public unsafe partial class Allocator<_Ty> : IDisposable
    {
        public __IntPtr __Instance { get; protected set; }

        internal static readonly new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::Std.Allocator<_Ty>> NativeToManagedMap =
            new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::Std.Allocator<_Ty>>();

        internal static void __RecordNativeToManagedMapping(IntPtr native, global::Std.Allocator<_Ty> managed)
        {
            NativeToManagedMap[native] = managed;
        }

        internal static bool __TryGetNativeToManagedMapping(IntPtr native, out global::Std.Allocator<_Ty> managed)
        {
    
            return NativeToManagedMap.TryGetValue(native, out managed);
        }

        protected bool __ownsNativeInstance;

        internal static Allocator<_Ty> __CreateInstance(__IntPtr native, bool skipVTables = false)
        {
            if (native == __IntPtr.Zero)
                return null;
            return new Allocator<_Ty>(native.ToPointer(), skipVTables);
        }

        internal static Allocator<_Ty> __GetOrCreateInstance(__IntPtr native, bool saveInstance = false, bool skipVTables = false)
        {
            if (native == __IntPtr.Zero)
                return null;
            if (__TryGetNativeToManagedMapping(native, out var managed))
                return (Allocator<_Ty>)managed;
            var result = __CreateInstance(native, skipVTables);
            if (saveInstance)
                __RecordNativeToManagedMapping(native, result);
            return result;
        }

        internal static Allocator<_Ty> __CreateInstance(global::Std.Allocator.__Internal native, bool skipVTables = false)
        {
            return new Allocator<_Ty>(native, skipVTables);
        }

        private static void* __CopyValue(global::Std.Allocator.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::Std.Allocator.__Internal));
            *(global::Std.Allocator.__Internal*) ret = native;
            return ret.ToPointer();
        }

        private Allocator(global::Std.Allocator.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            __RecordNativeToManagedMapping(__Instance, this);
        }

        protected Allocator(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new __IntPtr(native);
        }

        public Allocator()
        {
            var ___Ty = typeof(_Ty);
            if (___Ty.IsAssignableFrom(typeof(sbyte)))
            {
                __Instance = Marshal.AllocHGlobal(sizeof(global::Std.Allocator.__Internal));
                __ownsNativeInstance = true;
                __RecordNativeToManagedMapping(__Instance, this);
                global::Std.Allocator.__Internal.ctorc__N_std_S_allocator__C(__Instance);
                return;
            }
            throw new ArgumentOutOfRangeException("_Ty", string.Join(", ", new[] { typeof(_Ty).FullName }), "global::Std.Allocator<_Ty> maps a C++ template class and therefore it only supports a limited set of types and their subclasses: <sbyte>.");
        }

        public void Dispose()
        {
            Dispose(disposing: true, callNativeDtor : __ownsNativeInstance );
        }

        partial void DisposePartial(bool disposing);

        internal protected virtual void Dispose(bool disposing, bool callNativeDtor )
        {
            if (__Instance == IntPtr.Zero)
                return;
            NativeToManagedMap.TryRemove(__Instance, out _);
            DisposePartial(disposing);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }
    }
}

namespace Std
{
}

namespace Std
{
}

namespace Std
{
    namespace TreeVal
    {
        [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
        public unsafe partial struct __Internal
        {
            internal __IntPtr _Myhead;
            internal uint _Mysize;
        }
    }
}

namespace Std
{
    namespace BasicString
    {
        [StructLayout(LayoutKind.Sequential, Size = 24, Pack = 8)]
        public unsafe partial struct __Internalc__N_std_S_basic_string__C___N_std_S_char_traits__C___N_std_S_allocator__C
        {
            internal global::Std.CompressedPair.__Internalc__N_std_S__Compressed_pair____N_std_S_allocator__C___N_std_S__String_val____N_std_S__Simple_types__C_Vb1 _Mypair;

            [SuppressUnmanagedCodeSecurity, DllImport("Std-symbols", EntryPoint = "??0?$basic_string@DU?$char_traits@D@std@@V?$allocator@D@2@@std@@QAE@XZ", CallingConvention = __CallingConvention.ThisCall)]
            internal static extern __IntPtr ctorc__N_std_S_basic_string__C___N_std_S_char_traits__C___N_std_S_allocator__C(__IntPtr __instance);

            [SuppressUnmanagedCodeSecurity, DllImport("Std-symbols", EntryPoint = "??1?$basic_string@DU?$char_traits@D@std@@V?$allocator@D@2@@std@@QAE@XZ", CallingConvention = __CallingConvention.ThisCall)]
            internal static extern void dtorc__N_std_S_basic_string__C___N_std_S_char_traits__C___N_std_S_allocator__C(__IntPtr __instance);
        }
    }

    public unsafe partial class BasicString<_Elem, _Traits, _Alloc> : IDisposable
    {
        public __IntPtr __Instance { get; protected set; }

        internal static readonly new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::Std.BasicString<_Elem, _Traits, _Alloc>> NativeToManagedMap =
            new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::Std.BasicString<_Elem, _Traits, _Alloc>>();

        internal static void __RecordNativeToManagedMapping(IntPtr native, global::Std.BasicString<_Elem, _Traits, _Alloc> managed)
        {
            NativeToManagedMap[native] = managed;
        }

        internal static bool __TryGetNativeToManagedMapping(IntPtr native, out global::Std.BasicString<_Elem, _Traits, _Alloc> managed)
        {
    
            return NativeToManagedMap.TryGetValue(native, out managed);
        }

        protected bool __ownsNativeInstance;

        internal static BasicString<_Elem, _Traits, _Alloc> __CreateInstance(__IntPtr native, bool skipVTables = false)
        {
            if (native == __IntPtr.Zero)
                return null;
            return new BasicString<_Elem, _Traits, _Alloc>(native.ToPointer(), skipVTables);
        }

        internal static BasicString<_Elem, _Traits, _Alloc> __GetOrCreateInstance(__IntPtr native, bool saveInstance = false, bool skipVTables = false)
        {
            if (native == __IntPtr.Zero)
                return null;
            if (__TryGetNativeToManagedMapping(native, out var managed))
                return (BasicString<_Elem, _Traits, _Alloc>)managed;
            var result = __CreateInstance(native, skipVTables);
            if (saveInstance)
                __RecordNativeToManagedMapping(native, result);
            return result;
        }

        internal static BasicString<_Elem, _Traits, _Alloc> __CreateInstance(global::Std.BasicString.__Internalc__N_std_S_basic_string__C___N_std_S_char_traits__C___N_std_S_allocator__C native, bool skipVTables = false)
        {
            return new BasicString<_Elem, _Traits, _Alloc>(native, skipVTables);
        }

        private static void* __CopyValue(global::Std.BasicString.__Internalc__N_std_S_basic_string__C___N_std_S_char_traits__C___N_std_S_allocator__C native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::Std.BasicString.__Internalc__N_std_S_basic_string__C___N_std_S_char_traits__C___N_std_S_allocator__C));
            *(global::Std.BasicString.__Internalc__N_std_S_basic_string__C___N_std_S_char_traits__C___N_std_S_allocator__C*) ret = native;
            return ret.ToPointer();
        }

        private BasicString(global::Std.BasicString.__Internalc__N_std_S_basic_string__C___N_std_S_char_traits__C___N_std_S_allocator__C native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            __RecordNativeToManagedMapping(__Instance, this);
        }

        protected BasicString(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new __IntPtr(native);
        }

        public BasicString()
        {
            var ___Elem = typeof(_Elem);
            var ___Traits = typeof(_Traits);
            var ___Alloc = typeof(_Alloc);
            if (___Elem.IsAssignableFrom(typeof(sbyte)) && ___Traits.IsAssignableFrom(typeof(global::Std.CharTraits<sbyte>)) && ___Alloc.IsAssignableFrom(typeof(global::Std.Allocator<sbyte>)))
            {
                __Instance = Marshal.AllocHGlobal(sizeof(global::Std.BasicString.__Internalc__N_std_S_basic_string__C___N_std_S_char_traits__C___N_std_S_allocator__C));
                __ownsNativeInstance = true;
                __RecordNativeToManagedMapping(__Instance, this);
                global::Std.BasicString.__Internalc__N_std_S_basic_string__C___N_std_S_char_traits__C___N_std_S_allocator__C.ctorc__N_std_S_basic_string__C___N_std_S_char_traits__C___N_std_S_allocator__C(__Instance);
                return;
            }
            throw new ArgumentOutOfRangeException("_Elem, _Traits, _Alloc", string.Join(", ", new[] { typeof(_Elem).FullName, typeof(_Traits).FullName, typeof(_Alloc).FullName }), "global::Std.BasicString<_Elem, _Traits, _Alloc> maps a C++ template class and therefore it only supports a limited set of types and their subclasses: <sbyte, global::Std.CharTraits<sbyte>, global::Std.Allocator<sbyte>>.");
        }

        public void Dispose()
        {
            Dispose(disposing: true, callNativeDtor : __ownsNativeInstance );
        }

        partial void DisposePartial(bool disposing);

        internal protected virtual void Dispose(bool disposing, bool callNativeDtor )
        {
            if (__Instance == IntPtr.Zero)
                return;
            NativeToManagedMap.TryRemove(__Instance, out _);
            DisposePartial(disposing);
            if (callNativeDtor)
            {
                var ___Elem = typeof(_Elem);
                var ___Traits = typeof(_Traits);
                var ___Alloc = typeof(_Alloc);
                if (___Elem.IsAssignableFrom(typeof(sbyte)) && ___Traits.IsAssignableFrom(typeof(global::Std.CharTraits<sbyte>)) && ___Alloc.IsAssignableFrom(typeof(global::Std.Allocator<sbyte>)))
                {
                    global::Std.BasicString.__Internalc__N_std_S_basic_string__C___N_std_S_char_traits__C___N_std_S_allocator__C.dtorc__N_std_S_basic_string__C___N_std_S_char_traits__C___N_std_S_allocator__C(__Instance);
                    return;
                }
                throw new ArgumentOutOfRangeException("_Elem, _Traits, _Alloc", string.Join(", ", new[] { typeof(_Elem).FullName, typeof(_Traits).FullName, typeof(_Alloc).FullName }), "global::Std.BasicString<_Elem, _Traits, _Alloc> maps a C++ template class and therefore it only supports a limited set of types and their subclasses: <sbyte, global::Std.CharTraits<sbyte>, global::Std.Allocator<sbyte>>.");
            }
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }
    }

    namespace StringVal
    {
        [StructLayout(LayoutKind.Sequential, Size = 24, Pack = 8)]
        public unsafe partial struct __Internal
        {
            internal global::Std.StringVal.Bxty.__Internal _Bx;
            internal uint _Mysize;
            internal uint _Myres;
        }

        namespace Bxty
        {
            [StructLayout(LayoutKind.Explicit, Size = 16, Pack = 8)]
            public unsafe partial struct __Internal
            {
                [FieldOffset(0)]
                internal fixed sbyte _Buf[16];

                [FieldOffset(0)]
                internal __IntPtr _Ptr;

                [FieldOffset(0)]
                internal fixed sbyte _Alias[16];
            }
        }

    }

    namespace CharTraits
    {
        [StructLayout(LayoutKind.Sequential, Size = 1, Pack = 8)]
        public unsafe partial struct __Internal
        {
        }
    }

    public unsafe partial class CharTraits<_Elem> : IDisposable
    {
        public __IntPtr __Instance { get; protected set; }

        internal static readonly new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::Std.CharTraits<_Elem>> NativeToManagedMap =
            new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::Std.CharTraits<_Elem>>();

        internal static void __RecordNativeToManagedMapping(IntPtr native, global::Std.CharTraits<_Elem> managed)
        {
            NativeToManagedMap[native] = managed;
        }

        internal static bool __TryGetNativeToManagedMapping(IntPtr native, out global::Std.CharTraits<_Elem> managed)
        {
    
            return NativeToManagedMap.TryGetValue(native, out managed);
        }

        protected bool __ownsNativeInstance;

        internal static CharTraits<_Elem> __CreateInstance(__IntPtr native, bool skipVTables = false)
        {
            if (native == __IntPtr.Zero)
                return null;
            return new CharTraits<_Elem>(native.ToPointer(), skipVTables);
        }

        internal static CharTraits<_Elem> __GetOrCreateInstance(__IntPtr native, bool saveInstance = false, bool skipVTables = false)
        {
            if (native == __IntPtr.Zero)
                return null;
            if (__TryGetNativeToManagedMapping(native, out var managed))
                return (CharTraits<_Elem>)managed;
            var result = __CreateInstance(native, skipVTables);
            if (saveInstance)
                __RecordNativeToManagedMapping(native, result);
            return result;
        }

        internal static CharTraits<_Elem> __CreateInstance(global::Std.CharTraits.__Internal native, bool skipVTables = false)
        {
            return new CharTraits<_Elem>(native, skipVTables);
        }

        private static void* __CopyValue(global::Std.CharTraits.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::Std.CharTraits.__Internal));
            *(global::Std.CharTraits.__Internal*) ret = native;
            return ret.ToPointer();
        }

        private CharTraits(global::Std.CharTraits.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            __RecordNativeToManagedMapping(__Instance, this);
        }

        protected CharTraits(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new __IntPtr(native);
        }

        public void Dispose()
        {
            Dispose(disposing: true, callNativeDtor : __ownsNativeInstance );
        }

        partial void DisposePartial(bool disposing);

        internal protected virtual void Dispose(bool disposing, bool callNativeDtor )
        {
            if (__Instance == IntPtr.Zero)
                return;
            NativeToManagedMap.TryRemove(__Instance, out _);
            DisposePartial(disposing);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }
    }

    public unsafe static partial class BasicStringExtensions
    {
        public partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity, DllImport("Std-symbols", EntryPoint = "?assign@?$basic_string@DU?$char_traits@D@std@@V?$allocator@D@2@@std@@QAEAAV12@QBD@Z", CallingConvention = __CallingConvention.ThisCall)]
            internal static extern __IntPtr Assign(__IntPtr __instance, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(CppSharp.Runtime.UTF8Marshaller))] string _Ptr);

            [SuppressUnmanagedCodeSecurity, DllImport("Std-symbols", EntryPoint = "?data@?$basic_string@DU?$char_traits@D@std@@V?$allocator@D@2@@std@@QBEPBDXZ", CallingConvention = __CallingConvention.ThisCall)]
            internal static extern __IntPtr Data(__IntPtr __instance);
        }

        public static global::Std.BasicString<sbyte, global::Std.CharTraits<sbyte>, global::Std.Allocator<sbyte>> Assign(this global::Std.BasicString<sbyte, global::Std.CharTraits<sbyte>, global::Std.Allocator<sbyte>> @this, string _Ptr)
        {
            var __arg0 = @this is null ? __IntPtr.Zero : @this.__Instance;
            var ___ret = __Internal.Assign(__arg0, _Ptr);
            var __result0 = global::Std.BasicString<sbyte, global::Std.CharTraits<sbyte>, global::Std.Allocator<sbyte>>.__GetOrCreateInstance(___ret, false);
            return __result0;
        }

        public static string Data(this global::Std.BasicString<sbyte, global::Std.CharTraits<sbyte>, global::Std.Allocator<sbyte>> @this)
        {
            var __arg0 = @this is null ? __IntPtr.Zero : @this.__Instance;
            var ___ret = __Internal.Data(__arg0);
            return CppSharp.Runtime.MarshalUtil.GetString(global::System.Text.Encoding.UTF8, ___ret);
        }
    }
}

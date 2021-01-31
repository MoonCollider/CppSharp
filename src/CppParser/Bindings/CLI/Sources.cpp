// ----------------------------------------------------------------------------
// <auto-generated>
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
// </auto-generated>
// ----------------------------------------------------------------------------
#include "Sources.h"

using namespace System;
using namespace System::Runtime::InteropServices;

CppSharp::Parser::SourceLocation::SourceLocation(::CppSharp::CppParser::SourceLocation* native)
{
    __ID = native->ID;
}

CppSharp::Parser::SourceLocation^ CppSharp::Parser::SourceLocation::__CreateInstance(::System::IntPtr native)
{
    return gcnew ::CppSharp::Parser::SourceLocation((::CppSharp::CppParser::SourceLocation*) native.ToPointer());
}

CppSharp::Parser::SourceLocation::SourceLocation(::CppSharp::CppParser::SourceLocation* native, bool ownNativeInstance)
{
    __ID = native->ID;
}

CppSharp::Parser::SourceLocation^ CppSharp::Parser::SourceLocation::__CreateInstance(::System::IntPtr native, bool __ownsNativeInstance)
{
    return gcnew ::CppSharp::Parser::SourceLocation((::CppSharp::CppParser::SourceLocation*) native.ToPointer(), __ownsNativeInstance);
}

CppSharp::Parser::SourceLocation::SourceLocation(unsigned int ID)
{
    ::CppSharp::CppParser::SourceLocation _native(ID);
    this->ID = _native.ID;
}

CppSharp::Parser::SourceLocation::operator CppSharp::Parser::SourceLocation(unsigned int ID)
{
    auto __ret = (::CppSharp::CppParser::SourceLocation) ID;
    return ::CppSharp::Parser::SourceLocation((::CppSharp::CppParser::SourceLocation*)&__ret);
}

unsigned int CppSharp::Parser::SourceLocation::ID::get()
{
    return __ID;
}

void CppSharp::Parser::SourceLocation::ID::set(unsigned int value)
{
    __ID = value;
}

CppSharp::Parser::SourceRange::SourceRange(::CppSharp::CppParser::SourceRange* native)
    : __ownsNativeInstance(false)
{
    NativePtr = native;
}

CppSharp::Parser::SourceRange^ CppSharp::Parser::SourceRange::__CreateInstance(::System::IntPtr native)
{
    return gcnew ::CppSharp::Parser::SourceRange((::CppSharp::CppParser::SourceRange*) native.ToPointer());
}

CppSharp::Parser::SourceRange::SourceRange(::CppSharp::CppParser::SourceRange* native, bool ownNativeInstance)
    : __ownsNativeInstance(ownNativeInstance)
{
    NativePtr = native;
}

CppSharp::Parser::SourceRange^ CppSharp::Parser::SourceRange::__CreateInstance(::System::IntPtr native, bool __ownsNativeInstance)
{
    return gcnew ::CppSharp::Parser::SourceRange((::CppSharp::CppParser::SourceRange*) native.ToPointer(), __ownsNativeInstance);
}

CppSharp::Parser::SourceRange::~SourceRange()
{
    delete NativePtr;
}

CppSharp::Parser::SourceRange::SourceRange(CppSharp::Parser::SourceRange^ _0)
{
    __ownsNativeInstance = true;
    if (ReferenceEquals(_0, nullptr))
        throw gcnew ::System::ArgumentNullException("_0", "Cannot be null because it is a C++ reference (&).");
    auto &__arg0 = *(::CppSharp::CppParser::SourceRange*)_0->NativePtr;
    NativePtr = new ::CppSharp::CppParser::SourceRange(__arg0);
}

CppSharp::Parser::SourceRange::SourceRange()
{
    __ownsNativeInstance = true;
    NativePtr = new ::CppSharp::CppParser::SourceRange();
}

System::IntPtr CppSharp::Parser::SourceRange::__Instance::get()
{
    return System::IntPtr(NativePtr);
}

void CppSharp::Parser::SourceRange::__Instance::set(System::IntPtr object)
{
    NativePtr = (::CppSharp::CppParser::SourceRange*)object.ToPointer();
}

CppSharp::Parser::SourceLocation CppSharp::Parser::SourceRange::BeginLoc::get()
{
    return ::CppSharp::Parser::SourceLocation((::CppSharp::CppParser::SourceLocation*)&((::CppSharp::CppParser::SourceRange*)NativePtr)->beginLoc);
}

void CppSharp::Parser::SourceRange::BeginLoc::set(CppSharp::Parser::SourceLocation value)
{
    auto _marshal0 = ::CppSharp::CppParser::SourceLocation();
    _marshal0.ID = value.ID;
    ((::CppSharp::CppParser::SourceRange*)NativePtr)->beginLoc = _marshal0;
}

CppSharp::Parser::SourceLocation CppSharp::Parser::SourceRange::EndLoc::get()
{
    return ::CppSharp::Parser::SourceLocation((::CppSharp::CppParser::SourceLocation*)&((::CppSharp::CppParser::SourceRange*)NativePtr)->endLoc);
}

void CppSharp::Parser::SourceRange::EndLoc::set(CppSharp::Parser::SourceLocation value)
{
    auto _marshal0 = ::CppSharp::CppParser::SourceLocation();
    _marshal0.ID = value.ID;
    ((::CppSharp::CppParser::SourceRange*)NativePtr)->endLoc = _marshal0;
}


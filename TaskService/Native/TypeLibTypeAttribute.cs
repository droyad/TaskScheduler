#if NETSTANDARD
using System;

namespace System.Runtime.InteropServices
{
    public class TypeLibTypeAttribute : Attribute
    {
        public TypeLibTypeAttribute(short v)
        {
        }
    }
}
#endif
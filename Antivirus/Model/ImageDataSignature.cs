using System.Runtime.InteropServices;

namespace Antivirus.Model
{
    [StructLayout(LayoutKind.Explicit)]
    public struct IMAGE_DATA_SIGNATURE
    {
        [FieldOffset(0)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public char[] Signature;
    }
}

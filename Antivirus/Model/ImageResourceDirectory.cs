using System;

namespace Antivirus.Model
{
    public struct IMAGE_RESOURCE_DIRECTORY
    {
        public UInt32 Characteristics;
        public UInt32 TimeStamp;
        public UInt16 MajorVersion;
        public UInt16 MinorVersion;
        public UInt16 NumberOfNameEntries;
        public UInt16 NumberOfIDEntries;
    }
}

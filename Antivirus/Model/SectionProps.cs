using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antivirus.Model
{
    public struct SECTION_PROPS
    {
        public double meanEntropy;
        public float minEntropy;
        public float maxEntropy;
        public double meanRawSize;
        public uint minRawSize;
        public uint maxRawSize;
        public double meanVirtualSize;
        public uint minVirtualSize;
        public uint maxVirtualSize;
    }
}

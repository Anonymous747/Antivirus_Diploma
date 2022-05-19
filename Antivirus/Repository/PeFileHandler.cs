using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antivirus.Repository
{
    static public class PeFileHandler
    {
        static public double GetMeanRawSize(this List<uint> rawSizes) => rawSizes.Aggregate((x, y) => x + y) / rawSizes.Count;
    }
}

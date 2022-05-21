using System;
using System.Collections.Generic;
using System.Linq;

namespace Antivirus.Source
{
    static class Extensions
    {
        static public bool isEmty(this string[] strings) {
            if (strings.Length == 0) {
                return true;
            }

            return false;
        }

        static public string GetFileName(this string s)
        {
            var array = s.Split('\\');
            return array[array.Length - 1];
        }

        static public double GetAverageValue(this List<uint> rawSizes) => rawSizes.Aggregate((x, y) => x + y) / rawSizes.Count;

        static public double GetAverageValue(this List<float> rawSizes) => rawSizes.Aggregate((x, y) => x + y) / rawSizes.Count;
    }
}

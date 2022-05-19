using Antivirus.Source;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Antivirus.Repository
{
    static public class StringFormatter
    {
        static public string[] GetMd5ForPrinting(string[] fileNames)
        {
            if (fileNames.isEmty())
            {
                return new string[1] { "" };
            }

            if (fileNames.Length == 1)
            {
                return new string[1] { GetMD5FromFile(fileNames.Last()) };
            }

            var keys = new List<string>() { GetMD5FromFile(fileNames[0]) };
            for (int i = 1; i < fileNames.Length; i++)
            {
                keys.Add(GetMD5FromFile(fileNames[i]));
            }

            return keys.ToArray();
        }

        public static string GetMD5FromFile(string filePath)
        {
            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(filePath))
                {
                    return BitConverter.ToString(md5.ComputeHash(stream)).Replace("-", string.Empty).ToLower();
                }
            }
        }

    }
}

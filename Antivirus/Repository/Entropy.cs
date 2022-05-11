using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antivirus.Repository
{
    public static class Entropy
    {

        public static float GetEntropy(this byte[] c)
        {
            int[] numArray = new int[0x100];
            byte[] buffer = c;
            // Initialize each element to zero
            for (int i = 0; i < 0x100; i++)
            {
                numArray[i] = 0;
            }

            // Histogram of each byte
            for (int j = 0; j < (buffer.Length - 1); j++) 
            {
                int index = buffer[j];
                numArray[index]++;
            }

            int length = buffer.Length;
            float entropy = 0f;
            
            for (int k = 0; k < 0x100; k++)
            {
                if ((numArray[k] != 0) && (k != 0))
                {
                    double probability = (float)numArray[k] / (float)length;
                    entropy -= (float)(probability * Math.Log(probability, 2.0));
                }
            }

            return entropy;
        }
    }
}

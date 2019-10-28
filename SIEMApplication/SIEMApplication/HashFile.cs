using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace SIEMApplication
{
    class HashFile
    {
        //calculate md5 hash value for file
        public string GetFileChecksum(string file, HashAlgorithm algorithm) {
            string result = string.Empty;
            using (FileStream fs = File.OpenRead(file)) {
                result = BitConverter.ToString(algorithm.ComputeHash(fs)).ToLower().Replace("-", "");
            }

            return result;
        }


    }
}

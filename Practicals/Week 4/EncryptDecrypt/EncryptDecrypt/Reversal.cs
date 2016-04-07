using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptDecrypt
{
    class Reversal : IEncrypt
    {
        public string Encrypt(string encryptText)
        {
            //Convert the passed string into a char array
            char[] encryptAsChar = encryptText.ToArray();

            //Use .Reverse on the array
            Array.Reverse(encryptAsChar);

            //Return the array as a string.
            return new string(encryptAsChar);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptDecrypt
{
    class Rot13 : IEncrypt
    {
        public string Encrypt(string encryptText)
        {
            //Convert the passed string into a char array
            char[] encryptAsChar = encryptText.ToArray();

            //Perform Rot13 encryption on the string array
            //Logic borrowed from dotnetperls.com/rot13
            for (int i = 0; i < encryptAsChar.Length; i++)
            {
                //Save the currently observed array slot as an int
                int indexAsNumber = (int)encryptAsChar[i];

                //Make sure number will convert safely within, eg. Can't add 13 to 26 and still get a valid value.
                if (indexAsNumber >= 'a' && indexAsNumber <= 'z')
                {
                    if (indexAsNumber > 'm')
                    {
                        indexAsNumber -= 13;
                    }
                    else
                    {
                        indexAsNumber += 13;
                    }
                }
                else if (indexAsNumber >= 'A' && indexAsNumber <= 'Z')
                {
                    //Same as above but for handling uppercase
                    if (indexAsNumber > 'M')
                    {
                        indexAsNumber -= 13;
                    }
                    else
                    {
                        indexAsNumber += 13;
                    }
                }
                //Cast the number back to a char
                encryptAsChar[i] = (char)indexAsNumber;
            }
            //Return the array as a string.
            return new string(encryptAsChar);
        }
    }
}

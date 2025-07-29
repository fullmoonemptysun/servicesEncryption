using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrankEncrypt
{
    public class Encryptor
    {
        public static string Encrypt(string enstr, string seed)
        {
            if (!int.TryParse(seed, out int seedValue))
                return "Invalid seed value.";

            char[] encrypted = new char[enstr.Length * 2];
            for (int i = 0, j = 0; i < enstr.Length; i++, j += 2)
            {
                int eo = (enstr[i] % 2) == 0 ? 2 : 3;
                encrypted[j] = (char)(enstr[i] + seedValue + eo);
                encrypted[j + 1] = (char)(eo + 48); // store eo as a char
            }
            return new string(encrypted);
        }
        public static string Decrypt(string destr, string seed)
        {
            if (!int.TryParse(seed, out int seedValue))
                return "Invalid seed value.";

            char[] decrypted = new char[destr.Length / 2];
            for (int i = 0, j = 0; i < destr.Length - 1; i += 2, j++)
            {
                char temp = destr[i];
                int eo = destr[i + 1] - '0'; // get eo from encrypted data
                decrypted[j] = (char)(temp - seedValue - eo);
            }
            return new string(decrypted);
        }
    }
}

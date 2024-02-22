using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Welcome.Others
{
    internal static class EncodingConverter
    {
        private static Encoding encoding = Encoding.UTF8;

        public static string EncryptPassword(string password)
        {
            byte[] passwordBytes = encoding.GetBytes(password);
            return Convert.ToBase64String(passwordBytes);
        }

        public static string DecryptPassword(string encodedData)
        {
            Decoder decoder = encoding.GetDecoder();
            byte[] todecode_byte = Convert.FromBase64String(encodedData);
            int charCount = decoder.GetCharCount(todecode_byte, 0, todecode_byte.Length);
            char[] decoded_char = new char[charCount];
            decoder.GetChars(todecode_byte, 0, todecode_byte.Length, decoded_char, 0);
            string result = new String(decoded_char);
            return result;
        }
    }
}

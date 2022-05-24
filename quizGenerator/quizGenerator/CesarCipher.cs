using System;
using System.Collections.Generic;
using System.Text;

namespace quizGenerator
{
    public static class CesarCipher
    {
        static private char coding(char ch, int key)
        {
            if (!char.IsLetter(ch))
            {

                return ch;
            }

            char d = char.IsUpper(ch) ? 'A' : 'a';
            return (char)((((ch + key) - d) % 26) + d);
        }
        public static string Caesar_coding(string text, int key)
        {
            string output = string.Empty;

            foreach (char ch in text)
                output += coding(ch, key);

            return output;
        }

        public static string Caesar_decoding(string text, int key)
        {
            return Caesar_coding(text, 26 - key);
        }
    }
}

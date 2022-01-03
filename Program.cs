using System;
using System.Collections.Generic;
using System.Linq;

namespace EncryptChar
{
    class Program
    {
        static void Encrypt(int repeat, char letter)
        {
            List<char> OutputCharactes = new List<char>();
            char symbol = letter;
            for (int i = 0; i < repeat; i++)
            {
                symbol = char.Parse(Console.ReadLine());
                OutputCharactes.Add(symbol);
            }
            foreach (char ch in OutputCharactes)
            {
                string result = "";
                int firstNum = 0;
                int lastNum = 0;
                int convertToNum = ((int)ch);
                if (convertToNum > 99)
                {
                    firstNum = (convertToNum % 1000) / 100;
                }
                else
                {
                    firstNum = (convertToNum % 100) / 10;
                }
                lastNum = (convertToNum % 10) / 1;

                int firstInOut = convertToNum + lastNum;
                char firstSymbol = ((char)firstInOut);

                int lastInOut = convertToNum - firstNum;
                char lastSymbol = ((char)lastInOut);

                result = firstSymbol.ToString() + firstNum.ToString() + lastNum.ToString() + lastSymbol.ToString();
                Console.Write(result);
            }
        }
        static void Main()
        {
            int repeatT = int.Parse(Console.ReadLine());
            char ch = ' ';
            Encrypt(repeatT, ch);
        }
    }
}

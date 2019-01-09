using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostCommonCharacterInString_NoLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> testInputs = new List<string>
            {
                "",
                "a",
                "z",
                "zz",
                "fndgndkfoongosndooifoansoodf",
                "zz ",
                "zz2",
                "z22",
                "z!!",
                "!",
                "aazz",
                "zzaa"
            };
            foreach(var input in testInputs)
            {
                Console.WriteLine($"{input} : {MostCommonCharInString_NoLinq(input)}");
            }
            Console.ReadLine();
        }

        public static char MostCommonCharInString_NoLinq(string input)
        {
            if(input.Length == 0)
            {
                return char.MinValue;
            }
            // Use array of 26 length to store counts. Minus 'a' from each character to set to the correct index
            int[] charCounts = new int[26];
            long currentMax = 0;
            char currentMaxChar = char.MinValue;

            foreach(char character in input)
            {
                int index = character - 'a';
                if (index >= 0 && index < charCounts.Length)
                {
                    charCounts[index]++;
                    if (charCounts[index] > currentMax || (charCounts[index] == currentMax && character < currentMaxChar))
                    {
                        currentMax = charCounts[index];
                        currentMaxChar = character;
                    }
                }
            }

            return currentMaxChar;

        }
    }
}

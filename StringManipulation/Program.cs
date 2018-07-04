using System;
using System.Collections.Generic;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args) 
        {
             Compress();
             JewelsAndStones();
        }

        public static void Compress()
        {
            System.Console.WriteLine("-----------COMPRESS STRING----------");
            var output = "";
            var input = "abbcccddBBb";

            int current_index;
            int count = 1;

            for (current_index = 0; current_index < input.Length-1; current_index++)
            {
                var current_letter = input[current_index];
                var next_letter = input[current_index + 1];

                if (current_letter == next_letter) count++; // if the letter are similar, increase count and loop again

                else
                {
                    // if the letter is different, add the count and letter.
                    output = output + input[current_index] + count;
                    count = 1; // reset the count
                }
            }

            output = output + input[current_index] + count;
            System.Console.WriteLine(output);
        }

        public static void JewelsAndStones()
        {
            System.Console.WriteLine("-----------JEWELS AND STONES----------");
            var jewels = "aAb";
            var stones = "aaAbbbb";
            var count = 0;

    	    foreach (var stone in stones)
                foreach (var jewel in jewels)
                    if(stone == jewel) count++;

            System.Console.WriteLine("Output: "+ count);
        }

    }
}

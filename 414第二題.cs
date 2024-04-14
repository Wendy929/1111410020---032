using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("數字：");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int number))
            {
                if (number >= 1 && number < 4000)
                {
                    string romanNumeral = ConvertToRoman(number);
                    Console.WriteLine($"羅馬數字為：{romanNumeral}");
                }
                else
                {
                    Console.WriteLine("請輸入1 到 3999！");
                }
            }
            else
            {
                Console.WriteLine("請輸入數字。");
            }

            Console.ReadLine();
        }

        static string ConvertToRoman(int number)
        {
          
            string[] thousands = { "", "M", "MM", "MMM" };
            string[] hundreds = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            string[] tens = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            string[] ones = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };

            int thou = number / 1000;
            int hund = (number % 1000) / 100;
            int ten = (number % 100) / 10;
            int one = number % 10;

            return thousands[thou] + hundreds[hund] + tens[ten] + ones[one];
        }
    }
}

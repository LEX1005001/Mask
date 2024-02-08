using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mask
{
    class Program
    {
        static void Main()
        {
            int maskValue = 1;
            int maxNumber = 10000;

            Console.WriteLine("Число\tРезультат деления на 2024");
            Console.WriteLine("-------------------------------");

            for (int i = 0; i <= maxNumber; i++)
            {
                if (CheckMask(i.ToString(), "1?2157*4") && i % 2024 == 0)
                {
                    Console.WriteLine($"{i}\t{i / 2024}");
                }
            }
            Console.ReadKey();
        }

        static bool CheckMask(string number, string mask)
        {
            if (number.Length != mask.Length)
            {
                return false;
            }

            for (int i = 0; i < number.Length; i++)
            {
                if (mask[i] == '?')
                {
                    if (!Char.IsDigit(number[i]))
                    {
                        return false;
                    }
                }
                else if (mask[i] == '*')
                {
                    if (!Char.IsDigit(number[i]) && number[i] != '0')
                    {
                        return false;
                    }
                }
                else
                {
                    if (number[i] != mask[i])
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    
    }

}

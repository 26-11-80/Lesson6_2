using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите предложение");

            string str = Console.ReadLine().ToLower();

            string temp = str;

            string reverseStr = "";

            for (int i = temp.Length - 1; i >= 0; i--)
            {
                reverseStr += temp[i];
            }

            if (temp == reverseStr)
            {
                Console.WriteLine("это палиндром");
            }
            else
            {
                Console.WriteLine("это не палиндром");
            }

            Console.ReadKey();

        }
    }
}

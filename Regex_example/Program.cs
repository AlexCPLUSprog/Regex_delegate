using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexExample
{
    delegate string myDel(int number);  // делегат
    class Program
    {
        static string NumName(int number)
        {
            Console.WriteLine("NumName");
            string result = string.Empty;
            switch (number)
            {
                case 0: result = "Нуль"; break;


                default: break;
            }
            return result;
        }

        static string test (int num) 
        {
            Console.WriteLine("test");
            return "test";
        }
        static void Main(string[] args)
        {
            myDel print = NumName;
            print += test;
            print -= NumName;
            print(0);
           // Console.WriteLine(print(0)); 


            //////////////////////
           /* for (int i = (int)'0'; i <= (int)'9'; i++)
            {
                Console.WriteLine($"Код символа {(char)i} = {i}");
            }*/
            /*string input = "НатаШа наташа Наташа ашатан";
            if (args.Length > 0)
            {
                input = args[0];
            }
            Regex regex = new Regex(@"(Наташа)", RegexOptions.RightToLeft);
            MatchCollection matchFind = regex.Matches(input);
            int counter = 0;
            foreach (var item in matchFind)
            {
                Console.WriteLine($"Совпадение номер {counter} {item}");
                counter++;
            }*/






        }
    }

}
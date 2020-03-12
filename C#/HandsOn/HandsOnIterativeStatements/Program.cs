using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnIterativeStatements
{
    class Program
    {
        public static void Greet(string name)
        {
            int flag = 1;
            while(flag<=10)
            {
                Console.WriteLine("Hello " + name);
                flag++;
            }
        }
        public static void DisplayNaturalNos(int i)
        {
            int flag = 1;
            while(flag<=i)
            {
                Console.Write(flag + " ");
                flag++;
            }
        }
        public static void DisplayWholeNos(int i)
        {
            int flag = 0;
            do
            {
                Console.Write(flag + "\t");
                flag++;
            } while (flag <= i);
        }
        public static int ReturnFactorial(int k)
        {
            int fact = 1;
            //for(int i=1;i<=k;i++)
            //{
            //    fact = fact * i;
            //}
            int i = 1;
            //for(;i<=k;i++)
            //{
            //    fact = fact * i;
            //}
            //for(;i<=k;)
            //{
            //    fact = fact * i;
            //    i++;
            //}
            for(; ; )
            {
                if (i <= k)
                {
                    fact = fact * i;
                    i++;
                }
                else
                    break;//terminating loop
            }
            return fact;
        }
        public static void DisplayEven(int no)
        {
            for(int j=1;j<=no;j++)
            {
                if (j % 2 == 1)
                    continue; //terminate current iteration
                Console.Write(j + "\t");
            }
        }
        public static string CheckVowel(char ch)
        {
            string result = null;
            switch(ch)
            {
                case 'i':
                    result = "Vowel";
                    break;
                case '1':
                    result = "Vowel";
                    break;
                case 'e':
                    result = "Vowel";
                    break;
                case 'o':
                    result = "Vowel";
                    break;
                case 'u':
                    result = "Vowel";
                    break;
                default:
                    result = "Invalid Input";
                    break;
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(CheckVowel('0'));
            Console.WriteLine(CheckVowel('i'));
            // DisplayEven(100);
            //Greet("Sachin");
            // DisplayNaturalNos(100);
            //DisplayWholeNos(40);
            // Console.WriteLine(ReturnFactorial(5));
            Console.ReadKey();
        }
    }
}

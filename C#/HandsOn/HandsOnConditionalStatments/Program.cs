using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnConditionalStatments
{
    class Program
    {
        public static string EvenorOdd(int i)
        {
            if (i % 2 == 0)
            {
                return "Even";
            }
            else
            {
                return "Odd";
            }
        }
        public static int Max(int i,int j,int k)
        {
            if(i>j)
            {
                if (i > k)
                    return i;
                else
                    return k;
            }
            else
            {
                if (j>k)
                    return j;
                else
                    return k;
            }
        }
        public static string Result(double m1,double m2,double m3,double m4,double m5)
        {
            double avg = (m1 + m2 + m3 + m4 + m5) / 5;
            if (avg >= 70)
                return "Distinction with "+avg+"%";
            else if (avg >= 60 && avg < 70)
                return "FirstClass with " + avg + "%";
            else if (avg >= 50 && avg < 60)
                return "SecondClass with " + avg + "%";
            else
                return "Fail";
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Result(87.5, 56.6, 89.5, 89, 90));
            double m1 = Convert.ToDouble(Console.ReadLine());
            double m2 = Convert.ToDouble(Console.ReadLine());
            double m3 = Convert.ToDouble(Console.ReadLine());
            double m4 = Convert.ToDouble(Console.ReadLine());
            double m5 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Result(m1, m2, m3, m4, m5));
            // Console.WriteLine("Enter no");
            // int i = int.Parse(Console.ReadLine());
            //string result= EvenorOdd(i);
            // Console.WriteLine(result);
            // Console.WriteLine(Max(12, 23, 10));
            Console.ReadKey();
        }
    }
}

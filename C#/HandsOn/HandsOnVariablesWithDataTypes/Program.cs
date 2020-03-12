using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnVariablesWithDataTypes
{
    class Program
    {
        string name;//instace variable
        static double salary;//static variable

        static void Main(string[] args)
        {
            int i=60;//local varaible
            int[] a = new int[4] { 12, 23, 34, 45 };
            Console.WriteLine(i);
            Console.WriteLine(Program.salary);
            Program obj = new Program();
            Console.WriteLine(obj.name);
            object o1 = 100;
            o1 = "Ram";
            o1 = 'a';
            o1 = 12.3;
            int k = 10;
            string name = "Rohan";
            Console.WriteLine("Name:{0} Age:{1}", name, k);
            Console.ReadKey();
        }
    }
}

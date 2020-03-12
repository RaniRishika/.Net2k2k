using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //array declaration
            int[] i = new int[4];
            //assign value
            i[0] = 12;
            i[1] = 20;
            i[2] = 68;
            i[3] = 40;
           // i[4] = 5;  runtime exception
            //accessing array value at index 2
            int k = i[2];
            Console.WriteLine(i[1]);
            //display all the array values
            for(int a=0;a<4;a++)
            {
                Console.WriteLine(i[a]);
            }
            foreach(int no in i)
            {
                Console.WriteLine(no);
            }
            Console.ReadKey();
        }
    }
}

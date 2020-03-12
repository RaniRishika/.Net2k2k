using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnArrays
{
    class Demo4
    {
        static void Main()
        {
            //search a value in array
            string[] names = new string[8]
            {
                "Rohan",
                "Rajan",
                "Suren",
                "Jeson",
                "Monica",
                "Sachin",
                "Komal",
                "David"
            };
            int flag = 0;
            Console.WriteLine("Entre name");
            string name = Console.ReadLine();
            foreach(string n in names)
            {
                if (name == n)
                {
                    flag = 1;
                    
                    break;
                }
               
            }
            if (flag == 0)
                Console.WriteLine("Name not Exist");
            else
                Console.WriteLine("Name Exist");

        }
    }
}

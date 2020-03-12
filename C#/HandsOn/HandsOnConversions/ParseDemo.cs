using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnConversions
{
    class ParseDemo
    {
        static void Main()
        {
            sbyte i1 = sbyte.Parse("123");
            float f1 = float.Parse("123.3");
            decimal d1 = decimal.Parse("123.45");
            bool b = bool.Parse("true");
            Console.WriteLine("{0}, {1}, {2}, {3}", i1, f1, d1, b);
            string s = "100";
            int i = int.Parse(s);
            double d = double.Parse(s);
            long l = long.Parse(s);
            //i = int.Parse("dfsljkds"); //exception


        }
    }
}

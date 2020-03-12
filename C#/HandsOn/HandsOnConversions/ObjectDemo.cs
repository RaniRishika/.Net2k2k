using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnConversions
{
    class ObjectDemo
    {
        static void Main()
        {
            int i = 10;
            double d = 10.4;
            float f = 12.3f;
            char ch = 'a';
            //boxing
            object o = i;
            object o1 = d;
            object o2 = f;
            object o3 = ch;
            //unboxing
            object ob = 12;
            int k = (int)ob;
            object ob1 = 12.3;
            double d1 = (double)ob1;
            object ob2 = 'a';
            char ch1 = (char)ob2;
            object ob3 = "abc";
            string s = ob3.ToString();
            //convert int to string
            s = i.ToString();
            s = d1.ToString();
        }

    }
}

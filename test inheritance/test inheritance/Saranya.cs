using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_inheritance
{
    public class Saranya : Laxmi
    {
        public static void Main()
        {
            Saranya S2 = new Saranya();
            S2.Test1();
            S2.Test2();
            S2.Test3();
            S2.Test4();
            Console.WriteLine("hi mom");
        }


        public void Test3()
        {
            Console.WriteLine("I LOVE YOT MOM");
        }
        public void Test4()
        {
            Console.WriteLine("missing you");
        }
    }
}
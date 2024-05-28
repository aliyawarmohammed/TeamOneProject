using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamOneProject
{
    internal class ValueTypeExample
    {

        public static void Main()
        {

            int a = 10;  //int- a 1000

            Console.WriteLine(a);//10

            test(a);

            Console.WriteLine(a);//10
            Console.ReadLine();
        }

        static void test(int i) //i=10    int- i 2000
        {
            i = 20;
            Console.WriteLine(i);//20
        }
    }
}

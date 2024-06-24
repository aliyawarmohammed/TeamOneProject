using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamOneProject
{
    internal class RefAndOutExample2
    {

        public static void Main()
        {
            int a = 10, b = 20, addresult,subResult;

            Math(a, b, out addresult,out subResult);

            Console.WriteLine("Addition of two numbers {0}", addresult);
            Console.WriteLine("subtraction of two numbers {0}", subResult);

            Console.ReadLine();

        }
        public static void Math(int a, int b, out int addresult, out int subResult)
        {
            subResult = a - b;
            addresult = a + b;
        }
    }
}

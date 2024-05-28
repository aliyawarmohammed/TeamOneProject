using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamOneProject
{
    internal class forloopexample
    {
        public static void  Main()
        {
          
            for (int i=1; i<=10 ;i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("even no is "+i);
                }
                else
                {
                    Console.WriteLine("odd no is " + i);

                }
            }
            Console.ReadLine();
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamOneProject
{
    internal class ForeachExample
    {
        public static void Main()
        { 
        
            int a= 1;
            int[] marks= {100,200,300};

            foreach(int i in marks)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}

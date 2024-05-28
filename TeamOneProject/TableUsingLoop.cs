using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamOneProject
{
    internal class TableUsingLoop
    {
        public static void Main()
        {
            Console.WriteLine("Please Enter Table Number");
            int n = Convert.ToInt32(Console.ReadLine());//3
            for (int i = 1; i <=10; i++)
            {
                Console.WriteLine("{0}x{1}={2}",n,i,n*i);
            }
            Console.ReadLine();
        }
    }
}

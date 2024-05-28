using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamOneProject
{
    internal class WhileloopSecondExample
    {
        public static void Main()
        {
            char ans = 'y';

            while (ans=='y')
            {
                Console.WriteLine("Thanks for Visiting Office");
                Console.WriteLine("Do you want to Quit y/n");

                 ans = Convert.ToChar(Console.ReadLine());
            }
            Console.ReadLine();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamOneProject
{
    internal class doWileloopExample
    {

        public static void Main()
        {
            string ans;
            do
            {
                Console.WriteLine("Thank you for doing Shopping!");
                Console.WriteLine("Do you want to Continue...");
                 ans = Console.ReadLine();

            }
            while (ans=="yes");//true or false
            Console.ReadLine();
        }
    }
}

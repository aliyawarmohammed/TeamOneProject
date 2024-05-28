using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Wap to Print either you aer Eligible for Voting or not

namespace TeamOneProject
{
    internal class VotingAppExample
    {
        public static void Main()
        {
            Console.WriteLine("Please Enter Number");
            int Num = Convert.ToInt32(Console.ReadLine());

            if (Num%2==0)
            {
                Console.WriteLine("Even Number");
            }
            else
            {
                Console.WriteLine("Odd Number");

            }
            Console.ReadLine();
        }
    }
}



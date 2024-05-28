using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//wap to print youar eligible for bonus if you are getting A grade
//and having salary less then 30000

namespace TeamOneProject
{
    internal class NestedIfExample
    {
        public static void Main()
        {
            char Grade = 'A'; float salary = 20000;
            if (Grade == 'A')
            {
                if (salary < 30000)
                {
                    Console.WriteLine("You are Eligible for Bonus");
                }
                else
                {
                    Console.WriteLine("You are Not Eligible for Bonus");

                }
            }
            else
            {
                Console.WriteLine("You are Not Eligible for Bonus");

            }
            Console.ReadLine();
        }

    }
}


//if(condition)
//{
//if()
//{
//statement
//}
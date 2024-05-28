using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamOneProject
{
    internal class EmployeeDetailsUsingArray
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to Student App");


            int[] studId = new int[3];
            string[] stName = new string[3];
            double[] stMarks = new double[3];

            Console.WriteLine("Enter student Details");

            for (int i = 0; i < studId.Length; i++)
            {
                Console.WriteLine("Enter student Id {0}", i);

                studId[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter student Name {0}", i);

                stName[i] = Console.ReadLine();
                Console.WriteLine("Enter student Marks {0}", i);

                stMarks[i] = Convert.ToDouble(Console.ReadLine());


            }



            for (int i = 0; i < studId.Length; i++)
            {
                Console.Write("Student Id :{0} " , studId[i]);
                Console.Write("Student Name :{0} " , stName[i]);
                Console.Write("Student Fees :{0} " ,stMarks[i]);
                Console.WriteLine();
            }

            Console.ReadLine();

        }
    }
}

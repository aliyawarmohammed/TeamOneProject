using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamOneProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int TotalMarks; //defining 
            string Name ;
            char Section;
            float Fees ;

            Console.WriteLine("Enter Name pls");
            Name= Console.ReadLine();

            Console.WriteLine("Enter Section pls");
            Section = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Enter Marks pls");
            TotalMarks = Convert.ToInt32(Console.ReadLine());// Convert.ToInt32("11") 11

            Console.WriteLine("Enter Fees pls");
            Fees = Convert.ToSingle(Console.ReadLine());// Convert.ToInt32("11.9") 11

            Console.WriteLine(Name);
            Console.WriteLine(Section);
            Console.WriteLine(TotalMarks);
            Console.WriteLine(Fees);
            Console.ReadLine();
        }
    }
}

//Variable is a named Memory Location
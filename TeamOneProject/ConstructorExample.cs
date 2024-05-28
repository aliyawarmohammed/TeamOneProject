using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamOneProject
{
    internal class ConstructorExample
    {
        int age = 100;
        public int GetEmployeeSalary()
        {
            int a = 10, b = 20;
            return a+b;
        }

        public string GetEmployeeName()
        {
            string Name="Akshay";
            return Name;
        }

        public static void Main()
        {
            ConstructorExample obj = new ConstructorExample();
            Console.WriteLine(obj.age);
            Console.WriteLine(obj.GetEmployeeSalary());
            string eName = obj.GetEmployeeName();
            Console.WriteLine(eName);
            Console.ReadLine();

        }

    }
}

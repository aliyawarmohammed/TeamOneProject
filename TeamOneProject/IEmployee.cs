using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamOneProject
{
    internal interface IEmployee
    {
        void getEmployee(string EmpName, int Salary);
        void ShowEmployee();

    }

    class EmployeeDetail : IEmployee
    {
        public void getEmployee(string EmpName, int Salary)
        {
            Console.WriteLine(EmpName);
            Console.WriteLine(Salary);
        }

        public void ShowEmployee()
        {
            Console.WriteLine("Displaying EmployeeDatils");

        }

        public static void Main()
        {
            //EmployeeDetail emp = new EmployeeDetail();
            //emp.ShowEmployee();
            //emp.getEmployee("Prashant",15000000);

            IA obj = new A();
            obj.Welcome();


            IB obj2 = new A();
            obj2.Welcome();


            Console.ReadLine();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamOneProject
{
    //Single Level Inheritance
    internal class SingleLevelInheritance
    {
      public   SingleLevelInheritance()
        {
            Console.WriteLine("Parent Class Constructor is called");
        }

        public void GetEmployee()
        {
            Console.WriteLine("Ema IT Engineer");
        }

    }

    internal class SingleLevelInheritance2:SingleLevelInheritance
    {

       public  SingleLevelInheritance2()
        {
            Console.WriteLine("Child Class Constructor is called");
        }

        public void GetEmployee2()
        {
            base.GetEmployee();
            Console.WriteLine("Akash IT Engineer");
        }

    }
    internal class SingleLevelInheritance3
    {
       public SingleLevelInheritance3()
        {
            Console.WriteLine("Main Class Constructor is called");
        }

        public static void  Main()
        {
            SingleLevelInheritance obj = new SingleLevelInheritance();
             obj.GetEmployee();
            Console.ReadLine();
        }

    }
}

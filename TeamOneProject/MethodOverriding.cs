using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamOneProject
{
    internal class MethodOverriding
    {
        public  virtual void getCustomerId()
        {
           Console.WriteLine("Customer Id is "+1212);
        }

    }
    internal class MethodOverriding2:MethodOverriding
    {
        public override void  getCustomerId()
        {
            Console.WriteLine("Customer Id is " + 1213);
        }

        public static void  Main()
        {
            MethodOverriding obj = new MethodOverriding2();
           obj.getCustomerId();
            Console.ReadLine();
        }

    }



}

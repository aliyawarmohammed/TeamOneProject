using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamOneProject
{
    internal class RefrenceTypeExample
    {
        int age = 18;
        public  static void Main()
        {
            RefrenceTypeExample obj = new RefrenceTypeExample();
            ChangedAge(obj);
            Console.WriteLine(obj.age);//90
            Console.ReadLine();
        }

        static void ChangedAge(RefrenceTypeExample rte)//rte.age=18
        {
            rte.age = 90;
        
        }
    }
}

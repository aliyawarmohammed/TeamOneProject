using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamOneProject
{
    internal class PolymorphismExample
    {
        public static void Main()
        {
            PolymorphismExample obj = new PolymorphismExample();
            obj.faculty();
            obj.faculty(1,"MVC");
            obj.faculty("MVC",2);
            Console.ReadLine();
        }

        public string faculty()
        {
            Console.WriteLine("Sir is going teach C#");
            return "a";
        }

        public string faculty(string Language,int a)
        {
            Console.WriteLine("Sir is going teach {0}",Language);
            return "a";

        }
        public void faculty(int a,string Language)
        {
            Console.WriteLine("Sir is going teach {0}", Language);
        }
    }
}

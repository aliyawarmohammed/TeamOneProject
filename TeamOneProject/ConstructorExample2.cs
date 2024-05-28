using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamOneProject
{
    internal class ConstructorExample2
    {
        int value;//class member
      public  ConstructorExample2()
        {
            Console.WriteLine("Default Constructor is Called");
        }

         ~ConstructorExample2()
        {
            Console.WriteLine("Destructor is Called");
        }


        public ConstructorExample2(int a)
        {
            value = a;
           
        }

        public ConstructorExample2(int a,string name)
        {
            Console.WriteLine("a valued {0},{1}", a,name);
        }
        public ConstructorExample2(string sname,int x)
        {
            Console.WriteLine("a valued {0},{1}", x, sname);
        }
        public static void Main()
        {
            ConstructorExample2 obj=new ConstructorExample2 ();
            ConstructorExample2 obj1 =new ConstructorExample2 (10);
            ConstructorExample2 obj2 =new ConstructorExample2 (10,"Akshay");
            Console.WriteLine(obj1.value);
            Console.ReadLine();
            
        }
    }
}

//whenever u create an object of a class constructor call automatically
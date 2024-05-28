using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace TeamOneProject
{
    internal abstract class AbstractClassExample
    {


        public AbstractClassExample()
        {
            Console.WriteLine("Constructor is called for abstract class");
        }

        public AbstractClassExample(int a)
        {
            Console.WriteLine("Constructor is called for abstract class"+a);
        }
        public abstract void add();

        //public void sub()
        //{
        //    int a = 10,b=20,c;
        //    c = a - b;
        //    Console.WriteLine("Result is:" + c);
        //}
        
    }


    class ImplementAbstractClass : AbstractClassExample
    {
        public override void add()
        {
            int x = 10, y = 20;
            Console.WriteLine("Result is:" + (x + y));
           
        }
        
    }

    class ImplementAbstractClass2: AbstractClassExample
    {

       public ImplementAbstractClass2():base(10)
        { 
        
        }
        public override void add()
        {
            int x = 10, y = 20,z=40;
            Console.WriteLine("Result is:" + (x+y+z));
            


        }
        public static void Main()
        {
            AbstractClassExample obj =new ImplementAbstractClass();
            obj.add();

            AbstractClassExample obj1 = new ImplementAbstractClass2();
            obj1.add();

            
            Console.ReadLine();

        }
    }
}

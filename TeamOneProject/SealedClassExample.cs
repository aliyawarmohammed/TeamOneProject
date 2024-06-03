using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamOneProject
{
    class  TestExample
    {
       public  virtual void sub()
        {
        
        }
    }

    internal   class SealedClassExample: TestExample
    {
        public  void Add()
        {
            Console.WriteLine("A");
        }

         }

    }

    class SealedExample2 {

        public static void Main()
        {
            SealedExample2 obj = new SealedExample2();

            //obj.Add();
            //obj.sub();
            Console.ReadLine();
        }


    } 


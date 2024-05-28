using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamOneProject
{
    internal class MultilevelInheritance
    {
        public void Animal()
        {
            Console.WriteLine("we are social animal");
            
        }
    }

    internal class MultilevelInheritance2
    {
        public void Bird()
        {
            Console.WriteLine("bird is not a social animal");

        }
    }

    internal class MultilevelInheritance3 : MultilevelInheritance
    {
        public void Tiger()
        {
            Console.WriteLine("Tiger is not a social animal");

        }
    }


    internal class MultilevelInheritance4 
    {
        public static void   Main()
        {
            MultilevelInheritance3 obj = new MultilevelInheritance3();
            //obj.Bird();
            obj.Animal();
            obj.Tiger();

            Console.ReadLine();

        }
    }
}

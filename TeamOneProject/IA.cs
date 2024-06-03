using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamOneProject
{
    internal interface IA
    {
         void Welcome();
    }
    internal interface IB
    {
        void Welcome();
    }

    class A : IA, IB
    {
         void IA.Welcome()
        {
            Console.WriteLine("IA-Apple are Sweet but Poisanable");
        }

         void IB.Welcome()
        {
            Console.WriteLine("IB-Apple are Sweet but Poisanable");
        }
    }

}


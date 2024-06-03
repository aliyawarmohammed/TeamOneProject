using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamOneProject
{
    public delegate void MathDelgateSample(int x,int y);

    internal class MathsDelegate
    {
        public void Add(int a,int b)
        {
            Console.WriteLine(a + b);
        }
        public void Sub(int a, int b)
        {
            Console.WriteLine(a - b);
        }

        public void Mul(int a, int b)
        {
            Console.WriteLine(a * b);
        }

        public static void Main()
        {

            MathsDelegate obj = new MathsDelegate();
            MathDelgateSample delAdd, dellSub, delMul,deltotal;
            //delAdd = new MathDelgateSample(obj.Add);
            //dellSub = new MathDelgateSample(obj.Sub);
            //delMul = new MathDelgateSample(obj.Mul);

            //delAdd.Invoke(10, 20);
            //dellSub.Invoke(10, 20); single cast
            //delMul.Invoke(10, 20);

            ////deltotal = new MathDelgateSample(obj.Add);
            ////deltotal += new MathDelgateSample(obj.Sub);multicast delegate
            //deltotal += new MathDelgateSample(obj.Mul);
            //deltotal.Invoke(10, 20);


            Console.ReadLine();

        }
    }
}


//if one delegate is calling single mthod or invoking single method is called as single cast delegate
//if one delegate is calling multiple method or invoking multiple method is called as
 //multicast delegate
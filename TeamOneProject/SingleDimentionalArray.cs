using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamOneProject
{
    internal class SingleDimentionalArray
    {
        public static void Main()
        {
            int[] a = { 1, 2, 3, 4, 5, 6 }; //Declaraing array and initilization
            string[] StudentNames = {"Rishika","Ema","Nitish" };
            //int[] b= new int[2] { 1, 2};

            //int[] c = new int[2];
            //c[0] = 5;
            //c[1]=6;

            //for (int i = 0;i<a.Length;i++)
            //{
            //    Console.WriteLine(a[i]);//length of array  no element -1
            //}

            foreach (int i in a)
            {
                Console.Write(i);
            }
            Console.WriteLine();

            foreach (string sname in StudentNames)
            {
                Console.Write(sname);
            }
            Console.WriteLine();

          
            for (int i = 0; i < a.Length; i++)
            {
                if(i==1)
                {
                    a[i] = 9;
                }
                Console.Write(a[i]);
            }


            Console.ReadLine();
        }
    }
}

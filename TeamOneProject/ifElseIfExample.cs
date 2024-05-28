using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Wap to Print which values greatest
//a,b,c
////wap to print the person name and his favorite dish /navya,komal,aditya
namespace TeamOneProject
{
    internal class ifElseIfExample
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Enter Name Pls");
            string Name = Console.ReadLine();
            
            if(Name== "navya")
            {
                Console.WriteLine(Name);
                Console.WriteLine("Sweets");

            }
            else if(Name=="Komal")
            {
                Console.WriteLine(Name);
                Console.WriteLine("puranpoli");

            }
            else if(Name=="Rishika")
            {
                Console.WriteLine(Name);
                Console.WriteLine("Jilabi");
            }


            Console.ReadLine();

















            //int a = 10, b = 20, c = 30;

            //if (a > b && a > c)//&& is called And Operator
            //{
            //    Console.WriteLine("a is greater");
            //}
            //else if (b > a || b > c)// || or Operator
            //{
            //    Console.WriteLine("b is greater");
            //}
            //else if (c > a && c > b)
            //{
            //    Console.WriteLine("c is greater");
            //}
            //else
            //{
            //    Console.WriteLine("All are Equal");
            //}



        }
    }
}


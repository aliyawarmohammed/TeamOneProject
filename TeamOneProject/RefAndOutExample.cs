using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TeamOneProject
{
    internal class RefAndOutExample
    {
        public static void Main()
        {
            int a = 10, b = 20, result;

            add(a, b, out result);//calling

            Console.WriteLine(result);

            Console.ReadLine();
        
        }
        public static void add(int a,int b, out int result )//called
        {
            result = a + b;
        }
    }
}


//whenever you are taking Out keyword before leaving called method u need to 
//assign value to it else it will throw error
//for ref not compulsary to assign value it will not throw error before leaving called method




//for ref keyowrd variable you showld initialize value and send to calling method else you will get error
//for out keyword variable initialization not compulsary 



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamOneProject
{
    internal class ArrayClassExample
    {
        public static void Main()
        {
            int[] arr = new int[] { 9, 12, 3 };


            //Reverse Example
            //Array.Reverse(arr);
            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}

            //Array.Sort(arr);
            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}

            int[] arr2 = new int[3];

            //Array.Copy(arr, arr2, 3);

            //foreach (var item in arr2)
            //{
            //    Console.WriteLine(item);
            //}

           // Console.WriteLine(arr.Rank);
            Console.WriteLine(arr.IsFixedSize);
            Console.WriteLine(arr.Count());
            Console.WriteLine(Array.IndexOf(arr,3));

            Console.ReadLine();
        }
    }
}

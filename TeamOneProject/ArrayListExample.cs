using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamOneProject
{
    internal class ArrayListExample
    {

        public static void Main()
        {
            ArrayList st = new ArrayList();
           
            ArrayList list= new ArrayList();
            list.Add(1);
            list.Add('C');
            list.Add("Nitish");
            foreach (var item in list)
            {
                Console.WriteLine(item);

            }
            Console.WriteLine("2nd loop");
            Console.WriteLine(list.Contains('C'));
            Console.WriteLine(list[2]);//accessing Elements

            //list.Remove('C');value you can pass here
            //list.RemoveAt(2);index 
            //list.Insert(1, 15);
            // list.Reverse();
            //list.Clear();
          //  st.AddRange(list);
            //st.RemoveRange(2, 1);
            //foreach (var item in st)
            //{
            //    Console.WriteLine(item);

            //}
            Console.ReadLine();
        }

    }
}
///ArrayList is use store Collection Deifferent Datatype Element were we can add
///remove ,reverse ,insert  any element s from the array
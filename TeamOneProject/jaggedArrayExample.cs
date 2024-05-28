using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamOneProject
{
    internal class jaggedArrayExample
    {
        public static void Main()
        {
            string[][] arr = new string[2][];

            arr[0]=new string[3] {"C","C++", "Java" };
            arr[1]=new string[2] {"Java","Dotnet"};

            for(int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j]+" ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();

        }
    }
}

//radha {"java","Dotnet"}
//Anji {"c",C++,"java"}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamOneProject
{
    internal class TaskWithAsyncAwaitExample
    {
        public static void Main()
        {
            Console.WriteLine("Main Method Started...");
            MySecondMethod();
            Console.WriteLine("Main Method End...");
            Console.ReadLine();


        }

        public async static void MySecondMethod()
        {
            Console.WriteLine("MySecondMethod Method Started...");
            await Wait();
            Console.WriteLine("MySecondMethod Method End...");
        }

        public static async Task Wait()
        {
            await Task.Delay(TimeSpan.FromSeconds(10));
            Console.WriteLine("10 Sec waitedd...");

        }

    }
}

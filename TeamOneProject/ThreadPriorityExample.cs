using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TeamOneProject
{
    internal class ThreadPriorityExample
    {
        public void Thread1(object a)
        {
            Thread thread = Thread.CurrentThread;
            Console.WriteLine(thread.Name + " is running "+ a);
        }
        public static void Main()
        {
            ThreadPriorityExample tex=new ThreadPriorityExample();
            Thread t1 = new Thread((tex.Thread1));
            Thread t2 = new Thread(tex.Thread1);
            Thread t3 = new Thread(tex.Thread1);

            t1.Name = "Dhoni";
            t2.Name = "Virat kohli";
            t3.Name = "Rohit Sharma";
            t1.Priority = ThreadPriority.BelowNormal;
            t2.Priority = ThreadPriority.Highest;
            t3.Priority = ThreadPriority.Lowest;
            t1.Start(12);
            t2.Start(12);
            t3.Start(12);
            Console.ReadLine();
        }
    }
}

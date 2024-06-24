using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamOneProject
{
    internal class TaskExample
    {
        public static void Main()
        {
            TaskExample obj = new TaskExample();
            Console.WriteLine(obj.GetMarks().Result);
            Console.ReadLine();
        }

        public async Task<int>GetMarks()
        {
            int TotalMarks = 200;
            return TotalMarks;
        }
    }
}

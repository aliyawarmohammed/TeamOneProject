using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace TeamOneProject
{
    internal class FileExample
    {
        public static void Main()
        {
            string path = "D:\\";
            File.Create(path).Close();
        }
    }
}

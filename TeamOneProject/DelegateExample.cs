using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamOneProject
{
    public delegate void ShowDelegate();//1 step
    public delegate void alphadelgate(string msg);//1 step
    internal class DelegateExample
    {
        public void Show()
        {
            Console.WriteLine("My  favorite show is bigboss");
        }
        public void MessageFromUSA(string msg)
        {
            Console.WriteLine("Message from USA is "+ msg);
        }

        public void MessageFromAustralia(string msg)
        {
            Console.WriteLine("Message from Australia is " + msg);
        }

        public  static void Main() {

            DelegateExample example = new DelegateExample();

            alphadelgate showDelegate = new alphadelgate(example.MessageFromUSA);//2 step

            showDelegate("we agree with your policy");

            showDelegate += example.MessageFromAustralia;
            showDelegate -= example.MessageFromAustralia;

            showDelegate("we dont agree with your policy");

            Console.ReadLine();
        }

    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamOneProject
{
    internal class HashTableExample
    {
        public static void Main()
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add(1, "Jeans");
            hashtable.Add(2, 8.9);

            Console.WriteLine(hashtable[1]);
            Console.WriteLine("-------");
            //hashtable.Remove(1);
            //Console.WriteLine(hashtable.ContainsValue("Jeans"));
            hashtable[1] = "Shirt";
            foreach (DictionaryEntry d in hashtable)
            {
                Console.WriteLine(d.Key+":"+d.Value);
            }

            Console.ReadLine();

        }
    }
}

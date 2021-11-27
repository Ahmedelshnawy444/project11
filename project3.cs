using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Console1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> cuntriesList = new LinkedList<string>();

            LinkedListNode<string> countriesNode = countriesList.AddFirst("spain");
            countriesList.AddFirst("egypt");
            countriesList.AddFirst("brazil");
            countriesList.AddBefore(countriesNode, "sudan");
            countriesList.AddLast("south africa");

            Console.WriteLine(" Before Reversig:  ");

            foreach (var item in countriesList)
            {
                Console.Write(item + ",");
            }

            Console.WriteLine();
            Console.WriteLine(" List After Reversing: ");

            foreach (var item in countriesList.Reverse())
            {
                Console.Write(item + ",");
            }

            Console.WriteLine();

            Console.ReadKey();
        }
    }
}

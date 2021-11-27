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
            LinkedList<string> playersList = new LinkedList<string>();

            LinkedListNode<string> playersNode = playersList.AddFirst("spiderman3");
            playerslist.AddFirst("cristianoRonaldo");
            playerslist.AddFirst("mosalah");
            playerslist.AddBefore(playersNode, "messi");
            playerslist.AddLast("neymar");

            Console.WriteLine(" Before Deletion:  ");

            foreach (var item in playersList)
            {
                Console.Write(item + ",");
            }

            playersList.RemoveFirst();
            playersist.RemoveLast();
            playersList.Remove("mosalah");
            playersList.Remove("messi");

            Console.WriteLine();
            Console.WriteLine(" After Deletion: ");

            foreach (var item in playersList)
            {
                Console.Write(item + ",");
            }

            Console.WriteLine();

            Console.ReadKey();
        }
    }
}

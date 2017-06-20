using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkList
{
    class Program
    {
        static void Main(string[] args)
        {
            SinglyLinkedList<string> linklist = new SinglyLinkedList<string>();
            while (true)
            {
                Console.WriteLine("_____________________________");
                Console.WriteLine("Operation: ");
                string operation = Console.ReadLine();
                Console.WriteLine("Arguments: ");
                string arguments = Console.ReadLine();

                if (operation.ToLower() == "addtofront")
                {
                    linklist.AddToFront(arguments);
                }
                else if (operation.ToLower() == "addtoend")
                {
                    linklist.AddtoEnd(arguments);
                }
                else if (operation.ToLower() == "removefromfront")
                {
                    linklist.removeFromFront();
                }
                else if (operation.ToLower() == "removefromend")
                {
                    linklist.removeFromEnd();
                }
                else if (operation.ToLower() == "removeat")
                {
                    linklist.removeAt(int.Parse(arguments));
                }
                else if (operation.ToLower() == "print")
                {
                    linklist.ToString();
                }
            }
        }
    }
}

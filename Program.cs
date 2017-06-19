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
            while(true)
            {
                DavidLinkedListt<int> linklist = new DavidLinkedListt<int>;
                Console.WriteLine("_____________________________");
                Console.WriteLine("Operation: ");
                string operation = Console.ReadLine();
                Console.WriteLine("Arguements: ");
                string arguements = Console.ReadLine();

                if(operation.ToLower() == "addtofront")
                {
                }
                else if (operation.ToLower() == "addtoend")
                {

                }
                else if (operation.ToLower() == "removefromfront")
                {

                }
                else if (operation.ToLower() == "removefromend")
                {

                }
            }
        }
    }
}

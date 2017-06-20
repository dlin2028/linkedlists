using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkList
{
    class DoublyLinkedNode <T>
    {
        public T Item;
        public DoublyLinkedNode<T> NextNode;
        public DoublyLinkedNode<T> PreviousNode;

        public DoublyLinkedNode(T item) 
            : this()
        {
            Item = item;
        }
        public DoublyLinkedNode()
        {
            NextNode = null;
            PreviousNode = null;
        }
    }
}

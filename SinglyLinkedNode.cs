using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkList
{
    class SinglyLinkedNode<T>
    {
        public T Item;
        public SinglyLinkedNode<T> NextNode;
        public SinglyLinkedNode(T item, SinglyLinkedNode<T> next = null)
        {
            Item = item;
            NextNode = next;
        }
        public SinglyLinkedNode<T> AddAfter(T item)
        {
            SinglyLinkedNode<T> newNode = new SinglyLinkedNode<T>(item);
            NextNode.Item = item;
            return newNode;
        }
        public SinglyLinkedNode<T> RemoveAfter()
        {
            SinglyLinkedNode<T> nextNode = NextNode.NextNode;
            NextNode = NextNode.NextNode;
            return nextNode;
        }
    }
}

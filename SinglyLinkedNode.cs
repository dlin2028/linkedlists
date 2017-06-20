using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkList
{
    class SingleLinkedNode<T>
    {
        public T Item;
        public SingleLinkedNode<T> NextNode;
        public SingleLinkedNode(T item, SingleLinkedNode<T> next = null)
        {
            Item = item;
            NextNode = next;
        }
        public SingleLinkedNode<T> AddAfter(T item)
        {
            SingleLinkedNode<T> newNode = new SingleLinkedNode<T>(item);
            NextNode.Item = item;
            return newNode;
        }
        public SingleLinkedNode<T> RemoveAfter()
        {
            SingleLinkedNode<T> nextNode = NextNode.NextNode;
            NextNode = NextNode.NextNode;
            return nextNode;
        }
    }
}

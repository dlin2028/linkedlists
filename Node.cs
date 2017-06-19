using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkList
{
    class Node<T>
    {
        public T Item;
        public Node<T> NextNode;
        public Node(T item, Node<T> next = null)
        {
            Item = item;
            NextNode = next;
        }
        public Node<T> AddAfter(T item)
        {
            Node<T> newNode = new Node<T>(item);
            NextNode.Item = item;
            return newNode;
        }
        public Node<T> RemoveAfter()
        {
            Node<T> nextNode = NextNode.NextNode;
            NextNode = NextNode.NextNode;
            return nextNode;
        }
    }
}

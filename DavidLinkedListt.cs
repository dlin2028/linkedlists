using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkList
{
    class DavidLinkedListt<T>
    {
        public Node<T> head;
        public int count = 0;
        public DavidLinkedListt()
        {
            head = null;
        }
        
        public void AddToFront(T item)
        {
            Node<T> newNode = new Node<T>(head.Item, head.NextNode);
            head.Item = item;
            count++;
        }
        public void AddtoEnd(T item)
        {
            Node<T> lastNode = getNode(count - 1);
            lastNode.NextNode.Item = item;
            count++;
        }
        public bool removeFromFront()
        {
            if (head == null)
            {
                return false;
            }
            head = head.NextNode;
            count--;
            return true;
        }
        public bool removeFromEnd()
        {
            Node<T> lastNode = getNode(count - 1);
            if (lastNode == null)
            {
                return false;
            }
            Node<T> secondLastNode = getNode(count - 1);
            secondLastNode.NextNode = null;
            count--;
            return true;
        }

        public void Print()
        {
            Node<T> nodeOfi = head;
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(nodeOfi.Item);
                nodeOfi = nodeOfi.NextNode;
            }
        }

        private Node<T> getNode(int index)
        {
            Node<T> nodeOfi = head;
            for (int i = 0; i < index; i++)
            {
                nodeOfi = nodeOfi.NextNode;
            }
            return nodeOfi;
        }
    }
}

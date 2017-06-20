using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkList
{
    class SinglyLinkedList<T>
    {
        public SingleLinkedNode<T> head;
        public int count = 0;
        public SinglyLinkedList()
        {
            head = null;
        }
        
        public void AddToFront(T item)
        {
            SingleLinkedNode<T> newNode = new SingleLinkedNode<T>(item, head);
            head = newNode;
            count++;
        }
        public void AddtoEnd(T item)
        {
            if(head != null)
            {
                SingleLinkedNode<T> lastNode = getNode(count - 1);
                SingleLinkedNode<T> newNode = new SingleLinkedNode<T>(item, null);
                lastNode.NextNode = newNode;
                count++;
            }
            else
            {
                head = new SingleLinkedNode<T>(item);
                count++;
            }
        }
        public bool removeFromFront()
        {
            if (count <= 0)
            {
                return false;
            }
            else
            {
                if (head == null)
                {
                    return false;
                }
                head = head.NextNode;
                count--;
                return true;
            }
        }
        public bool removeFromEnd()
        {
            if (count <= 0)
            {
                return false;
            }
            else
            {
                SingleLinkedNode<T> lastNode = getNode(count - 1);
                if (lastNode == null)
                {
                    return false;
                }
                SingleLinkedNode<T> secondLastNode = getNode(count - 1);
                secondLastNode.NextNode = null;
                count--;
                return true;
            }
        }

        public new void ToString()
        {
            SingleLinkedNode<T> nodeOfi = head;
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(nodeOfi.Item);
                nodeOfi = nodeOfi.NextNode;
            }
        }

        public bool removeAt(int position)
        {
            if (count <= 0 || position > count)
            {
                return false;
            }
            else
            {
                if (position > 0)
                {
                    getNode(position - 1).RemoveAfter();
                }
                else
                {
                    head = head.NextNode;
                }
                count--;
                return true;
            }
        }

        public bool IsEmpty()
        {
            if(count > 0)
            {
                return true;
            }
            return false;
        }

        private SingleLinkedNode<T> getNode(int index)
        {
            SingleLinkedNode <T> nodeOfi = head;
            for (int i = 0; i < index; i++)
            {
                nodeOfi = nodeOfi.NextNode;
            }
            return nodeOfi;
        }
    }
}

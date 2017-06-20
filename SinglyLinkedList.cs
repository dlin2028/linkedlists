using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkList
{
    class SinglyLinkedList<T>
    {
        public SinglyLinkedNode<T> head;
        public int count = 0;
        public SinglyLinkedList()
        {
            head = null;
        }
        
        public void AddToFront(T item)
        {
            SinglyLinkedNode<T> newNode = new SinglyLinkedNode<T>(item, head);
            head = newNode;
            count++;
        }
        public void AddtoEnd(T item)
        {
            if(head != null)
            {
                SinglyLinkedNode<T> lastNode = getNode(count - 1);
                SinglyLinkedNode<T> newNode = new SinglyLinkedNode<T>(item, null);
                lastNode.NextNode = newNode;
                count++;
            }
            else
            {
                head = new SinglyLinkedNode<T>(item);
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
                SinglyLinkedNode<T> lastNode = getNode(count - 1);
                if (lastNode == null)
                {
                    return false;
                }
                SinglyLinkedNode<T> secondLastNode = getNode(count - 1);
                secondLastNode.NextNode = null;
                count--;
                return true;
            }
        }

        public new void ToString()
        {
            SinglyLinkedNode<T> nodeOfi = head;
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

        private SinglyLinkedNode<T> getNode(int index)
        {
            SinglyLinkedNode <T> nodeOfi = head;
            for (int i = 0; i < index; i++)
            {
                nodeOfi = nodeOfi.NextNode;
            }
            return nodeOfi;
        }
    }
}

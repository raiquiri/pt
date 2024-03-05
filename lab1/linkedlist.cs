using System;

namespace ConsoleApp
{
    class LinkedList
    {
        class Node
        {
            public int Data { set; get; }
            public Node Next { set; get; }

            public Node(int data, Node next)
            {
                Data = data;
                Next = next;
            }

        }

        private Node head;
        private int count;

        public LinkedList()
        {
            head = null;
            count = 0;
        }

        private Node find(int position)
        {
            if (position < 0) { return null; }

            int i = 0;
            Node currenNode = head;
            while (currenNode != null && i < position)
            {
                currenNode = currenNode.Next;
                i++;
            }

            if (i == position) { return currenNode; }
            else { return null; }
        }

        public void add(int item)
        {
            Node newNode = new Node(item, null);

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node tail = find(count - 1);
                tail.Next = newNode;
            }
            count++;
        }

        public void insert(int item, int position)
        {
            if (position < 0 || position > count)
            {
                return;
            }
            if (position == 0)
            {
                Node newNode = new Node(item, null);
                newNode.Next = head;
                head = newNode;
            }
            else
            {
                Node currentNode = find(position - 1);
                Node newNode = new Node(item, null);
                newNode.Next = currentNode.Next;
                currentNode.Next = newNode;
            }
            count++;
        }

        public void delete(int position)
        {
            if (position < 0 || position >= count)
            {
                return;
            }
            if (position == 0 && head != null)
            {
                head = head.Next;
                count--;
                return;
            }
            Node prevNode = find(position - 1);
            Node currentNode = find(position);

            if (currentNode != null)
            {
                prevNode.Next = currentNode.Next;
                count--;
            }
        }

        public void clear()
        {
            head = null;
            count = 0;
        }

        public void print()
        {
            Node currentNode = head;
            while (currentNode != null)
            {
                Console.Write(currentNode.Data + " ");
                currentNode = currentNode.Next;
            }
        }

        public int Count() { return count; }
        public int this[int index]
        {
            get
            {
                if (index < count || index >= 0)
                {
                    Node currentNode = find(index);
                    return currentNode.Data;
                }
                return 0;
            }
            set
            {
                if (index < count || index >= 0)
                {
                    Node currentNode = find(index);
                    currentNode.Data = value;
                }
            }
        }
    }
}
using System;

namespace ConsoleApp
{
    class LinkedList : BaseList
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
        protected override BaseList emptyClone()
        {
            ArrayList linkedList = new ArrayList();
            return linkedList;
        }

        public LinkedList()
        {
            lenght = 0;
            head = null;
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

        public override void add(int item)
        {
            Node newNode = new Node(item, null);

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node tail = find(lenght - 1);
                tail.Next = newNode;
            }
            lenght++;
        }

        public override void insert(int item, int position)
        {
            if (position < 0 || position > lenght)
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
            lenght++;
        }

        public override void delete(int position)
        {
            if (position < 0 || position >= lenght)
            {
                return;
            }
            if (position == 0 && head != null)
            {
                head = head.Next;
                lenght--;
                return;
            }
            Node prevNode = find(position - 1);
            Node currentNode = find(position);

            if (currentNode != null)
            {
                prevNode.Next = currentNode.Next;
                lenght--;
            }
        }

        public override void clear()
        {
            head = null;
            lenght = 0;
        }

        public override void print()
        {
            Node currentNode = head;
            while (currentNode != null)
            {
                Console.Write(currentNode.Data + " ");
                currentNode = currentNode.Next;
            }
        }

        public void deleteRepeat()
        {
            if (head == null)
            {
                return;
            }

            
            for (int i = 0; i < lenght; i++)
            {
                bool check = true;
                
                for (int j = i + 1; j < lenght; j++)
                {
                    if (this[i] == this[j])
                    {
                        delete(j);
                        check = false;
                        j--;
                    }
                }
                if (!check)
                {
                    delete(i);
                    i--;
                }
            }
        }

        public override int this[int index]
        {
            get
            {
                if (index < lenght || index >= 0)
                {
                    Node currentNode = find(index);
                    return currentNode.Data;   
                }
                return 0;
            }
            set
            {
                if (index < lenght || index >= 0)
                {
                    Node currentNode = find(index);
                    currentNode.Data = value;
                }
            }
        }
    }
}

using System;

namespace ConsoleApp
{
    class ArrayList
    {
        private int[] buffer;
        private int lenght;

        public ArrayList()
        {
            lenght = 0;
            buffer = new int[4];
        }

        public void add(int item)
        {
            if (buffer.Length == lenght)
            {
                resize();
            }
            buffer[lenght] = item;
            lenght++;
        }

        public void insert(int item, int position)
        {
            if (position > lenght || position < 0)
            {
                return;
            }
            if (position == lenght)
            {
                add(item);
                return;
            }

            if (buffer.Length == lenght)
            {
                resize();
            }

            for (int i = lenght; i > position; i--)
            {
                buffer[i] = buffer[i - 1];
            }
            buffer[position] = item;
            lenght++;
        }

        public void delete(int position)
        {
            if (position >= lenght || position < 0)
            {
                return;
            }

            for (int i = position; i < lenght - 1; i++)
            {
                buffer[i] = buffer[i + 1];
            }
            lenght--;
        }

        public void clear()
        {
            lenght = 0;
        }

        private void resize()
        {
            int[] newBuffer = new int[buffer.Length * 2];
            for (int i = 0; i < buffer.Length; i++)
            {
                newBuffer[i] = buffer[i];
            }
            buffer = newBuffer;
        }

        public void print()
        {
            for (int i = 0; i < lenght; i++)
            {
                Console.Write(buffer[i] + " ");
            }
            Console.WriteLine();
        }
        public int Count() { return lenght; }
        public int this[int index]
        {
            get
            {
                if (index < lenght || index >= 0)
                {
                    return buffer[index];
                }
                return 0;
            }
            set
            {
                if (index < lenght || index >= 0)
                {
                    buffer[index] = value;
                }
            }
        }

    }
}
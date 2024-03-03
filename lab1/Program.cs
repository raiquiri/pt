using System;


namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList array = new ArrayList();

            for (int i = 0; i < 20; i++)
            {
                array.add(i);
            }
            array.print();
            array.insert(15, 3);
            array.insert(20, 21);
            array.print();
            array[3] = 15;
        }
    }
}
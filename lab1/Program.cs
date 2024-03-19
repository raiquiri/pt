using System;

namespace ConsoleApp
{ 
    class Program
    {
        public static void Main(string[] args)
        {
            BaseList arrayList = new ArrayList();
            LinkedList linkedList = new LinkedList();
            Random random = new Random();

            BaseList testList = new ArrayList();

            arrayList.add(8);
            arrayList.add(5);
            arrayList.add(10);
            arrayList.add(13);
            arrayList.add(1);
            arrayList.add(2);
            arrayList.add(3);
            arrayList.add(4);
            arrayList.add(11231230);
            arrayList.add(12333);

            arrayList.print();
            arrayList.sort();
            arrayList.print();


            testList.assign(arrayList);
            testList.print();

            Console.WriteLine(arrayList.equals(testList));









            /*for (int i = 0; i <= 5000; i++)
            {
                int factor = random.Next(1, 5);
                int number = random.Next(0, 1000);
                int index = random.Next(0, 100);

                switch (factor)
                {
                    case 1:
                        arrayList.add(number);
                        linkedList.add(number);
                        break;
                    case 2:
                        arrayList.delete(number);
                        linkedList.delete(number);
                        break;
                    case 3:
                        arrayList.insert(number, index);
                        linkedList.insert(number, index);
                        break;
                    /*case 4:
                        arrayList.clear();
                        linkedList.clear();
                        break;
                }   
            }

            for (int i = 0; i < arrayList.Count(); i++)
            {
                if (arrayList[i] != linkedList[i])
                {
                    Console.WriteLine("error match " + linkedList.Count() + " " + arrayList.Count() + " " + i);
                    break;
                }
            }


            Console.WriteLine("accept " + linkedList[0] + " " + arrayList[0]);*/
        }
    }
}

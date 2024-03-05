using System;

namespace ConsoleApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            LinkedList linkedList = new LinkedList();
            Random random = new Random();

            for (int i = 0; i <= 5000; i++)
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
                            break;*/
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


            Console.WriteLine("accept " + linkedList[0] + " " + arrayList[0]);
        }
    }
}

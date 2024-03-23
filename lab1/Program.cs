using System;

namespace ConsoleApp
{ 
    class Program
    {
        public static void Main(string[] args)
        {
            BaseList arrayList = new ArrayList();
            BaseList linkedList = new LinkedList();
            Random random = new Random();


            for (int i = 0; i <= 1000; i++)
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
            
            arrayList.sort();
            BaseList cloneList_1 = arrayList.clone();
            

            BaseList cloneList_2 = new LinkedList();
            cloneList_2.assign(linkedList);
            cloneList_2.sort();
            

            if (cloneList_1.equals(cloneList_2))
            {
                Console.WriteLine("Accept");
            }
        }
    }
}

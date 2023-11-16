using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            //1D array
            //int[] array = new int[3];
            //array[0] = 1;
            //array[1] = 2;
            //array[2] = 3;


            //foreach (int i in array)
            //{
            //    Console.WriteLine(i);
            //}



            //Multidimensional array

            //int[,] multiArray = new int[3, 1];
            //multiArray[0, 0] = 20;
            //multiArray[1, 0] = 25;
            //multiArray[2, 0] = 30;

            //for (int i = 0; i < 3; i++)
            //{


            //        Console.WriteLine(multiArray[i, 0]);


            //}

            //Jagged Array
            int[][] jaggedArray = {
                                  new int[] {1, 2, 3, 4},
                                  new int[] {11, 34, 67},
                                  new int[] {89, 23},
                                  new int[] {0, 45, 78, 53, 99}
                                  };

            for(int i=0;i<jaggedArray.Length;i++)
            {
                for(int j=0;j<jaggedArray[i].Length;j++)
                {
                    Console.WriteLine(jaggedArray[i][j]);
                }
                Console.WriteLine();
            }


            //Arraylist

            ArrayList myArraylist = new ArrayList();
            myArraylist.Add(10);
            myArraylist.Add("Ajay");
            myArraylist.Add(21.21);
            myArraylist.Add(DateTime.Now);
            foreach (object obj in myArraylist)
            {
                Console.WriteLine(obj.ToString());
            }

            //Hash Table

            Hashtable nonGenericHashTable = new Hashtable();

            nonGenericHashTable.Add(1, "Soda");
            nonGenericHashTable.Add(2, 324);
            nonGenericHashTable.Add(3, 21.32);

            foreach (DictionaryEntry h in nonGenericHashTable)
            {
                Console.WriteLine(h.Key + ": " + h.Value);
            }

            //Queue

            Queue nonGenericQueue = new Queue();
            nonGenericQueue.Enqueue(12);
            nonGenericQueue.Enqueue("Ajay");
            nonGenericQueue.Enqueue(21.21);

            foreach (object obj in nonGenericQueue)
            {
                Console.WriteLine(obj);
            }

            nonGenericQueue.Dequeue();
            Console.WriteLine("After dequeing");


            foreach (object obj in nonGenericQueue)
            {
                Console.WriteLine(obj);
            }

            //Stack
            Stack nonGenericStack = new Stack();
            nonGenericStack.Push(1);
            nonGenericStack.Push(2);
            nonGenericStack.Push("ajay");

            foreach (var i in nonGenericStack)
            {
                Console.WriteLine(i);

            }

            //Generic Collections

            //List

            List<int> genericList = new List<int>();
            genericList.Add(1);
            genericList.Add(2);
            genericList.Add(3);
            genericList.Add(4);
            genericList.Add(5);

            foreach (object obj in genericList)
            {
                Console.WriteLine(obj);

            }

            genericList.Remove(3);
            Console.WriteLine("removing element");
            foreach (object obj in genericList)
            {
                Console.WriteLine(obj);



            }
            Console.WriteLine("count of elements in list : " + genericList.Count());



            //Generic Queue
            Queue<int> GenericQueue = new Queue<int>();
            GenericQueue.Enqueue(12);
            GenericQueue.Enqueue(33);
            GenericQueue.Enqueue(21);

            foreach (object obj in GenericQueue)
            {
                Console.WriteLine(obj);
            }


            GenericQueue.Dequeue();
            Console.WriteLine("After dequeing");


            foreach (object obj in GenericQueue)
            {
                Console.WriteLine(obj);
            }

            // Dictionary

            Dictionary<int, string> genericDictionary = new Dictionary<int, string>();

            genericDictionary.Add(1, "Ajay");
            genericDictionary.Add(2, "bohra");

            foreach(var i in genericDictionary)
            {
                Console.WriteLine(i.Key + " " +  i.Value);
            }





            Console.ReadKey();

        }
    }
}

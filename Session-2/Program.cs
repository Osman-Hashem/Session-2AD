using System.Collections;
using System.Collections.Generic;

namespace Session_2
{
    internal class Program
    {

        public static void PrintArrayList(ArrayList arraylist)
        {
            Console.WriteLine();
            foreach (int item in arraylist)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }




        public static int SumArrayList(ArrayList list)
        {
            int Sum = 0;

            if (list is not null)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    Sum += (int)list[i]; // UnBoxing [ReferenceType] To [ValuType] -- UnSafe
                }
            }
            return Sum;
        }


        public static void PrintList<T>(List<T> value)
        {
            Console.WriteLine();
            foreach (T item in value)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }



        public static void PrintLinkedList(LinkedList<int> linkedlist)
        {
            Console.Write("null");
            foreach (int item in linkedlist)
            {
                Console.Write($"<- {item} ->");
            }
            Console.WriteLine("null");
            Console.WriteLine();
        }



        public static void PrintStack (Stack<int> stack)
        {
            Console.WriteLine();
            foreach(int item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }


        public static void PrintQueue(Queue<int> queue)
        {
            Console.WriteLine();
            foreach (int item in queue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }


        static void Main()
        {

            #region What Is Collection : 
            // Collection : Bult-in DS In C#
            // Array : Container

            // Collection in C# 
            // Lists
            // Hashtables


            // Generic - Non-Generic 
            // Lists :
            // Non-Generic Lists : ArrayList - Stack - Queue 
            // Generic Lists     : List - LinkedList - Stack - Queue 

            // Hashtables : 
            // Non-Generic Hashtables : Hashtables
            // Generic Hashtables     : Dictionary - SortedDectionary  
            #endregion

            #region Non-Generic Lists : ArrayList
            // Lists 
            // Non-Generic Lists : ArrayList 

            // ArrayList Like Array 
            // Array Based 
            // Index 

            // Array     : Indexed Collection : Fixed Sizd 
            // ArrayList : Indexed Collection : Dynamic Size 

            // Index : 0 1 2 3 4 5 
            // Items : 4 6 5 7 8 1 
            // Size  : 6 

            // Arr[1] --> 5 

            //int[] Numbers = { 9, 5, 4, 2, 6, 7, 1 };

            //Console.WriteLine(Numbers[1]);
            //Numbers[1] = 12;
            //Console.WriteLine(Numbers[1]);

            //ArrayList list = new ArrayList (new int[] {1 , 2 , 3  , 4 , 5} );
            //ArrayList list = new ArrayList (6 );

            //Console.WriteLine($"Count : {list.Count} , apacity : {list.Capacity}");  

            //list.Add( 15 );

            //Console.WriteLine($"Count : {list.Count} , apacity : {list.Capacity}");

            //---------
            //ArrayList list = new ArrayList();
            ////Console.WriteLine($"Count : {list.Count} , apacity : {list.Capacity}");


            //list.Add(15);
            //list.Add(13);
            //list.Add(14);
            //list.Add(17);
            //list.Add(17);

            //Console.WriteLine($"Count : {list.Count} , apacity : {list.Capacity}");

            //list.Add(17);
            //list.Add(17);
            //list.Add(17);
            //list.Add(17);
            //list.Add(17);

            //Console.WriteLine($"Count : {list.Count} , apacity : {list.Capacity}");

            //---------------

            //Console.WriteLine(list.IsFixedSize);
            //Console.WriteLine(list.IsReadOnly);
            //Console.WriteLine(list[1]);

            //list[1] = 12;
            //Console.WriteLine(list[1]);

            //list.AddRange(new[]  { 1, 2, 3, 4 });

            //PrintArrayList(list);

            //int Index = list.BinarySearch(14);
            //int Index = list.BinarySearch(14 ,);
            //Console.WriteLine(Index);
            //-----------------------

            //Employee E01 = new Employee() { Id = 1, Name = "Ahmed", Salary = 12000, Age = 29 };
            //Employee E02 = new Employee() { Id = 2, Name = "Ali", Salary = 13000, Age = 30 };
            //Employee E03 = new Employee() { Id = 3, Name = "Omar", Salary = 15000, Age = 35 };
            //Employee E04 = new Employee() { Id = 4, Name = "Mariam", Salary = 14000, Age = 32 };

            //ArrayList list = new ArrayList();
            //list.AddRange(new Employee[] { E01, E02, E03, E04 });

            ////int Index = list.BinarySearch(new Employee() { Name = "Ali" }, new EmployeeCompererName());
            ////Console.WriteLine($"index : {Index}");

            //int index = list.BinarySearch(0, 2, new Employee() { Name = "Ali" }, new EmployeeCompererName());
            //Console.WriteLine(index);

            //Console.WriteLine("---------------------------");

            //foreach (Employee item in list)
            //{
            //    Console.WriteLine(item);
            //}


            //-------------------------

            //ArrayList list = new ArrayList();
            //list.Add(1);
            //list.Add(8);
            //list.Add(7);
            //list.Add(2);
            //list.Add(6);
            //list.Add(3);
            //list.Add(5);
            //list.Add(10);
            //list.Add(8);
            //list.Add(9);

            //Console.WriteLine($"Count : {list.Count} , apacity : {list.Capacity}");
            //list.Clear();.
            //Console.WriteLine($"Count : {list.Count} , apacity : {list.Capacity}");

            //bool Flage = list.Contains(55);
            //Console.WriteLine(Flage);

            //---------

            //int[] Arr = new int[10];

            //list.CopyTo(Arr , 3 );

            //foreach (int item in Arr)
            //{
            //    Console.WriteLine(item);
            //}

            //------------------

            //ArrayList arraylist = list.GetRange(0, 2);

            //foreach (int item in arraylist)
            //{
            //    Console.WriteLine(item);
            //}

            //int i = list.IndexOf(8);
            //Console.WriteLine(i);


            //list.Insert(0, 100);
            //PrintArrayList(list);

            //list.InsertRange(0 , new int[]  {10,20,30,40,50});
            //PrintArrayList(list);

            //int i = list.LastIndexOf(10);
            //Console.WriteLine(i);

            //list.Remove(5);
            //PrintArrayList(list);

            //list.SetRange(0 , new int []{88 , 77 , 99 });

            //list.Sort();

            //Console.WriteLine($"Count : {list.Count} , apacity : {list.Capacity}");

            //list.TrimToSize();
            //Console.WriteLine($"Count : {list.Count} , apacity : {list.Capacity}");

            //PrintArrayList(list); 
            #endregion

            #region Problems With Non-Generic Lists (ArrayList)
            //ArrayList list = new ArrayList();  

            //list.Add(1);
            //list.Add(2);
            //list.Add(3);
            //list.Add(4);
            //list.Add(5);

            ////list.Add("Hello"); 

            //int Sum = SumArrayList(list);
            //Console.WriteLine(Sum); 
            #endregion

            #region Generic Lists : List
            // Generic Lists : Lsit 
            // List : Version Generic Of ArrayList
            // // List Like ArrayList like Array : Generic - Dynamic Size 

            //List<int> list = new List<int>(new int[ ] { 1 , 2 , 3 , 4});
            //List<int> list = new List<int>();

            //list.Add(1);
            //list.Add(2);
            //list.Add(3);
            //list.Add(4);
            //list.Add("Hello"); // invalid compiler

            //list.AddRange(new List<int>() { 10, 20, 30, 40, 50 });

            //list.AsReadOnly();

            //int i = list.BinarySearch(2);
            //Console.WriteLine(i);




            //PrintList(list); 
            #endregion

            #region Generic Lists : LinkedList 
            // Generic Lists : LinkedList 

            //LinkedList<int> linkedlist = new LinkedList<int>();

            ////linkedlist.AddFirst(1);
            ////linkedlist.AddFirst(2);

            //linkedlist.AddLast(1);
            //linkedlist.AddLast(2);
            //linkedlist.AddLast(3);

            //LinkedListNode<int> node = new LinkedListNode<int>(4);
            //linkedlist.AddLast(node);

            //LinkedListNode<int> result =  linkedlist.Find(1);

            //linkedlist.AddAfter(result , 5);
            //linkedlist.AddBefore(result , 6);


            ////Console.WriteLine(linkedlist.First.Next.Value);

            //PrintLinkedList(linkedlist); 
            #endregion

            #region Generic Lists : Stack
            //Generic Lists : Stack

            //Stack<int> stack = new Stack<int>();

            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);
            //stack.Push(4);
            //stack.Push(5);

            ////int top = stack.Pop();
            ////int top = stack.Peek();
            ////Console.WriteLine(top);


            //bool Flag = stack.TryPeek(out int top);

            //Console.WriteLine(top);


            //PrintStack(stack);

            // undo : Ctrl Z  
            #endregion

            #region Queue
            // Generic Lists : Queue 

            //Queue<int> list = new Queue<int>();

            //list.Enqueue(1);
            //list.Enqueue(2);
            //list.Enqueue(3);
            //list.Enqueue(4);
            //list.Enqueue(5);

            //list.Dequeue();


            //PrintQueue(list); 
            #endregion






        }
    }
}

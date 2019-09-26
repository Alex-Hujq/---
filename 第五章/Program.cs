using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
namespace 第五章
{
   
    class Program
    {
        
        static void Main(string[] args)
        {
            /*var list = new ArrayList();
            list.Add(44);
            int i1 = (int)list[0];
            foreach (int i2 in list)
            {
                Console.WriteLine(i2);
            }

            var list = new List<int>();
            list.Add(44);
            int i1 = list[0];
            foreach (int i2 in list)
            {
                Console.WriteLine(i2);
            }*/

            // var list = new ArrayList();
            /* var list = new List<int>();
             list.Add(44);
             list.Add("mystring");
             list.Add(new myclass());
             foreach (int i in list)
             {
                 Console.WriteLine(i);
             }*/

            /*var list = new List<int>();
            list.Add(44);
            var stringlist = new List<string>();
            stringlist.Add("mystring");
            var myclasslist = new List<myclass>();
            myclasslist.Add(new myclass());*/

            var list1 = new LinkedList();
            list1.AddLast(2);
            list1.AddLast(4);
            list1.AddLast("6");
            foreach (int i in list1)
            {
                Console.WriteLine(i);
            }
        }

        class myclass
        {

        }

        public class LinkedListNode
        {
            public LinkedListNode(object value)
            {
                this.Value = value;
            }
            public object Value { get; private set; }
            public LinkedListNode next { get; internal set; }
            public LinkedListNode prev { get; internal set; }
        }

        public class LinkedList:IEnumerable
        {
            public LinkedListNode first { get; private set; }
            public LinkedListNode last { get; internal set; }
            public LinkedListNode AddLast(object node)
            {
                var newNode = new LinkedListNode(node);
                if(first==null)
                {
                    first = newNode;
                    last = first;
                }
                else
                {
                    LinkedListNode previous = last;
                    last.next = newNode;
                    last = newNode;
                    last.prev = previous;
                }
                return newNode;
            }
            public IEnumerator GetEnumerator()
            {
                LinkedListNode currect = first;
                while (currect !=null)
                {
                    yield return currect.Value;
                    currect = currect.next;
                }
            }
        }


    }
}

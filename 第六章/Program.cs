using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace 第六章
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            int[] MyArray = new int[4];
            int[] MyArray1 = new int[5] { 1, 2, 3, 4, 5};
            int[] MyArray2 = new int[] { 3, 6, 9, 12, 15, 18 };
            int[] MyArray3 = { 2, 4, 6, 8, 10 };
            int s1 = MyArray2[2];
            Console.WriteLine(s1);
            for (int i = 0; i < MyArray3.Length; i++)
            {
                Console.WriteLine(MyArray3[i]);
            }

            Person[] MyPerson = new Person[2];
            Person[] myperson1 =
             {
                new Person{FirstName="a",LastName="b"},
                new Person{FirstName="c",LastName="d"}
            };
            MyPerson[0] = new Person { FirstName = "jay", LastName = "chou" };
            MyPerson[1] = new Person { FirstName = "mike", LastName = "fil" };
            var s2 = MyPerson[1];
            Console.WriteLine(s2);
            foreach(var aa in MyArray1)
            {
                Console.WriteLine(aa);
            }
            int[,] twodim = new int[3, 3];
            twodim[0, 0] = 1;
            twodim[1, 1] = 3;

            Array intArray = Array.CreateInstance(typeof(int), 5);
            for(int i=0;i<5;i++)
            {
                intArray.SetValue(33, 1);
            }
            for(int i=1;i<5;i++)
            {
                Console.WriteLine(intArray.GetValue(i));
            }

            int[][] jagged = new int[3][];
            jagged[0] = new int[2] { 1, 2 };
            jagged[1] = new int[6] { 3, 4, 5, 6, 7, 8 };
            jagged[2] = new int[3] { 9, 10, 11 };

            for(int row=0;row<jagged.Length;row++)
            {
                for(int element=0;element<jagged[row].Length;element++)
                {
                    Console.WriteLine("row:{0},element:{1},value:{2}", row, element, jagged[row][element]);
                }
            }

            Array intArray1 = Array.CreateInstance(typeof(int), 5);
            for(int i=0;i<5;i++)
            {
                intArray.SetValue(33, i);
            }
            for(int i=0;i<5;i++)
            {
                Console.WriteLine(intArray1.GetValue(i));
            }

            int[] intarray2 = { 1, 2 };
            int[] intarray3 = (int[])intarray2.Clone();
            Person[] beatles = 
            {
                new Person { FirstName = "john", LastName = "leeon" },
                new Person { FirstName = "paul",LastName="mc" }
            };
            Person[] beatclone = (Person[])beatles.Clone();
            //排序
            string[] names =
            {
                "CA",
                "sha",
                "beyonce",
                "lady gaga"
            };
            Array.Sort(names);
            foreach(var name in names)
            {
                Console.WriteLine(name);
            }

            Person[] persons =
            {
                new Person{FirstName="damon",LastName="hill"},
                new Person{FirstName="niki",LastName="lauda"},
                new Person{FirstName="ayrton",LastName="senna"},
                new Person{FirstName="graham",LastName="hill"}
            };
            Array.Sort(persons);
            foreach(var p in persons)
            {
                Console.WriteLine(p);
            }

            Array.Sort(persons, new PersonComparer(PersonComparerType.FirstName));
            foreach(var p in persons)
            {
                Console.WriteLine(p);
            }
            //数组作为参数
            static Person[] GetPersons()
            {
                return new Person[]
            {
                new Person { FirstName = "damon", LastName = "hill" },
                new Person { FirstName = "niki", LastName = "lauda" },
                new Person { FirstName = "ayrton", LastName = "senna" },
                new Person { FirstName = "graham", LastName = "hill" }
            };
            }
            //ArraySagment<T>
             static int SumOfSegments(ArraySegment<int>[] segments)
            {
                int sum = 0;
                foreach(var segment in segments)
                {
                    for (int i=segment.Offset;i<segment.Offset+segment.Count;i++)
                    {
                        sum += segment.Array[i];
                    }
                }
                return sum;
            }
            int[] ar1 = { 1, 4, 5, 11, 13, 18 };
            int[] ar2 = { 3, 4, 5, 18, 21, 27, 33 };

            var segment = new ArraySegment<int>[2]
            {
                new ArraySegment<int>(ar1,0,3),
                new ArraySegment<int>(ar2,3,3)
            };
            var sum = SumOfSegments(segment);
            //枚举
            /* IEnumerator<Person> enumerator = persons.GetEnumerator();
             while (enumerator.MoveNext())
             {
                 Person p = enumerator.Current;
                 Console.WriteLine(p);
             }*/
            var result1 = Divide(5, 2);
            Console.WriteLine("result of division:{0},reminder:{1}", result1.Item1, result1.Item2);
        }

        static void MusicTitles()
        {
            var titles = new MusicTitles();
            foreach (var title in titles)
            {
                Console.WriteLine(title);
            }
            Console.WriteLine();

            Console.WriteLine("reverse");
            foreach (var title in titles.Reverse())
            {
                Console.WriteLine(title);
            }
            Console.WriteLine();

            Console.WriteLine("subset");
            foreach (var title in titles.Subset(2, 2))
            {
                Console.WriteLine(title);
            }

        }

        static void HelloWorld()
        {
            var helloCollection = new HelloCollection();
            foreach (string s in helloCollection)
            {
                Console.WriteLine(s);
            }
        }

        public class HelloCollection
        {
            public IEnumerator<string> GetEnumerator()
            {
                yield return "Hello";
                yield return "World";
            }
        }
        public static Tuple<int, int> Divide(int dividend, int divisor)
        {
            int result = dividend / divisor;
            int reminder = dividend % divisor;

            return Tuple.Create<int, int>(result, reminder);
        }
        static void AnyElementNumber()
        {
            var tuple = Tuple.Create<string, string, string, int, int, int, double, Tuple<int, int>>(
                "Stephanie", "Alina", "Nagel", 2009, 6, 2, 1.37, Tuple.Create<int, int>(52, 3490));
            Console.WriteLine(tuple.Item1);
        }

    }
}

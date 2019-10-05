using System;

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
        }
    }
}

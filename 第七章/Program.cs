using System;

namespace 第七章
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            int x = 5;
            if(++x==6)
            {
                Console.WriteLine("this will execute");
            }
            if(x++==7)
            {
                Console.WriteLine("whis won't");
            }
            //
            int x1 = 1;
            string s = x1 + "";
            s += (x1 == 1 ? "man" : "men");
            Console.WriteLine(s);
            //
            byte b = 255;
            unchecked
            {
                b++;
            }
            Console.WriteLine(b.ToString());
            //
            int i = 10;
            if(i is object)
            {
                Console.WriteLine("i is an object");
            }
            //is运算符
            object o1 = "some string";
            object o2 = 5;
            string s1 = o1 as string;
            string s2 = o2 as string;
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            //as运算符
            Console.WriteLine(sizeof(int));
            /* unsafe
             {
                 Console.WriteLine(sizeof(Customer));
             }*/
            //sizeof
            int? a = null;
           //int? b = a + 4;
            int? c = a + 5;
            //
            byte value1 = 10;
            byte value2 = 23;
            long total;
            total = value1 + value2;
            Console.WriteLine(total);
            //
            long val = 30000000000000000;
            //int i1 = checked((int)val);
            //Console.WriteLine(i1);

        }
    }
}

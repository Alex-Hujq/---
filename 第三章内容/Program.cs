﻿using System;

namespace 第三章内容
{
    class Program
    {
        static void somefun(int[] ints, int i)
        {
            ints[0] = 100;
            i = 100;
        }
        static void Main(string[] args)
        {
            phoencustomer mycus = new phoencustomer();
            phonecusstruct mycusstruct = new phonecusstruct();
            mycus.firstname = "simon";
            mycus.lastname = "jack";
            mycus.custmerid = 1999;
            mycusstruct.lastname = "mark";
            Console.WriteLine(mycusstruct.lastname);
            Console.WriteLine(mycus.firstname+" "+mycus.lastname);
            Console.WriteLine(mycus.custmerid);

            Console.WriteLine("π的值为 " + MathTest.GetPi());
            int x = MathTest.GetSquareOf(5);
            Console.WriteLine("5的平方是 " + x);
            MathTest math = new MathTest();
            math.Value = 30;
            Console.WriteLine("新的value值为 " + math.Value);
            Console.WriteLine("30的平方为 " + math.GetSquare());

            int i = 0;
            int[] ints = { 0, 1, 2, 4, 8 };
            Console.WriteLine("i=" + i);
            Console.WriteLine("ints[0]=" + ints[0]);
            Console.WriteLine("calling somefun.");
            somefun(ints, i);
            Console.WriteLine("i=" + i);
            Console.WriteLine("ints[0]=" + ints[0]);
        }
    }

    class phoencustomer
    {
        public const string dayofsendbill = "monday";
        public int custmerid;
        public string firstname;
        public string lastname;
    }

    struct phonecusstruct
    {
        public const string dayofsendbill = "monday";
        public int custmerid;
        public string firstname;
        public string lastname;
    }
    class acc
    {
        public bool iss(int value)
        {
            if (value < 0)
                return false;
            return true;
        }
    }
    class MathTest
    {
        public int Value;

        public int GetSquare()
        {
            return Value * Value;
        }

        public static int GetSquareOf(int x)
        {
            return x * x;
        }

        public static double GetPi()
        {
            return 3.14159;
        }
    }

    class para
    {
        
    }

}

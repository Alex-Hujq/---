using System;
using System.Drawing;


namespace 第三章内容
{
    class Program
    {
        static void somefun(int[] ints, int y,ref int cd,out int i)
        {
            ints[0] = 100;
            i = 100;
            cd = 200;
            y = 23;
        }

        static string fullname(string firstname, string lastname)
        {
            return firstname + " " + lastname;
            
        }
        
        static void Main(string[] args)
        {
            /*
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
            int cd=0;
            int i = 0,y=0;
            int[] ints = { 0, 1, 2, 4, 8 };
            Console.WriteLine("i=" + i);
            Console.WriteLine("ints[0]=" + ints[0]);
            Console.WriteLine("calling somefun.");
            somefun(ints,y, ref cd, out i);
            Console.WriteLine("i=" + i);
            Console.WriteLine("ints[0]=" + ints[0]+" "+cd+" "+y);

            fullname("jhon", "Doe");
            Console.WriteLine();*/
            Console.WriteLine(DateTime.MaxValue);
            Console.WriteLine();
            Console.WriteLine("userp:backcolor is " + userp.backcolor.ToString());
            //弱引用
            WeakReference mathref = new WeakReference(new MathTest());
            MathTest math;
            if(mathref.IsAlive)
            {
                math=mathref.Target as MathTest;
                math.Value = 30;
                Console.WriteLine("value field of math....." + math.Value);
                Console.WriteLine("square of 30 id  " + math.GetSquare());
            }
            else
            {
                Console.WriteLine("ref is nor available");
            }
            GC.Collect();
            if(mathref.IsAlive)
            {
               math= mathref.Target as MathTest;
            }
            else
            {
                Console.WriteLine("not available");
            }
             //弱引用结束


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
        void Acc(string aa)
        {

        }
        void Acc(int aa)
        {

        }
        /*int Iss(int x)
        {
            Iss(x, 10);
        }
        int Iss(int x,int y)
         {

        }*/

        public string somepro
        {
            get
            {
                return "this";
            }
            set
            {


            }
        }
        private int age;
            public int Age
            {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }

            }

        public class myclass1
        {
            private int num;
            public myclass1(int num)
            {
                this.num = num;
            }
        }
    }
    class aa
    {
        static aa()
        {

        }
    }

    public class userp
    {
        public static readonly Color backcolor;

        static userp()
        {
            DateTime now = DateTime.Now;
            if (now.DayOfWeek == DayOfWeek.Saturday || now.DayOfWeek == DayOfWeek.Sunday)
                backcolor = Color.Green;
            else
                backcolor = Color.Red;
        }
        private userp()
        {

        }
    }

    class car
    {
        private string descri;
        private uint nwheels;
        public car(string descri, uint nwheels)
        {
            this.descri = descri;
            this.nwheels = nwheels;
        }
        public car(string descri):this(descri,4)
        {
            
        }

    }
    public class docun
    {
        public static readonly uint maxdocum;
        static docun()
        {
           /* maxdocum=DoSomeThingFindOutMaxNumber();  */
        }
    }
    public class Docum
    {
        public readonly DateTime createtime;
        public Docum()
        {
            createtime = new DateTime(2002, 1, 1);
        }  
    }
     public class name
    {
        static void nn()
        {
            var captian = new { firstname="jame",midname="K",lastname="mark"};
        }
    }
    struct dimen
    {
        public double Length;
        public double Width;
        public dimen (double length,double width)
        {
            dimen point = new dimen();
            point.Length = 3;
            point.Width = 6;
            Length = length;
            Width = width;
        }
        public double diagonal
        {
            get
            {
                return Math.Sqrt(Length * Length + Width * Width);
            }
        }
    }

}

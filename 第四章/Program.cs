using System;

namespace 第四章
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class mykkclass:Program
    {

    }

    class mybaseclass
    {
        public virtual string  Vm()
        {
            return "this method is virtual and defind in baseclass";
        }
        public virtual string ForeName
        {
            get { return foreName; }
            set { foreName = value; }
        }
        private string foreName;
    }

    class myssclass:mybaseclass
    {
        public override string Vm()
        {
            return "this method is virtual and defind in baseclass";
        }
    }

    class hisbaseclass
    {
        //
    }

    class myderivedclass:hisbaseclass
    {
        public new int mygroovymethod()
        {
            //
            return 0;
        }
    }
    class customeraccount
    {
        public virtual decimal calculatePrice()
        {
            return 0.0M;
        }
    }
    class GoldAccount:customeraccount
    {
        public override decimal calculatePrice()
        {
            return base.calculatePrice()*0.9M;
        }
    }
    //调用函数的基类版本

    abstract class building
    {
        public abstract decimal calculateheatingcost();
    }
    //抽象类，函数

    /*sealed class Finalclass
    {
        public sealed  override void find()
        {

        }
    }
    class derivedclass:Finalclass
    {
        public override void find()
        {

        }
    }*/

    //密封类密封函数



    /*public struct mykkctruct:interface
    {

    }*/
    /*public class Myaaclass : mykkclass,interface
    {

    }*/
    
}

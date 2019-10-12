using System;
using System.Collections.Generic;

namespace 第十章
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            var intList = new List<int>();
            intList.Add(1);
            intList.Add(2);
            var stringList = new List<string>();
            stringList.Add("one");
            stringList.Add("two");

            var graham = new Racer(7, "Graham", "Hill", "UK", 14);
            var emerson = new Racer(13, "Emerson", "Fittipaldi", "Brazil", 14);
            var mario = new Racer(16, "Mario", "Andretti", "USA", 12);

            var racers = new List<Racer>(20) { graham, emerson, mario };

            racers.Add(new Racer(24, "Michael", "Schumacher", "Germany", 91));
            racers.Add(new Racer(27, "Mika", "Hakkinen", "Finland", 20));

            racers.AddRange(new Racer[] {
               new Racer(14, "Niki", "Lauda", "Austria", 25),
               new Racer(21, "Alain", "Prost", "France", 51)});

            var racers2 = new List<Racer>(new Racer[] {
               new Racer(12, "Jochen", "Rindt", "Austria", 6),
               new Racer(22, "Ayrton", "Senna", "Brazil", 41) });

            //
            racers.Insert(3, new Racer(6, "Phil", "Hill", "USA", 3));
            //
            Racer r1 = racers[3];
            for (int i = 0; i < racers.Count; i++)
            {
                Console.WriteLine(racers[i]);
            }
            Console.WriteLine("   ");
            foreach (Racer e in racers)
            {
                
                Console.WriteLine(e);
            }
            //
            racers.RemoveAt(3);
            if(!racers.Remove(graham))
            {
                Console.WriteLine("object not found in collection");
            }
            int index = 3;
            int count = 5;
            racers.RemoveRange(index, count);
            //
            int index1 = racers.IndexOf(mario);
            //public int FindIndex(Predicate<T> match);

           // racers.Sort(new RacerComparer(RacerComparer));
            
        }
    }

    public class FindCountry
    {
        public FindCountry(string country)
        {
            this.country = country;
        }
        private string country;
        public bool FindCountryPredicate(Racer racer)
        {
            return racer.Country == country;
        }
        
    }



    /*public class List<T>:IList<T>
    {
        private T[] items;
        public void Foreach(Action<T> action)
        {
            if (action == null) throw new ArgumentNullException("action");
            foreach(T item in items)
            {
                action(items);
            }
        }
        public delegate void Action<T>(T obj);
    }*/
}

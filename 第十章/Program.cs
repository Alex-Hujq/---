using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Threading;
using System.Linq;
using System.Collections.ObjectModel;

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
           // racers.RemoveRange(index, count);
            //
            //int index1 = racers.IndexOf(mario);
            //public int FindIndex(Predicate<T> match);

            // racers.Sort(new RacerComparer(RacerComparer));
            /*
            List<Person> persons = 
                racers.ConvertAll<Person>(
                    r => Person(r.FirstName + "" + r.LastName));
            */

            var dm = new DocumentManager();
            ProcessDocuments.Start(dm);
            for (int i = 0; i < 10;i++)
            {
                var doc = new Document1("doc " + i.ToString(), "content");
                dm.AddDocument(doc);
                Console.WriteLine("added document  {0}", doc.Title);
                Thread.Sleep(new Random().Next(20));
            }
            //队列

            var alphabet = new Stack<char>();
            alphabet.Push('A');
            alphabet.Push('B');
            alphabet.Push('C');
            foreach(char item in alphabet)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("second iteration:  ");
            while(alphabet.Count>0)
            {
                Console.Write(alphabet.Pop());
            }
            Console.WriteLine();
            //栈
            
            var pdm = new PriorityDocumentManager();
            pdm.AddDocument(new Document("one", "Sample", 8));
            pdm.AddDocument(new Document("two", "Sample", 3));
            pdm.AddDocument(new Document("three", "Sample", 4));
            pdm.AddDocument(new Document("four", "Sample", 8));
            pdm.AddDocument(new Document("five", "Sample", 1));
            pdm.AddDocument(new Document("six", "Sample", 9));
            pdm.AddDocument(new Document("seven", "Sample", 1));
            pdm.AddDocument(new Document("eight", "Sample", 1));

            pdm.DisplayAllNodes();
            
            //链表
            var books = new SortedList<string, string>();
            books.Add("Professional WPF Programming", "978–0–470–04180–2");
            books.Add("Professional ASP.NET MVC 3", "978–1–1180–7658–3");

            books["Beginning Visual C# 2010"] = "978–0–470-50226-6";
            books["Professional C# 4 and .NET 4"] = "978–0–470–50225–9";

            foreach (KeyValuePair<string, string> book in books)
            {
                Console.WriteLine("{0}, {1}", book.Key, book.Value);
            }

            foreach (string isbn in books.Values)
            {
                Console.WriteLine(isbn);
            }

            foreach (string title in books.Keys)
            {
                Console.WriteLine(title);
            }
            string isbn1;
            string title1 = "Professional c# 7.0";
            if(!books.TryGetValue(title1,out isbn1))
            {
                Console.WriteLine("{0} not found", title1);
            }
            //
            var employees = new Dictionary<EmployeeId, Employee>(31);

            var idTony = new EmployeeId("C3755");
            var tony = new Employee(idTony, "Tony Stewart", 379025.00m);
            employees.Add(idTony, tony);
            Console.WriteLine(tony);

            var idCarl = new EmployeeId("F3547");
            var carl = new Employee(idCarl, "Carl Edwards", 403466.00m);
            employees.Add(idCarl, carl);
            Console.WriteLine(carl);

            var idKevin = new EmployeeId("C3386");
            var kevin = new Employee(idKevin, "Kevin Harwick", 415261.00m);
            employees.Add(idKevin, kevin);
            Console.WriteLine(kevin);

            var idMatt = new EmployeeId("F3323");
            var matt = new Employee(idMatt, "Matt Kenseth", 1589390.00m);
            employees[idMatt] = matt;
            Console.WriteLine(matt);

            var idBrad = new EmployeeId("D3234");
            var brad = new Employee(idBrad, "Brad Keselowski", 322295.00m);
            employees[idBrad] = brad;
            Console.WriteLine(brad);



            while (true)
            {
                Console.Write("Enter employee id (X to exit)> ");
                var userInput = Console.ReadLine();
                userInput = userInput.ToUpper();
                if (userInput == "X") break;

                EmployeeId id;
                try
                {
                    id = new EmployeeId(userInput);


                    Employee employee;
                    if (!employees.TryGetValue(id, out employee))
                    {
                        Console.WriteLine("Employee with id {0} does not exist", id);
                    }
                    else
                    {
                        Console.WriteLine(employee);
                    }
                }
                catch (EmployeeIdException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            //字典
            var racers1 = new List<Racer>();
            racers.Add(new Racer(26, "Jacques", "Villeneuve", "Canada", 11));
            racers.Add(new Racer(18, "Alan", "Jones", "Australia", 12));
            racers.Add(new Racer(11, "Jackie", "Stewart", "United Kingdom", 27));
            racers.Add(new Racer(15, "James", "Hunt", "United Kingdom", 10));
            racers.Add(new Racer(5, "Jack", "Brabham", "Australia", 14));

            var lookupRacers = racers.ToLookup(r => r.Country);

            foreach (Racer r in lookupRacers["Australia"])
            {
                Console.WriteLine(r);
            }

            //lookup
            var companyTeams = new HashSet<string>() { "Ferrari", "McLaren", "Mercedes" };
            var traditionalTeams = new HashSet<string>() { "Ferrari", "McLaren" };
            var privateTeams = new HashSet<string>() { "Red Bull", "Lotus", "Toro Rosso", "Force India", "Sauber" };

            if (privateTeams.Add("Williams"))
                Console.WriteLine("Williams added");
            if (!companyTeams.Add("McLaren"))
                Console.WriteLine("McLaren was already in this set");

            if (traditionalTeams.IsSubsetOf(companyTeams))
            {
                Console.WriteLine("traditionalTeams is subset of companyTeams");
            }

            if (companyTeams.IsSupersetOf(traditionalTeams))
            {
                Console.WriteLine("companyTeams is a superset of traditionalTeams");
            }


            traditionalTeams.Add("Williams");
            if (privateTeams.Overlaps(traditionalTeams))
            {
                Console.WriteLine("At least one team is the same with the traditional " +
                      "and private teams");
            }

            var allTeams = new SortedSet<string>(companyTeams);
            allTeams.UnionWith(privateTeams);
            allTeams.UnionWith(traditionalTeams);

            Console.WriteLine();
            Console.WriteLine("all teams");
            foreach (var team in allTeams)
            {
                Console.WriteLine(team);
            }

            allTeams.ExceptWith(privateTeams);
            Console.WriteLine();
            Console.WriteLine("no private team left");
            foreach (var team in allTeams)
            {
                Console.WriteLine(team);
            }
            //集
            var data = new ObservableCollection<string>();
            data.CollectionChanged += Data_CollectionChanged;
            data.Add("One");
            data.Add("Two");
            data.Insert(1, "Three");
            data.Remove("One");

        }

        static void Data_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            Console.WriteLine("action: {0}", e.Action.ToString());

            if (e.OldItems != null)
            {
                Console.WriteLine("starting index for old item(s): {0}", e.OldStartingIndex);
                Console.WriteLine("old item(s):");
                foreach (var item in e.OldItems)
                {
                    Console.WriteLine(item);
                }
            }
            if (e.NewItems != null)
            {
                Console.WriteLine("starting index for new item(s): {0}", e.NewStartingIndex);
                Console.WriteLine("new item(s): ");
                foreach (var item in e.NewItems)
                {
                    Console.WriteLine(item);
                }
            }
            Console.WriteLine();
            //可观察的数组

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

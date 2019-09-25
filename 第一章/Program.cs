using System;

namespace 第一章
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "Bugs Bunny";
            var age = 25;
            var isRabbit = true;

            Type nameType = name.GetType();
            Type ageType = age.GetType();
            Type isRabbitType = isRabbit.GetType();

            Console.WriteLine("name is type " + nameType.ToString());
            Console.WriteLine("age is type " + ageType.ToString());
            Console.WriteLine("isRabbit is type " + isRabbitType.ToString());

            int j = 20;
            for (int i = 0; i < 10; i++)
            {
                //int j = 30;   
                Console.WriteLine(j + i);
            }

            
            /*for (int i = 0; i < args.Length; i++)
            {
                */

           /* Console.WriteLine("Type in a string");
            string input;
            input = Console.ReadLine();
            if (input == "")
            {
                Console.WriteLine("You typed in an empty string");
            }
            else if (input.Length < 5)
            {
                Console.WriteLine("The string had less than 5 characters");
            }
            else if (input.Length < 10)
            {
                Console.WriteLine("The string had at least 5 but less than 10 characters");
            }
            Console.WriteLine("The string was " + input);*/

            /*string coun = Console.ReadLine();
            switch (coun)
            {
                case "uk":
                case "au":
                case "uu": 
                    Console.Write("english");
                    break;
            }*/

            string s1 = "a string";
            string s2 = s1;
            Console.WriteLine("s1 is " + s1);
            Console.WriteLine("s2 is " + s2);
            s1 = "another string";
            Console.WriteLine("s1 is now " + s1);
            Console.WriteLine("s2 is now " + s2);

            ww(TimeOfDay.moring);
            return ;
       


        }
        public enum TimeOfDay
        {
            moring=0,afternoon=1,evening=2
        }
        static void ww(TimeOfDay timeofday)
        {
            switch(timeofday)
            {
                case TimeOfDay.moring:
                    Console.WriteLine("good morning");
                    break;
                case TimeOfDay.afternoon:
                    Console.WriteLine("good afternoon");
                    break;
                case TimeOfDay.evening:
                    Console.WriteLine("good eventing");
                    break;
            }
        }
            
    }
    
    
}

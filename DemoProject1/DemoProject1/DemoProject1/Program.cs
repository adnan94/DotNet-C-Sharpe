using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject1
{

 
    class Program
    {
        static void Main(string[] args)
        {
            //const int myNum = 15;
            //dataTypes();
            ////userInputValues();
            //casting();
            //operators();
            //switchCase();
            //loops();
            //exceptionHandling();
            linq();
            Console.ReadLine();
        }

        static void linq()
        {

            Console.WriteLine("\n\n");

            int[] age = { 10,20,5,54,32,11,2,1,34,123,321,4545,13,2,123,23,13,213,1231,23234};
            string[] names = { "Adnan","Taha","Minhaj","Murtaza","Xmd"};
            
            //var a = from i in age where i > 100 select i;
           // var a = from i in age where i > 100 orderby i select i; //by default accending
            //var a = from i in age where i > 100 orderby i descending select i; // deccending
            //var a = from name in names where name.Contains("a") select name; // deccending
            var a = from name in names where name.StartsWith("A") select name; // deccending


            //foreach (int item in a){
            //    Console.WriteLine(item);
            //}    
            
            foreach (string name in a){
                Console.WriteLine(name);
            }
           
        }
        static void exceptionHandling()
        {

            Console.WriteLine("\n\n");
            try
            {
                int[] myNumbers = { 1, 2, 3 };
                Console.WriteLine(myNumbers[10]);
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
            }
        

        }

        private static void loops() {
            Console.WriteLine("\n\n");


            int counter = 0;

            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };

            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine($"Car : {cars[i]}");
            }

            Console.WriteLine("\n\n");

            while (counter < 10)
            {
                counter++;
                Console.WriteLine($"Iterating while till 10 {counter}");
            }

            Console.WriteLine("\n\n");

            do
            {
                counter++;
                Console.WriteLine($"Iterating do while till 20 {counter}");
            } while (counter < 20);




            Console.WriteLine("\n\n");
            ArrayList arlist = new ArrayList()
                {
                    1,
                    "Bill",
                    300,
                    4.5f
                };


            foreach (var val in arlist)
                Console.WriteLine(val);

        }

        protected static void switchCase() {
            string name = "Adnan";
            switch (name)
            {
                case "Minhaj":
                    Console.WriteLine("Minhaj from switch");
                    break;
                case "Taha":
                    Console.WriteLine("Taha from switch");
                    break; 
                case "Adnan":
                    Console.WriteLine("Adnan from switch");
                    break;
                default:
                    Console.WriteLine("Default Running");
                    break;
            }
             
        }

        public static void operators()
        {
            //comparision operators
            //== Equal to x == y
            //!= Not equal x != y
            //> Greater than x > y
            //< Less than x<y
            //>= Greater than or equal to    x >= y
            //<=

            //logical operator
            //&&
            //||
            //!

            int a = 1;
            int b = 2;
            string s = "Adnan";
            string v = "Minhaj";


            if (a == 0)
            {
                Console.WriteLine("== operator working");
            }else if (a != 0) {
                Console.WriteLine("== operator working with else if");
            }

            if (a > 1)
            {
                Console.WriteLine("A is greater than 1");
            }

            if (a >= 1) {
                Console.WriteLine("A is greater than equal to 1");
            }

            if (a <= 1) {
                Console.WriteLine("A is less than equal to 1");
            }


            if (a == 1 && b == 2) {
                Console.WriteLine("&& operator working");
            }

            if (a == 1 || b == 2)
            {
                Console.WriteLine("|| operator working");
            }
            
            if (a != 0)
            {
                Console.WriteLine("! operator working");
            }

        }

        internal static void userInputValues()
        {
            //Data Types
            Console.WriteLine("Enter your name ?");
            String name = Console.ReadLine();
            Console.WriteLine($"My name is {name}");
            
        }

        static void casting() {
            
            double age = 28.9;
            int number = Convert.ToInt32(Math.Floor(age));
            Console.WriteLine(number);

            char a = '5';
            Console.WriteLine(int.Parse(a.ToString()));

        }

        static void dataTypes()
        {
            //Data Types
            int age = 28;
            char gender = 'M';
            string word = "Adnan Ahmed";
            float height = 5.5f;
            double latitude = 67.53454351;
            bool pakistani = true;


            Console.WriteLine("#################Hello world#############\n\n\n");
            Console.WriteLine($"My name is {word}\n\nMy Age is {age}\n\nMy height is {height}\n\nMy location is {latitude}\n\nMy Gender is {gender}\n\nNationality is pakistani {pakistani}");

        }

        enum Level
        {
            Low,
            Medium,
            High
        }
    }
}

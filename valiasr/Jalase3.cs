using System.Data;

namespace Test
{

    public class Jalase3
    {
        public void jalase3()
        {
            statement();
            Test t = new Test();
            t.method2("person", 40);
            
        }

        public void statement()
        {
            int day = 4;
            // switch case
            switch (day)
            {
                case 1:
                    Console.WriteLine("saturday");
                    break;
                case 2:
                    Console.WriteLine("sunday");
                    break;
                case 3:
                    Console.WriteLine("Monday");
                    break;
                case 4:
                    Console.WriteLine("Tuesday");
                    break;
                case 5:
                    Console.WriteLine("Wednesday");
                    break;
                case 6:
                    Console.WriteLine("Thursday");
                    break;
                case 7:
                    Console.WriteLine("Friday");
                    break;
            }

            day = 4;
            switch (day)
            {
                case 6:
                    Console.WriteLine("Today is Friday.");
                    break;
                default:
                    Console.WriteLine("this is work day:)");
                    break;
            }

            // readline
            Console.WriteLine("enter number of day");
            string input1 = Console.ReadLine();
            int in1 = Convert.ToInt32(input1);
            switch (day)
            {
                case 1:
                    Console.WriteLine("saturday");
                    break;
                case 2:
                    Console.WriteLine("sunday");
                    break;
                case 3:
                    Console.WriteLine("Monday");
                    break;
                case 4:
                    Console.WriteLine("Tuesday");
                    break;
                case 5:
                    Console.WriteLine("Wednesday");
                    break;
                case 6:
                    Console.WriteLine("Thursday");
                    break;
                case 7:
                    Console.WriteLine("Friday");
                    break;
                default:
                    Console.WriteLine("wrong input you enter");
                    break;
            }

            // دستورات تکرار یا حاقه های
            //while
            int counter = 0;
            while (counter < 5)
            {
                Console.WriteLine(counter);
                counter++;
            }

            counter = 5;
            // do while
            // همان وال ولی باید در شرایطی حداقل یک بار اجرا شود.
            do
            {
                Console.WriteLine(counter);
                counter++;
            } while (counter < 5);

            // for
            for (counter = 0; counter < 5; counter++)
            {
                Console.WriteLine(counter);
            }

            // تمامی حلقه ها می توانند تو در تو یا در عبارت دیگر استفاده شوند.
            // Outer loop
            for (int i = 1; i <= 2; ++i)
            {
                Console.WriteLine("Outer: " + i); // Executes 2 times
                // Inner loop
                for (int j = 1; j <= 3; j++)
                {
                    Console.WriteLine(" Inner: " + j); // Executes 6 times (2 * 3)
                }
            }

            // for each
            string[] cars = { "one", "two", "three", "four" };
            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }

            // break
            for (int i = 0; i < 10; i++)
            {
                if (i == 4) break;
                Console.WriteLine(i);
            }

            // continue
            for (int i = 0; i < 10; i++)
            {
                if (i == 4) continue;
                Console.WriteLine(i);
            }

        } 
    }

    public class Test
    {
        // constructor
        public Test()
        {
            // array
            //تعریف یک آرایه از رشته ها
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            //string[] cars;
            // string[] cars = new string[4];
            // string[] cars = new string[4] {"Volvo", "BMW", "Ford", "Mazda"};
            // string[] cars = new string[] {"Volvo", "BMW", "Ford", "Mazda"};

            Console.WriteLine(cars[0]);
            // Outputs Volvo
            cars[0] = "Opel";
            Console.WriteLine(cars[0]);
            Console.WriteLine(cars.Length);

            // Sort an int
            int[] myNumbers = { 5, 1, 8, 9 };
            Array.Sort(myNumbers);
            foreach (int i in myNumbers)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine(myNumbers.Max()); // returns the largest value
            Console.WriteLine(myNumbers.Min()); // returns the smallest value
            Console.WriteLine(myNumbers.Sum()); // returns the sum of elements

            // آزایه های دوبعدی
            int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } };
            numbers[0, 0] = 5; // Change value to 5
            Console.WriteLine(numbers[0, 0]); // Outputs 5 instead of 1

            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    Console.WriteLine(numbers[i, j]);
                }
            }

            method1();
            method1();
            method1();

            method2("reza", 28);
            method2("hansan", 25);
            method2("nagi", 29);

            setCountry();
            setCountry("German");
        }

        void method1()
        {
            Console.WriteLine("I just got executed!");
        }

        // چندین پارامتر ورودی
        public void method2(string fname, int age)
        {
            Console.WriteLine(fname + " is " + age);
        }

        // پارامتر پیش فرض
        void setCountry(string country = "iran")
        {
            Console.WriteLine("your country is " + country);
        }

        // return values
        string getCountry()
        {
            string country = "iran";
            return country;
        }

    }

}
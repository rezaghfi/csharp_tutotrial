namespace Valiasr;

public class Jalase4
{
    
}

public class Test
{
    // constructor
    public Test()
    {
       Console.WriteLine("This is Constructor of Class Test");
    }

    void call()
    {
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

    void array()
    {
        // array
        //تعریف یک آرایه از رشته ها
        //string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
        //string[] cars;
         string[] cars = new string[4];
        // string[] cars = new string[4] {"Volvo", "BMW", "Ford", "Mazda"};
        // string[] cars = new string[] {"Volvo", "BMW", "Ford", "Mazda"};
        //cars[0] = Console.ReadLine();
        Console.WriteLine(cars[0]);
        // Outputs Volvo
        for (int i = 0; i < cars.Length; i++)
        {
            cars[i] = Console.ReadLine();
        }
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
        numbers[2, 1] = 4;
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
    }

}

public class Human
{
    public int age;
    public int nationalCode;
    public string firstname;
    public string lastname;

    public void work()
    {
        Console.WriteLine("i'm working");
    }

    public void walking()
    {
        Console.WriteLine("i'm walking");
    }
}
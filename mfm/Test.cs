using mfm;


public class Test
{
    public static void Main(string[] args)
    {
        //



        int x = Jalase4.function(2);
        Console.WriteLine(x);
        int[] a = Jalase4.date(13);
        Console.WriteLine("year:"+a[0]+"-"+"month:"+a[1]+"-"+"day:"+a[2]);
        
        //Jalase2.one();
        //Jalase2.two();
        // Jalase3.jalase3();

        Car car1 = new Car();
        Car.run();
        Car.s = 1;



    }
}

public class Car
{
    public int year;
    public string color;
    public string compayName;
    public static int s;

    public static void run()
    {
        Console.WriteLine("car is driving");
    }
    
    
}

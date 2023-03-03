using MFM;


public class Run
{
    public static void Main(string[] args)
    {
        
        //Jalase2.one();
        //Jalase2.two();
        // Jalase3.jalase3();
        int x = Jalase4.method(2);
        Console.WriteLine(x);
        int[] a = Jalase4.date(13);
        Console.WriteLine("year:"+a[0]+"-"+"month:"+a[1]+"-"+"day:"+a[2]);
        Car car1 = new Car();
        Car.run();
        Car.s = 1;
    }
}


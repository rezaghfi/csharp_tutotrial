namespace MFM;

public class Jalase4
{
    void m1(int a)
    {
        //
    }

    void m2(int a)
    {
            
    }
        
    // method
    public static int method(int input)
    {
        // body
        return input + 2;
    }

    public static int[] date(int input)
    {
        int maghA1, bagh1, maghA2, bagh2, year = 2023, month = 1, day = 1;
        maghA1 = input / 365;
        bagh1 = input % 365;
        year += maghA1;
        maghA2 = bagh1 / 30;
        bagh2 = bagh1 % 30;
        month += maghA2;
        day += bagh2;
        int[] a = { year, month, day };
        return a;
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

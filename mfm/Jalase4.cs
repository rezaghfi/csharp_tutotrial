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



public class Human
{
    
}

public class Square
{
    
}

public class Laptop
{
    public string model;
    public string companyName;
    public string color;

    public void run()
    {
        Console.WriteLine(this.model + " from " + this.companyName + " is running.");
    }
}
public class Car : Vehicle
{
    public void run()
    {
        Console.WriteLine("hello");
    }
}
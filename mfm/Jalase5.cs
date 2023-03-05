namespace MFM;

public class Jalase5
{
    // method
    public void jalase5(int a)
    {
        if (a > 0)
        {
            Console.WriteLine(a);
        }
        else
        {
            Console.WriteLine(a);
            
        }
    }
    
    // overloading
    public int add(int a, int b)
    {
        return a + b;
    }
    public double add(double a, double b)
    {
        // double ->int
        int c = (int)a;
        // int -> double
        a = b;
        return (int)(a + b);
    }

    public int add(int a, int b, int c)
    {
        return a + b + c;
    }
}

public struct Animal
{
    // field
    public string kind;
    string color;
    
    // method
    void run()
    {
        Console.WriteLine("run");
        Vehicle v = new Vehicle("red","benz", "i5");
        v.color = "blue";
        
        
    }
    
    
}

public class Vehicle
{
    // access
    public string color;
    public string model;
    public string company;
    
    // constractor
    public Vehicle(string color, string company, string model)
    {
        this.color = color;
        this.company = company;
        this.model = model;
        Console.WriteLine("it is new Vehicle");
    }

    public Vehicle()
    {
        Console.WriteLine("it is constructor without parameter");
    }
    public void run()
    {
        Console.WriteLine(this.model + " is running");
    }
    
    // encpsulation
    private string ecuName = "intel";
    // property
    public string EcuName
    {
        set;
        get;
    }

    public void setEcuName(string input)
    {
        this.ecuName = input;
        this.tier = "t";
    }

    public string getecuName()
    {
        return this.ecuName;
    }
    // برای دستری فرزندان
    protected string tier;
    
    // intermal
    internal string glassType;
    
    


}


public class Bicycle: Vehicle
{
    // Construcy
    
}

public class Motor : Vehicle
{
    // constant field
    public const int MAX = 10;
    
    
    public static string staticFiled;
    public Motor(string color, string company, string model)
    {
        this.color = color;
        this.model = model;
        this.company = company;
    }

    public Motor()
    {
        
    }

    // non static
    public void stop()
    {
        this.tier = "kavirTier";
        base.tier = "";
        this.color = "red";
        // constant
        const int i = 0;

    }

    //static
    public static void staticMethod()
    {
        Console.WriteLine("ana static method");
        staticFiled = "static1";
        //this.color
    }
    
}

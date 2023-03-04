namespace Valiasr;

public class Jalase5
{
    // method
    public void call()
    {
        // instance of Human
        // Human ahmad = new Human();
        // ahmad.age = 20;
        // ahmad.firstname = "ahmad";
        // ahmad.lastname = "gorji";
        // ahmad.nationalCode = 111111111;
        // ahmad.work();
        // ahmad.walking();
        
        //call
        Animal a = new Animal("temsah ","green","khazandi", 4);
        a.flying();
        a.setp("red");
        Console.WriteLine(a.getp());

    }

    public void method2()
    {
        Square s = new Square();
        s.zel = 3;
        Console.WriteLine(s.area());
    }
}

public class Square
{
    //field
    public int zel;
    
    //method
    public double area()
    {
        return Math.Pow(this.zel, 2);
    }
    
    //method
    public int mohit()
    {
        return 4 * this.zel;
    }
}

public class Animal
{
    // field
    public string name;
    public string kind;
    public string Color;
    public int feetNum;
    private string p = "red";
    
    // constructor
    public Animal(string a, string b, string c, int d)
    {
        this.name = a;
        this.kind = b;
        this.Color = c;
        this.feetNum = d;
        Console.WriteLine("it is constructor");
        this.p = "red";
    }
    //method
    public void flying()
    {
        if (this.kind == "bird")
        {
            Console.WriteLine(this.name+ "is fly");
        }
        else
        {
            Console.WriteLine(this.name+"is not fly");
        }

        this.p = "red";
    }

    public void setp(string p)
    {
        this.p = p;
    }

    public string getp()
    {
        return this.p;
    }
}

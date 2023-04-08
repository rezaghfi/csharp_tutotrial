using System.Runtime.CompilerServices;

namespace valiasr;


// inheritance
public class Animal
{
    private string name;
    protected string kind;
    public void run()
    {
        Console.WriteLine("run");
    }
}

public class Dog: Animal
{
    protected string dogType;
    
    public void setN(string name)
    {
        this.kind = name;
    }

    public string getN()
    {
        return this.kind;
    }
}

public class Cat : Animal
{
    
}

public class PersionDog : Dog
{
    
}

public abstract class Human
{
    private string name;
    public int age;

    public abstract void roll();
}

public class Men : Human
{
    public override void roll()
    {
        Console.WriteLine("working");
    }

    //public abstract void func1();
}

public class Women : Human
{
    public override void roll()
    {
        Console.WriteLine("Mother");
    }
}


public class Boy : Men
{
    
}

interface Shape
{
    public void area();

    public void perimeter();

}

interface A
{
    public void a();
}

interface B
{
    public void a();
}

// multiple interface for 
interface C : A, B
{
    
}
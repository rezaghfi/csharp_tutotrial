using System.Net.Sockets;
using System.Reflection.PortableExecutable;

namespace csharp_tutorial;

public class Jalase3
{
    // method
    public static void Main(string[] args)
    {
        // call method
        //function();
        method1(2,4);
        int z = method2(2,4);
        int[] car;
    }

    public static void function()
    {
        int a = 10;
        int b = 5;
        int z = a + b;
        Console.WriteLine(z);
    }

    public static void method1(int a, int b)
    {
        int z = a + b;
        Console.WriteLine(z);
    }

    public static int method2(int a, int b)
    {
        return a + b;
    }
    
    
    
}


using System.Formats.Asn1;
using System.Runtime.InteropServices.JavaScript;
using MFM;

namespace namespace1
{

    public class Jalase6
    {
        public static int fib(int n)
        {
            int num1 = 1, num2 = 1;
            if (n == 1 || n == 2) return num1;
            int num3 = 0;
            for (int i = 3; i <= n; i++)
            {
                num3 = num1 + num2;
                num1 = num2;
                num2 = num3;
            }

            return num3;
        }

        public static int fib2(int n)
        {
            if (n == 1 || n == 2) return 1;
            return fib2(n - 1) + fib2(n - 2);
        }
    }

    public class Animal
    {
        public virtual void sound()
        {
            Console.WriteLine("it is animal");
        }
        
    }

    public class Dog : Animal
    {
        public override void sound()
        {
            Console.WriteLine("Wogh wogh");
        }
    }

    public class Cat : Animal
    {
        public override void sound()
        {
            Console.WriteLine("mio mio");
        }
    }
    // no child 
    sealed public class Aghim
    {

    }

    // Abstraction

    // class abstract
    // interface

    // public class child:Aghim
    // {
    //     
    // }

    public abstract  class Animal2
    {
        abstract public void sound();

        public void sleep()
        {
            Console.WriteLine("ZZZ");
        }
    }

    public class Cow : Animal2
    {
        public override void sound()
        {
            Console.WriteLine("MAAAAA");
        }
    }

    public interface Animal3
    {
        public void sound();
        public void sleep();

        public void run();
    }
    
    public class Monkey: Animal3
    {
        public void sound()
        {
            Console.WriteLine();
        }

        public void sleep()
        {
            
        }

        public void run()
        {
            
        }
    }
}

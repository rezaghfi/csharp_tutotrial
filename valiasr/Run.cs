using Mohammad;
using valiasr;

namespace Valiasr;

public class Run
{
    public static void Main(string[] args)
    {
        //Jalase2.jalase2();
        //Jalase3 j3 = new Jalase3();
        //j3.jalase3();
        // Jalase5 j5 = new Jalase5();
        // j5.method2();
        // j5.call();
        // instance 
        //Jalase6 j = new Jalase6();
        // j.setNum(10);
        // j.getNum();
        // static method
        //Jalase6.staticMethod();
        // while (true)
        // {
        //     Jalase6 j2 = new Jalase6("reza");
        // }

        // string a = Console.ReadLine();
        // Jalase6 j3 = new Jalase6(a);
        // Mohammad.Jalase6 human = new Mohammad.Jalase6();
        // Console.WriteLine(human.name);
        // Mohammad1 m = new Mohammad1();
        // Console.WriteLine(m.name);

        valiasr.Animal A = new valiasr.Animal();
        A.run();
        valiasr.Dog D = new valiasr.Dog();
        D.run();
        D.setN("jessy");
        Console.WriteLine(D.getN());
        //valiasr.Human h = new valiasr.Human();
        valiasr.Men m = new valiasr.Men();
        m.roll();
    }
}
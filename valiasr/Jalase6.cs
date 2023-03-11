using System.Runtime.CompilerServices;

namespace Valiasr
{

    public class Jalase6
    {

        // field
        // access modifier
        public int number;
        private int privateNum;
        protected int protectecdNum;

        //method is non static
        public void setNum(int num)
        {
            // 
            this.privateNum = num;
        }

        public static void staticMethod()
        {
            Console.WriteLine("static method");
        }

        public int getNum()
        {
            return privateNum;
        }

        //constructor
        public Jalase6()
        {
            Console.WriteLine("it is instance of jalase6");
        }

        public Jalase6(int a)
        {

        }

        public Jalase6(string a)
        {

        }

        // destructor
        ~Jalase6()
        {
            Console.WriteLine("it is destructor for jalase6");
        }


    }

    public class Child : Jalase6
    {
        void method()
        {
            this.protectecdNum = 12;
        }
    }
}

namespace Masih
{
    public class Jalase6
    {
        public string name = "masih";
    }
}

namespace Mohammad
{
    public class Jalase6
    {
        public string name = "mohammad";
    }

    public class Mohammad1
    {
        public string name = "mohammad";
    }
}
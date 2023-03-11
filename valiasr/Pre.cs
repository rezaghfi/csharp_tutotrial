using System;  

namespace CsharpDestructor {
  
    class Person {

        public Person() {
            Console.WriteLine("Constructor called.");
        }
    
        // destructor
        ~Person() {
            Console.WriteLine("Destructor called.");
        }

        public static void Test(string [] args) {

            //creates object of Person
            Person p1 = new Person();
        }
    } 
}

//static method

// namespace define

// inheritance

// polymorphism

public class Animal{  
    public virtual void eat(){  
        Console.WriteLine("eating...");  
    }  
}  
public class Dog: Animal  
{  
    public override void eat()  
    {  
        Console.WriteLine("eating bread...");  
    }  
      
}  
public class TestPolymorphism  
{  
    public static void Test()  
    {  
        Animal a= new Dog();  
        a.eat();  
    }  
}  
﻿namespace MFM;
    public class Jalase2{
     public static void one() {
        // انواع عملگر ها
        // عملگر های ریاضیاتی
        // + - * / ++ -- %
        int a = 7, b = 10, result;

        result = a + b;
        Console.WriteLine(a + " + " + b + " = " + result);

        result = a - b;
        Console.WriteLine(a + " - " + b + " = " + result);

        result = a * b;
        Console.WriteLine(a + " * " + b + " = " + result);

        result = a / b;
        Console.WriteLine(a + " / " + b + " = " + result);

        result++;
        Console.WriteLine("result++" + " = " + result);

        result--;
        Console.WriteLine("result--" + " = " + result);

        --result;
        Console.WriteLine(" --result" + " = " + result);

        result = a % b;
        Console.WriteLine(a + " % " + b + " = " + result);

        // عملگر انتساب
        // =   -=   +=   *=   /=
        int assignment = 2; // =
        assignment -= 4; // assigment = assingment - 4;
        assignment += 6; // assigment = assingment + 6;
        assignment *= 4; // assigment = assingment * 4;
        Console.WriteLine(assignment);

        //عملگر های مقایسه ای
        // > < >= <= == !=
        var temp = (10 > 7);
        Console.WriteLine("if 10 bigger than 7?" + temp);

        temp = (10 < 7);
        Console.WriteLine("if 10 smaller than 7?" + temp);

        temp = (10 == 7);
        Console.WriteLine("if 10 equl to 7?" + temp);


        temp = (10 != 7);
        Console.WriteLine("if 10 opposite of 7?" + temp);

        //عملگر های منطقی
        // &&  =  AND
        // ||  =  OR
        // !  =   NOT
        int number = 5;
        Console.WriteLine((number > 2 && number > 3));
        Console.WriteLine((number > 5 || number <5));
        bool boolean = true;
        Console.WriteLine(!boolean);
        
        // Math Library
        int max = Math.Max(3, 5);
        int min = Math.Min(5, 6);
        Console.WriteLine("square of root of "+ 6 + " = " + Math.Sqrt(6));
        
        // C# strings

        string greeting = "hello my friends";
        Console.WriteLine("legth of text string is "+ greeting.Length);
        Console.WriteLine(greeting.ToUpper());
        
        // عبارت های شرطی
        // if else if else
        int age = 21;
        if (age <= 7)
        {
            Console.WriteLine("your are child");
        }else if (age > 7 && age <= 30)
        {
            Console.WriteLine("you are young");
        }
        else
        {
            Console.WriteLine("you are old");
        }

        int num1 = 4, num2 = 45, num3 = 23;
        if (num1 >= num2 && num1 >= num3)
        {
            Console.WriteLine("num1 is max");
        }else if (num2 >= num3 && num2 >= num1)
        {
            Console.WriteLine("num2 is max");
        }
        else
        {
            Console.WriteLine("num3 is max");
        }
        // short if 
        int time = 18;
        string res = (time <= 18) ? "Good day." : "Good evening.";
        Console.WriteLine(res);
        // تمرین یک شرط به وسیله سوییچ ننویسید که به ازای اعدادی که می گیرد روز های هفته معادل آن را نمایش دهد.
        
        //شرط تو در تو
        string weather = "sunny";
        string day = "friday";
        if (weather == "sunny")
        {
            if (day == "friday") {
                Console.WriteLine("go to jungle");
            }else{
                Console.WriteLine("go to home");
                
            }
        }
        else
        {
            Console.WriteLine("go to work");
        }
        
        
    }
     
     public static void two()
    {
        
        int day = 4;
        // switch case
        switch (day) 
        {
            case 1:
                Console.WriteLine("saturday");
                break;
            case 2:
                Console.WriteLine("sunday");
                break;
            case 3:
                Console.WriteLine("Monday");
                break;
            case 4:
                Console.WriteLine("Tuesday");
                break;
            case 5:
                Console.WriteLine("Wednesday");
                break;
            case 6:
                Console.WriteLine("Thursday");
                break;
            case 7:
                Console.WriteLine("Friday");
                break;
        }
        
        day = 4;
        switch (day) 
        {
            case 6:
                Console.WriteLine("Today is Friday.");
                break;
            default:
                Console.WriteLine("this is work day:)");
                break;
        }
        
        // readline
        Console.WriteLine("enter number of day");
        string input1 = Console.ReadLine();
        int in1 = Convert.ToInt32(input1);
        switch (day) 
        {
            case 1:
                Console.WriteLine("saturday");
                break;
            case 2:
                Console.WriteLine("sunday");
                break;
            case 3:
                Console.WriteLine("Monday");
                break;
            case 4:
                Console.WriteLine("Tuesday");
                break;
            case 5:
                Console.WriteLine("Wednesday");
                break;
            case 6:
                Console.WriteLine("Thursday");
                break;
            case 7:
                Console.WriteLine("Friday");
                break;
            default:
                Console.WriteLine("wrong input you enter");
                break;
        }
        
        // دستورات تکرار یا حاقه های
        //while
        int counter = 0;
        while (counter < 5)
        {
            Console.WriteLine(counter);
            counter++;
        }

        counter = 5;
        // do while
        // همان وال ولی باید در شرایطی حداقل یک بار اجرا شود.
        do
        {
            Console.WriteLine(counter);
            counter++;
        } while (counter < 5);
        
        // for
        for (counter = 0; counter < 5; counter++)
        {
            Console.WriteLine(counter);
        }
        
        // تمامی حلقه ها می توانند تو در تو یا در عبارت دیگر استفاده شوند.
        // Outer loop
        for (int i = 1; i <= 2; ++i) 
        {
            Console.WriteLine("Outer: " + i);  // Executes 2 times
            // Inner loop
            for (int j = 1; j <= 3; j++) 
            {
                Console.WriteLine(" Inner: " + j); // Executes 6 times (2 * 3)
            }
        }
        // for each
        string[] cars = { "one", "two", "three", "four" };
        foreach (string i in cars)
        {
            Console.WriteLine(i);    
        }
        
        // break
        for (int i = 0; i < 10; i++) {
            if (i == 4) break;
                Console.WriteLine(i);
        }
        
        // continue
        for (int i = 0; i < 10; i++) {
            if (i == 4) continue;
                Console.WriteLine(i);
        }
        
        
    }
}
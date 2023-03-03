namespace Valiasr;
public class Jalase3
{
    public void jalase3()
    {
        statement();
    }

    public void statement()
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
            Console.WriteLine("Outer: " + i); // Executes 2 times
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
        for (int i = 0; i < 10; i++)
        {
            if (i == 4) break;
            Console.WriteLine(i);
        }

        // continue
        for (int i = 0; i < 10; i++)
        {
            if (i == 4) continue;
            Console.WriteLine(i);
        }

    } 
}
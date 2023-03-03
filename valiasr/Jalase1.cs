namespace Valiasr;
public class Jalase1
{
    public static void jalase1()
    {
        // single line comment
            
        /*
         * multi line comment
         * line2
         * line3
         */
            
        // output
        Console.WriteLine("hello my friends");
        // دو عدد صحیح تعریف و به هر کدام مقدار دهیم و آن ها رو با هم جمع منها ضرب کنیم.
        // تعریف متغییر در سی شارپ
        int number1 = 12;
        int number2 = 13;
        int result = number1 + number2;
        Console.WriteLine(result);
        result = number1 - number2;
        Console.WriteLine(result);
        result = number1 * number2;
        Console.WriteLine(result);
            
        //انواع داده ها در سی شارپ
        // بر پایه مقدار
        byte b = 255; // 0 to 255
        sbyte sb = -128; // -128 to 127
        int i = 2147483647;
        uint ui = 4294967295;
        short s = 32767;
        ushort us = 65353;
        long l = 9223372036854775807;
        ulong ul = 18446744073709551615;
        float f = 3.402823e38f;
        double d = 1.7979769313486232;
        System.Double dd = 1.2323;
        bool flag = true; // boolean
        decimal num = 124;
        DateTime dt = new DateTime(1401, 12, 05, 2, 57, 00);
        dt = DateTime.Now;
        Console.WriteLine(dt);
        var variable = true; // می تونه هر نوع متغیر را در آن ذخیره کنی.
            
        // بر پایه ارجاع
        string str = "reza"; // string
            

    }
}
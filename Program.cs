// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System.Linq.Expressions;
using System.Runtime.CompilerServices;

public class Program
{

    static void Main()
    {
        Task1();
        Task2();
        Task3();
        Task4();
        Task5();
        Task6();
        Task7();
        Task8();
        Task9();
    }

    private static void Task1()
    {
        var num = 20;
        num += 5;
        Console.WriteLine("Peremennaya:" + num);
        // task1: implicitly typed variable declaration, assigning a value to a variable, increase variable by 5
    }

    private static void Task2()
    {
        Console.WriteLine("Enter four digit number");
        int number = Convert.ToInt32(Console.ReadLine());
        if ((number >= 1000) && (number <= 9999))
        {                       //check if four digits number was entered
            int months_gen = number / 30;                                // calculate the number of months (general)
            int days = number % 30;                                      // calculate the number of days
            int years = months_gen / 12;                                 // calculate the number of years
            int months = months_gen % 12;                                // calculate the number of months
            Console.WriteLine(years + " years " + months + " months " + days + " days ");  // output of the calculated value
        }
        else
        {
            Console.WriteLine("four digits number should be entered");
        }
    }

    private static void Task3()
    {
        Console.WriteLine("Enter a number");                          // ask user to enter a number
        int n = Convert.ToInt32(Console.ReadLine());                  // user enters a number
        Console.WriteLine("Resultat operacii = " + (n + n * 2));      // output of the calculated value

    }

    private static void Task4()
    {
        sbyte a = -34;                                                 // declaration of variables
        byte b = 4;
        string c = "Hello";
        char d = 'R';
        float e = (float) 23.093433222;
        ushort f = 40000;
        bool g = true;
        byte h = 0;
        Console.WriteLine(a + " - sbyte; " + b + " - byte; " + c + " - string; " + d + " - char; " +   
            e + " - float; " + f + " - ushort; " + g + " - bool; " + h + " - byte");    // output of values and types
    }

    private static void Task5()
    {
        Console.WriteLine("Vvedite otricatelnoye chetyrehznachnoye chislo");         
        short a = Convert.ToInt16(Console.ReadLine());                                  // input of values, declaration of variables

        Console.WriteLine("Vvedite polozitelnoye deviatnadcatiznachnoye chislo");
        ulong b = Convert.ToUInt64(Console.ReadLine());

        Console.WriteLine("Vvedite simvol");
        char c = Convert.ToChar(Console.ReadLine());

        Console.WriteLine("Vvedite drobnoye chislo");
        double d = Convert.ToDouble(Console.ReadLine());
    }

    private static void Task6()
    {
        int a = -5;
        int a1 = a * 7;                                                                     // multiplication by 7
        a--;                                                                                // decrementation
        Console.WriteLine("Resultat operacii 1 = " + a1 + "Resultat operacii 2 = " + a);    // output of the calculated value: multiplication by 7
        Console.WriteLine("Resultat operacii 1 = " + a1 + "Resultat operacii 2 = " + a);    // output of the calculated value: decrementation
    }

    private static void Task7()
    {
        Console.WriteLine("Vvedite chislo");
        int a = Convert.ToInt32(Console.ReadLine());                        // input of a number
        if ((a % 2) != 0)                                                   // divide by two and find the remainder
        {
            Console.WriteLine("Chislo nechetnoye");
        }
        else
        {
            Console.WriteLine("Chislo chetnoye");
        }
    }

    private static void Task8()
    {
        Console.WriteLine("Vvedite chislo");
        int a = Convert.ToInt32(Console.ReadLine());                           // input of a number
        if (((a < 50) & (a != 37) & (a > 32)) || ((a == 0) || (a == 15)))      // check of condition
        {
            Console.WriteLine("Working");
        }
        else
        {
            Console.WriteLine("Not Working");
        }

    }

    private static void Task9()
    {
        Console.WriteLine("Vvedite dva chisla");
        int a = Convert.ToInt32(Console.ReadLine());                           // input of numbers
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Vvedite arifmeticheskoye dejstvie: +, -. *, /");
        string? s = Console.ReadLine();
        int result;
        switch (s)                                                             // define and perform an arithmetic operation
        {
            case "+":
                result = a + b;
                Console.WriteLine("Summa ravna " + result);
                break;
            case "-":
                result = a - b;
                Console.WriteLine("Rasnica ravna " + result);
                break;
            case "*":
                result = a * b;
                Console.WriteLine("Proizvedeniye ravno " + result);
                break;
            case "/":
                float r = (float) a / b;
                Console.WriteLine("Chastnoye ravno " + r);
                break;
            default:
                Console.WriteLine("Arifmeticheskoye dejstvie vvedeno neverno");
                break;
                        }
    }


}
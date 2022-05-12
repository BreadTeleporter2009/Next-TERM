using System;

class Program{
    public static void Main (string[] args) {
        float a = "0";
        float b = "0";
        string op = "";

        Console.WriteLine("What is the first number?");
        a = Console.ReadLine();
        Console.WriteLine("What is the second number?");
        b = Console.Readline();
        Console.WriteLine("(A)dd, (S)ubtract, (D)ivide or (M)ultiply?")
        op = Console.Readline();
        if (op=="a" || op=="A")
        {
            Console.WriteLine(a+b);
        }
        else if (op=="s" || op=="S")
        {
            Console.WriteLine(a-b);
        }
        else if (op=="d" || op=="D")
        {
            Console.WriteLine(a/b);
        }
        else if (op=="m" || op=="M")
        {
            Console.WriteLine(a*b)
        }
        else
        {
            Console.Writeline("Invalid operator.")
        }
        return 0;
    }
}
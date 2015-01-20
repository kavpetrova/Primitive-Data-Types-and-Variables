/*Problem 8. Isosceles Triangle

Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:
Note: The © symbol may be displayed incorrectly at the console so you may need to change the console 
character encoding to UTF-8 and assign a Unicode-friendly font in the console.*/
using System;
using System.Text;

class Triangle
{
    static void Main()
    {
        char Symbol = '©';
        Console.OutputEncoding = Encoding.Unicode;
        Console.WriteLine("   {0}", Symbol);
        Console.WriteLine();
        Console.WriteLine("  {0} {0}", Symbol);
        Console.WriteLine();
        Console.WriteLine(" {0}   {0}", Symbol);
        Console.WriteLine();
        Console.WriteLine("{0} {0} {0} {0}",Symbol);


    }
}


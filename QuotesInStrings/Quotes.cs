﻿/*Problem 7. Quotes in Strings

Declare two string variables and assign them with following value: The "use" of quotations causes difficulties.
Do the above in two different ways - with and without using quoted strings.
Print the variables to ensure that their value was correctly defined.*/
using System;

class Quotes
{
    static void Main()
    {
        string PartOne = "The \"use\" of quotations";
        string PartTwo = "causes difficulties";
        Console.WriteLine(PartOne +" " + PartTwo);
        Console.WriteLine("{0} {1}", PartOne, PartTwo);
    }
}


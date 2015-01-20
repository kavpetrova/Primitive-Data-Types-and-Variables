/*Problem 11. Bank Account Data

A bank account has a holder name (first name, middle name and last name), available amount of money (balance), 
bank name, IBAN, 3 credit card numbers associated with the account.
Declare the variables needed to keep the information for a single bank account using the appropriate data types 
and descriptive names.*/
using System;


class BankAccount
{
    static void Main()
    {
        Console.Write("Enter your First Name:");
        string inputName = Console.ReadLine();
        Console.Write("Enter your Last Name:");
        string inputLName = Console.ReadLine();
        Console.Write("Enter your pass:");
        object inputPass = Console.ReadLine();
        Console.WriteLine("Enter the name of your bank:");
        string inputBank = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("Your Name is: {0} {1}", inputName, inputLName);
        Console.WriteLine("Your password is: {0}", inputPass);
        Console.WriteLine("Bank name: {0}",inputBank);
        Console.WriteLine();
        decimal balanceOfMoney = 4567;
        Console.WriteLine("Available bank balance: {0}lv", balanceOfMoney);
        string iBan = "BGN12FRW8345456677000";
        Console.WriteLine("IBAN / {0}", iBan);
        string bicCode = "BIC12345";
        Console.WriteLine("BIC CODE / {0}", bicCode);
        ulong creditCard1 = 1234567891234567;
        Console.WriteLine("The number of your first credit card is: {0}", creditCard1);
        ulong creditCard2 = 1122334455667788;
        Console.WriteLine("The number of your second credit card is: {0}", creditCard2);
        ulong creditCard3 = 1223344556677898;
        Console.WriteLine("The number of your third credit card is: {0}", creditCard3);

    }
}


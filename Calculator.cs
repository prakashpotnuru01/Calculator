// Write a Simple console Application Calculator with the help of Visual Studio .NET IDE which will perform
//following operations on two numbers:
// Addition.
// Subtraction.
// Multiplication.
// Division
// Accept input from user and display results on console. Make use of loops, switch case wherever required.

public class Calculator
{
    public static void CalMeth()
    {
        Console.WriteLine("Enter value a: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter value b: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter value operation: ");
        char operation = Convert.ToChar(Console.ReadLine());

        int result = 0;

        switch (operation)
        {
            case '+': result = a+b; break;
            case '-': result = a-b; break;
            case '*': result = a*b; break;
            case '%': result = a%b; break;
            default: Console.WriteLine("Invalid"); break;

        }
        Console.WriteLine("Result:" +result);  
        
    }
}
using System;

class program
{
    delegate int operation(int a, int b);

    static int Add(int x, int y)
    {
        return x + y;
    }

    static int subtract(int x, int y)
    {
        return x - y;
    }

    static int calculate(int a, int b, operation op)
    {
        return op(a, b);
    }
    static void Main()
    {
        int num1 = 9, num2 = 5;

        int addResult = calculate(num1, num2, Add);
        int subResult = calculate(num1, num2, subtract);

        Console.WriteLine("Addition Result: " + addResult);
        Console.WriteLine("Subtraction Result : " + subResult);

        Console.ReadKey();
    }
}


using System;

class Calculator
{
    // закрытый метод сложения двух чисел
    private int Add(int a, int b)
    {
        return a + b;
    }

    // открытый метод вычисления факториала
    public long Factorial(int number)
    {
        long result = 1;

        for (int i = 1; i <= number; i++)
        {
            result = result * i;
        }

        return result;
    }
}

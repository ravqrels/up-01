
using System;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        Calculator calculator = new Calculator();

        // ввод чисел для сложения
        Console.WriteLine("Введите первое число:");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите второе число:");
        int num2 = Convert.ToInt32(Console.ReadLine());

        // вызов закрытого метода Add
        var addMethod = typeof(Calculator).GetMethod(
            "Add",
            BindingFlags.NonPublic | BindingFlags.Instance);

        int sum = (int)addMethod.Invoke(
            calculator, new object[] { num1, num2 });

        Console.WriteLine("Результат сложения: " + sum);

        // вычисление факториала
        Console.WriteLine("Введите число для вычисления факториала:");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number >= 0 && number <= 20)
        {
            long factorialResult = calculator.Factorial(number);

            Console.WriteLine("Факториал " + number + ": " + factorialResult);
        }
        else
        {
            Console.WriteLine("Введите число от 0 до 20.");
        }

        // создание пользователя
        User user = new User();

        Console.WriteLine("\nВведите имя пользователя:");
        user.Name = Console.ReadLine();

        Console.WriteLine("Введите возраст:");
        user.Age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите электронную почту:");
        user.Email = Console.ReadLine();

        Console.WriteLine("Введите логин:");
        user.Login = Console.ReadLine();

        // вывод информации о пользователе
        Console.WriteLine("\nИнформация о пользователе:");
        Console.WriteLine("Имя: " + user.Name);
        Console.WriteLine("Возраст: " + user.Age);
        Console.WriteLine("Почта: " + user.Email);
        Console.WriteLine("Логин: " + user.Login);

        Console.ReadLine();
    }
}

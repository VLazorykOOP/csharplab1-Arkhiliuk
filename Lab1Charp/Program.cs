using System;

class Program
{
    static void Main(string[] args)
    {
        // Обчислення площі рівностороннього трикутника за заданим периметром
        Console.WriteLine("1. Обчислення площі рівностороннього трикутника:");
        Console.WriteLine("Введіть периметр рівностороннього трикутника:");
        double p = Convert.ToDouble(Console.ReadLine());
        double a = p / 3;
        double area = (Math.Sqrt(3) / 4) * Math.Pow(a, 2);
        Console.WriteLine($"Площа трикутника: {area}");

        // Визначення, чи є задане ціле число парним
        Console.WriteLine("\n2. Визначення, чи є число парним:");
        Console.WriteLine("Введіть ціле число:");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number % 2 == 0)
        {
            Console.WriteLine("Число парне");
        }
        else
        {
            Console.WriteLine("Число непарне");
        }

        // Визначення положення точки відносно заштрихованої області
        Console.WriteLine("\n3. Визначення положення точки:");
        Console.WriteLine("Введіть координати точки (x, y):");
        double x = Convert.ToDouble(Console.ReadLine());
        double y = Convert.ToDouble(Console.ReadLine());
        double distanceToCenter = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
        if (distanceToCenter < 9)
        {
            Console.WriteLine("Так: точка знаходиться всередині заштрихованої області");
        }
        else if (distanceToCenter > 9)
        {
            Console.WriteLine("Ні: точка знаходиться поза заштрихованою областю");
        }
        else
        {
            Console.WriteLine("На межі: точка знаходиться на межі заштрихованої області");
        }

        // Виведення кількості днів, що залишилися до кінця місяця
        Console.WriteLine("\n4. Виведення кількості днів до кінця місяця:");
        Console.WriteLine("Введіть порядковий номер дня місяця:");
        int dayOfMonth = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Залишилося {(30 - dayOfMonth)} днів до кінця місяця");

        // Реалізація функції обчислення різниці двох цілих чисел
        Console.WriteLine("\n5. Обчислення різниці двох цілих чисел:");
        Console.WriteLine("Введіть перше ціле число:");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введіть друге ціле число:");
        int num2 = Convert.ToInt32(Console.ReadLine());
        int difference = num1 - num2;
        Console.WriteLine($"Різниця між числами: {difference}");

        // Обчислення виразу ((1/x*y)+(1/(x^2)+1))*(x+y), де x, y- дійсні
        Console.WriteLine("\n6. Обчислення виразу ((1/x*y)+(1/(x^2)+1))*(x+y):");
        Console.WriteLine("Введіть значення x:");
        double xValue = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введіть значення y:");
        double yValue = Convert.ToDouble(Console.ReadLine());
        double expressionResult = (1/(xValue*yValue) + 1/(Math.Pow(xValue, 2)+1)) * (xValue + yValue);
        Console.WriteLine($"Результат виразу: {expressionResult}");


        Console.ReadLine();
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("Cалямчики выбери программу:");
            Console.WriteLine("1. Игра Угадай число");
            Console.WriteLine("2. Таблица умножения");
            Console.WriteLine("3. Вывод делителей числа");
            Console.WriteLine("0. Выход");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    IGRAYGADAICHICLO();
                    break;
                case 2:
                    TABLISAYMNOLENIA();
                    break;
                case 3:
                    VIVODDELITELEICHICLA();
                    break;
                case 0:
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Неверный выбор!");
                    break;
            }
        }
    }

    static void IGRAYGADAICHICLO()
    {
        Random random = new Random();
        int randomNumber = random.Next(0, 101);
        int guess;

        do
        {
            Console.WriteLine("Введите число:");
            guess = int.Parse(Console.ReadLine());

            if (guess < randomNumber)
            {
                Console.WriteLine("Загаданное число больше");
            }
            else if (guess > randomNumber)
            {
                Console.WriteLine("Загаданное число меньше");
            }

        } while (guess != randomNumber);

        Console.WriteLine("Вы угадали число!");
    }

    static void TABLISAYMNOLENIA()
    {
        int[,] multiplicationTable = new int[10, 10];

        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                multiplicationTable[i, j] = (i + 1) * (j + 1);
            }
        }

        Console.WriteLine("Таблица умножения:");                                                   
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Console.Write($"{multiplicationTable[i, j]}\t");
            }
            Console.WriteLine();
        }

        Console.WriteLine("Возвращаемся в меню.");
    }

    static void VIVODDELITELEICHICLA()
    {
        Console.WriteLine("Введите число:");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine($"Делители числа {number}:");
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                Console.WriteLine(i);
            }
        }

        Console.WriteLine("Возвращаемся в меню.");
    }
}

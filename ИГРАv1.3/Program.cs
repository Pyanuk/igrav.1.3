using System;

class Program
{
    static void IGRA(string[] args)
    {
        int choice;

        do
        {
            ShowMenu();
            choice = GetUserChoice();

            switch (choice)
            {
                case 1:
                    GuessNumberGame();
                    break;
                case 2:
                    MultiplicationTable();
                    break;
                case 3:
                    FactorsOfNumber();
                    break;
                case 4:
                    Console.WriteLine("ПОКАААААААА");
                    break;
                default:
                    Console.WriteLine("Неверный выбор. Пожалуйста, выберите снова.");
                    break;
            }
        } while (choice != 4);
    }

    static void ShowMenu()
    {
        Console.WriteLine("САЛАМ АЛЕЙКУМ");
        Console.WriteLine("Выберите одну из следующих опций:");
        Console.WriteLine("1. Игра 'Угадай число'");
        Console.WriteLine("2. Таблица умножения");
        Console.WriteLine("3. Вывод делителей");
        Console.WriteLine("4. Выход");
    }

    static int GetUserChoice()
    {
        Console.Write("Введите номер выбранной опции: ");
        return Convert.ToInt32(Console.ReadLine());
    }
    static int GetUserChoice()
    {
        int choice;
        while (!int.TryParse(Console.ReadLine(), out choice))
        {
            Console.WriteLine("Неверный ввод. Пожалуйста, введите число.");
        }
        return choice;
    }
    static void GuessNumberGame()
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

    static void MultiplicationTable()
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

    static void FactorsOfNumber()
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

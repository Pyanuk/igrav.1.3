using System;

class Program
{
    static void Main(string[] args)
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
        Console.WriteLine("3. Делители  числа");
        Console.WriteLine("4. Выход");
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
            while (!int.TryParse(Console.ReadLine(), out guess))
            {
                Console.WriteLine("Неверный ввод. Пожалуйста, введите число.");
            }

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
        int[,] tablica = new int[11, 11];
        for (int left = 1; left <= 10; left++)
        {
            for (int down = 1; down <= 10; down++)
            {
                tablica[left, down] = (left) * (down);
                Console.Write(tablica[left, down]);
                Console.Write("\t");
            }
            Console.WriteLine();
        }
    }

    static void FactorsOfNumber()
    {
        int number;

        Console.WriteLine("Введите число:");
        while (!int.TryParse(Console.ReadLine(), out number))
        {
            Console.WriteLine("Неверный ввод. Пожалуйста, введите число.");
        }

        Console.WriteLine("Делители числа " + number + " :");

        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}

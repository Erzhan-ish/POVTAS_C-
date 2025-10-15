namespace POVTAS_1;

public class SM
{
    public static void Run()
    {
        int min = 0;
        int max = 101;
        Console.WriteLine("Загадайте число от 1 до 100");
        Console.WriteLine("Отвечайте больше,меньше, или да");
        while (true)
        {
            int midl = (min + max) / 2;
            Console.WriteLine("Ваше число " + midl + "?");
            string? at = Console.ReadLine();
            if (at == "больше")
            {
                min = midl;
            }

            if (at == "меньше")
            {
                max = midl;
            }

            if (at == "да")
            {
                Console.WriteLine("Я угадал! ваше число " + midl);
                break;
            }
        }
    }

    public static void Stap()
    {   
        Console.WriteLine("Введите число в десятиричной системе: ");
        int number = Convert.ToInt32(Console.ReadLine());
        string bin = "";
        while (number > 0)
        {
            int rem = number % 2;
            bin = rem + bin;
            number /= 2;
            Console.WriteLine(bin);
        }
        Console.WriteLine($"В двоичной системе: {bin}");
    }

    public static void Stap2()
    {
        Console.WriteLine("Введите число в двоичной системе: ");
        string bin = Console.ReadLine();
        int dec = 0;
        int pow = 0;
        for (int i = bin.Length - 1; i >= 0; i--)
        {
            if (bin[i] == '1')
            {
                int val = 1;
                for (int j = 0; j < pow; j++)
                {
                    val *= 2;
                }
                dec += val;
            }
            pow++;
        }
        Console.WriteLine($" {dec}");
    }

    public static void St()
    {
        Console.WriteLine("Выберите двоичную или десятиричную систему счисления(1,2): ");
        string ans = Console.ReadLine();
        if (ans == "1")
        {
            Stap2();
        }
        else
        {
            Stap();
        }
    }
    public static void Cinema()
    {
        // Создаем 2D-массив мест: 5 рядов, 6 мест в каждом
        int rows = 5;
        int seats = 6;
        bool[,] cinema = new bool[rows, seats]; // false — место свободно, true — занято

        while (true)
        {
            Console.Clear();
            Console.WriteLine("📽 Кинотеатр — бронирование мест");
            Console.WriteLine("--------------------------------");
            ShowSeats(cinema);

            Console.Write("\nВведите номер ряда (1–5): ");
            int row = int.Parse(Console.ReadLine()) - 1;

            Console.Write("Введите номер места (1–6): ");
            int seat = int.Parse(Console.ReadLine()) - 1;

            // Проверка корректности ввода
            if (row < 0 || row >= rows || seat < 0 || seat >= seats)
            {
                Console.WriteLine("❌ Неверный номер ряда или места!");
            }
            else if (cinema[row, seat])
            {
                Console.WriteLine("⚠️  Это место уже занято!");
            }
            else
            {
                cinema[row, seat] = true;
                Console.WriteLine("✅ Место успешно забронировано!");
            }

            Console.WriteLine("\nНажмите любую клавишу, чтобы продолжить...");
            Console.ReadKey();
        }
    }

    // Метод вывода схемы зала
    public static void ShowSeats(bool[,] cinema)
    {
        Console.WriteLine("   1  2  3  4  5  6");
        for (int i = 0; i < cinema.GetLength(0); i++)
        {
            Console.Write($"{i + 1}: ");
            for (int j = 0; j < cinema.GetLength(1); j++)
            {
                if (cinema[i, j])
                    Console.Write("[X]"); // занято
                else
                    Console.Write("[ ]"); // свободно
            }
            Console.WriteLine();
        }
    }
}
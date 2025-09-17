namespace POVTAS_1
{
    public class TrafficLight
    {
        public static void Run()
        
        {
            while (true)
            {
                Console.Write("Введите цвет: ");
                string? color = Console.ReadLine()?.ToLower();

                if (color == "выход")
                {
                    break;
                }
                    
                switch (color)
                {
                    case "зеленый":
                        Console.WriteLine("Вперед!");
                        break;
                    case "желтый":
                        Console.WriteLine("Приготовьтесь!");
                        break;
                    case "красный":
                        Console.WriteLine("Стой!");
                        break;
                    default:
                        Console.WriteLine("Неизвестный цвет.");
                        break;
                }
                Console.WriteLine();
            }
        }
    }
}
namespace POVTAS_1;

public class laboratory
{
    public static void Ploshyad()
    {
        Console.WriteLine("Введите количество сторон: ");
        double c = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите длинну а: ");
        double a = Convert.ToInt32(Console.ReadLine());
        if (c >= 3)
        {
            double total = a * c;
            Console.WriteLine("Площадь n-угольника " + total);
        }
        else
        {
            Console.WriteLine("Не может быть меньше 3 сторон");
        }
    }
    
    public static void PoinCoor()
    {
        Console.WriteLine("Введите координаты точки A (x1,y1,z1):");
        double x1 = Convert.ToDouble(Console.ReadLine());
        double y1 = Convert.ToDouble(Console.ReadLine());
        double z1 = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("Введите координаты точки B (x2,y2,z2):");
        double x2 = Convert.ToDouble(Console.ReadLine());
        double y2 = Convert.ToDouble(Console.ReadLine());
        double z2 = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("Введите координаты точки C (x3,y3,z3):");
        double x3 = Convert.ToDouble(Console.ReadLine());
        double y3 = Convert.ToDouble(Console.ReadLine());
        double z3 = Convert.ToDouble(Console.ReadLine());


        double distanceA = Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2) + Math.Pow(z3 - z1, 2));
        double distanceB = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2) + Math.Pow(z3 - z2, 2));
        
        if (distanceA < distanceB)
        {
            Console.WriteLine("Точка A ближе к точке C");
        }
        else if (distanceB < distanceA)
        {
            Console.WriteLine("Точка B ближе к точке C");
        }
        else
        {
            Console.WriteLine("Обе точки на одинаковом расстоянии от С");
        }
    }

    public static void Logfor()
    {
        Console.WriteLine(" x \t F(x) ");
        
        for (double x = -3; x <= 0; x += 0.1)
        {

            if (x > 0)
            {
                double lgX = Math.Log10(x);
                double expTerm = Math.Exp(-(Math.Cos(x) * Math.Sin(x)));
                double F_x = Math.Abs(lgX * expTerm); 
                Console.WriteLine($"{x:F1} \t {F_x:F4}");
            }
            else
            {
                Console.WriteLine($"{x:F1} \t Не определено");
            }
        }
    }

    public static void List()
    {
        int[] numbers = new int[6] {3,-4,5,-6,9,-2};
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > 0)
            {
                sum += numbers[i];
            }
        }
        double sqrt = Math.Sqrt(sum);
        Console.WriteLine($"Квадратный корень суммы положительных чисел: {sqrt}");


    }
}

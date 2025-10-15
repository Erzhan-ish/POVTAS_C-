namespace POVTAS_1
{
    public class Ls1
    {
        public static void Name()
        {
              Console.WriteLine("Как вас зовут?");
              string name = Console.ReadLine();
              Console.WriteLine("Hello " + name);
              Console.WriteLine("Введите год рождения");
              int year = Convert.ToInt32(Console.ReadLine());
              int age = 2025 - year;
                  Console.WriteLine(name + " вам " + age+" лет");
        }

        public static void Calculator()
        {
            Console.WriteLine("Введите 1-ое число: ");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите 2-ое число: ");
            int second = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Выберите действие(+,-,*,/): ");
            switch (Console.ReadLine())
            {
                case "+":
                    int sum = first + second;
                    Console.WriteLine(sum);
                    break;
                case "-":
                    int sum2 = first - second;
                    Console.WriteLine(sum2);
                    break;
                case "*":
                    int sum3 = first * second;
                    Console.WriteLine(sum3);
                    break;
                case "/":
                    int sum4 = first / second;
                    Console.WriteLine(sum4);
                    break;
                default:
                    Console.WriteLine("Неккоректное действие");
                    break;
            }
        }

        public static void Course()
        {
            Console.WriteLine("Введите сумму(сом): ");
            double som = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("В какую ваолюту перевести?(Доллар,Евро,Юань): ");
            switch (Console.ReadLine())
            {
                case "Доллар":
                    double dollar = som / 87;
                    Console.WriteLine(som + " сом это " + dollar + " долларов");
                    break;
                case "Евро":
                    double euro = som / 102;
                    Console.WriteLine(som + " сом это " + euro + " Евро");
                    break;
                case "Юань":
                    double yan = som / 12;
                    Console.WriteLine(som + " сом это " + yan + " Юань");
                    break;
            }
        }
    }
}

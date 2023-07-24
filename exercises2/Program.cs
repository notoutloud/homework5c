namespace exercises2;

class Program
{
    static void Main(string[] args)
    {
        int Input(string text)
        {
            Console.Write(text);
            return Convert.ToInt32(Console.ReadLine());
        }

        void Task41()
        {
            int size = Input("Введите размер массива: ");
            int[] num = new int[size];
            int sum = 0;
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = Input("Введите число: ");
            }

            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] > 0)
                {
                    sum++;
                }
            }
            Console.WriteLine($"Чисел больше 0 = {sum}");

        }

        void Task43()
        {
            double b1 = Input("1 точка 1 прямой: ");
            double k1 = Input("2 точка 1 прямой: ");
            double b2 = Input("1 точка 2 прямой: ");
            double k2 = Input("2 точка 2 прямой: ");
            double x;
            if (b1 == b2)
            {
                x = 0;
            }
            else
            {
                x = (b1 - b2)/(k2 - k1);
            }

            double y1 = (k1 * x) + b1;
            double y2 = (k2 * x) + b2;
            Console.WriteLine($"y1 = {y1}, y2 = {y2}");
            if (y1 == y2)
            {
                Math.Round(y1, 2);
                Math.Round(x, 2);
                Console.WriteLine($"Точки пересечения прямых - x = {x}, y = {y1}");
            }
            else
            {
                Console.WriteLine("прямые параллельны");
            }
        }
        int tasks = Input("Введите номер задачи (41, 43): ");
        switch (tasks)
        {
            case 41:
                Task41();
                break;
            case 43:
                Task43();
                break;
            default:
                break;
        }

    }
}

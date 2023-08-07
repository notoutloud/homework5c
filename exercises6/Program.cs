namespace exercises6;

class Program
{
    static void Main(string[] args)
    {
        int Input(string text)
        {
            Console.Write(text);
            return Convert.ToInt32(Console.ReadLine());
        }

        void Task64()
        {
            void Recursion1(int counter, int number)
            {
                if (counter > number) return;
                if (counter % 3 == 0)
                {
                    Console.WriteLine(counter);
                }
                Recursion1(counter + 1, number);
            }

            int m = Input("Введите первое число: ");
            int n = Input("введите второе число: ");
            Recursion1(m, n);
        }

        void Task66()
        {
            int Recursion66(int counter, int number, int sum = 0)
            {
                if (counter > number)
                {
                    return sum;
                }
                sum = sum + counter;
                return Recursion66(counter + 1, number, sum);
            }
            int m = Input("Введите первое число: ");
            int n = Input("введите второе число: ");
            int sum = Recursion66(m, n);
            Console.WriteLine($"сумма всех натуральных цифр = {sum}");

        }

        void Task68()
        {
            int Recursion68(int m, int n)
            {
                if(m == 0) return n + 1;
                else if (n == 0) return Recursion68(m-1, 1);
                else return Recursion68(m-1, Recursion68(m, n-1));
            }
            int m = Input("Введите первое значение: ");
            int n = Input("введите второе значение: ");
            int func = Recursion68(m, n);
            Console.WriteLine(func);
        }

        int tasks = Input("Введите номер задачи (64, 66, 68): ");
        switch (tasks)
        {
            case 64:
                Task64();
                break;
            case 66:
                Task66();
                break;
            case 68:
                Task68();
                break;
            default:
                break;
        }
    }
}


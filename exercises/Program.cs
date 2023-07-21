namespace exercises;

class Program
{
    static void Main(string[] args)
    {
        int Input(string text)
        {
            Console.Write(text);
            return Convert.ToInt32(Console.ReadLine());
        }


        void Task34(){
            void FillArray(int[] array)
            {

                Random rnd = new Random();
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = rnd.Next(100, 1000);
                }
            }

            void Print(int[] array)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write($"{array[i]}  ");
                }
                Console.WriteLine();
            }

            int size = 5;
            int[] num = new int[size];
            FillArray(num);
            Print(num);
            int sum = 0;
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] % 2 == 0)
                {
                    sum++;
                }

            }
            Console.WriteLine($"Кол-во четных чисел в массиве = {sum}");
        }
        void Task36()
        {
            void FillArray(int[] array)
            {

                Random rnd = new Random();
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = rnd.Next(-100, 101);
                }
            }

            void Print(int[] array)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write($"{array[i]}  ");
                }
                Console.WriteLine();
            }


            int size = 4;
            int[] num = new int[size];
            int sum = 0;
            FillArray(num);
            Print(num);
            for(int i = 0; i < num.Length;i++){
                if (i % 2 > 0){
                    sum = num[i] + sum;
                }
            }
            Console.WriteLine($"Сумма чисел с нечет. индексом = {sum}");
        }
        void Task38(){
            void FillArray(double[] array)
            {

                Random rnd = new Random();
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = Convert.ToDouble(rnd.Next(-10000, 10000)/100.0);
                }
            }

            void Print(double[] array)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write($"{array[i]}  ");
                }
                Console.WriteLine();
            }

            int size = 4;
            double[] num = new double[size];
            double max = 0;
            double min = 0;
            FillArray(num);
            Print(num);
            for (int i = 0; i < num.Length; i++){
                if (num[i] > max){
                    max = num[i];
                }
                if (num[i] < min){
                    min = num[i];
                }
            }
            double dif = max - min;
            Console.WriteLine($"разница между макс и мин = {dif}");
        }


        int tasks = Input("Введите номер задачи (34, 36, 38): ");
        switch (tasks)
        {
            case 34:
                Task34();
                break;
            case 36:
                Task36();
                break;
            case 38:
                Task38();
                break;
            default:
                break;
        }
    }
}
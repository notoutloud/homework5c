namespace exercises4;

class Program
{
    static void Main(string[] args)
    {
        int Input(string text)
        {
            Console.Write(text);
            return Convert.ToInt32(Console.ReadLine());
        }

        void PrintArray(int[,] matr)
        {
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    Console.Write($"{matr[i, j]}\t ");
                }
                Console.WriteLine();
            }
        }

        void FillArray(int[,] matr)
        {
            Random rnd = new Random();
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    matr[i, j] = rnd.Next(1, 10);
                }
            }
        }

        void FillArrayDouble(double[,] matr, int minValue = -9, int maxValue = 9)
        {
            maxValue++;
            Random rnd = new Random();
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    //(0, 1)
                    //(0, 1)*10 => (0, 10)
                    matr[i, j] = Math.Round(rnd.NextDouble() * (maxValue - minValue) + minValue, 1);
                }
            }
        }

        void PrintArrayDouble(double[,] matr)
        {
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    Console.Write($"{matr[i, j]}\t ");
                }
                Console.WriteLine();
            }
        }




        void Task50(){
            int i = 3;
            int j = 4;
            int[,] matr = new int[i, j];
            FillArray(matr);
            PrintArray(matr);
            int raws = Input("введите номер строки нужного элемента: ");
            int colowns = Input("введите номер столбца нужного элемента: ");
            if (raws < i && colowns < j){
                Console.WriteLine($"Эл-т = {matr[raws, colowns]} ");
            }
            else{
                Console.WriteLine("Такого эл-та нет");
            }
        }

        void Task52(){
            int i = 3;
            int j = 4;
            double sum = 0;
            int[,] matr = new int[i, j];
            FillArray(matr);
            PrintArray(matr);
            for (j = 0; j < matr.GetLength(1); j++){
                sum = 0;
                for (i = 0; i < matr.GetLength(0); i++){
                    sum = sum + matr[i, j];
                }
                sum = sum / i;
                sum = Math.Round(sum, 2);
                Console.WriteLine($"Среднее арифметическое в {j} стобце будет равняться = {sum} ");
            }
        }

        void Task47(){
            int n = 3;
            int m = 4;
            double[,] matr = new double [n, m];
            FillArrayDouble(matr);
            PrintArrayDouble(matr);

        }







        int tasks = Input("Введите номер задачи (47, 50, 52): ");
        switch (tasks){
            case 50:
                Task50();
                break;
            case 52:
                Task52();
                break;
            case 47:
                Task47();
                break;
            default:
                break;
        }
    }
}

namespace exercises5;

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

        void Task54()
        {
            int rows = 4;
            int cols = 4;
            int[,] matr = new int[rows, cols];
            FillArray(matr);
            PrintArray(matr);
            Console.WriteLine();
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                for (int k = 0; k < matr.GetLength(1) - 1; k++)
                {
                    int maxpos = k;
                    for (int j = k + 1; j < cols; j++)
                    {
                        if (matr[i, j] > matr[i, maxpos])
                        {
                            maxpos = j;
                        }
                        int tempor = matr[i, k];
                        matr[i, k] = matr[i, maxpos];
                        matr[i, maxpos] = tempor;
                    }
                }
            }
            PrintArray(matr);
        }

        void Task56()
        {
            int rows = 4;
            int cols = 5;
            int[,] matr = new int[rows, cols];
            int sum = 0;
            int min = 40;
            int minind = 0;
            FillArray(matr);
            PrintArray(matr);
            Console.WriteLine();
            for (rows = 0; rows < matr.GetLength(0); rows++)
            {
                sum = 0;
                for (cols = 0; cols < matr.GetLength(1); cols++)
                {
                    sum = sum + matr[rows, cols];
                }
                if (sum < min)
                {
                    min = sum;
                    minind = rows;
                }
            }
            Console.WriteLine($"строка {minind} с наименьшей суммой элементов = {min}");
        }


        void Task58()
        {
            int rows = 4;
            int cols = 4;
            int[,] matr = new int[rows, cols];
            int counter = 1;
            int startCol = 0;
            int endCol = rows - 1;
            int startRow = 0;
            int endRow = cols - 1;
            while (startCol <= endCol && startRow <= endRow)
            {
                for (int i = startCol; i <= endCol; i++)
                {
                    matr[startRow, i] = counter;
                    counter++;
                }
                startRow++;
                for (int j = startRow; j <= endRow; j++)
                {
                    matr[j, endCol] = counter;
                    counter++;
                }
                endCol--;
                for (int i = endCol; i >= startCol; i--)
                {
                    matr[endRow, i] = counter;
                    counter++;
                }
                endRow--;
                for (int j = endRow; j >= startRow; j--)
                {
                    matr[j, startCol] = counter;
                    counter++;
                }
                startCol++;

            }
            PrintArray(matr);





        }


        int tasks = Input("Введите номер задачи (54, 56, 58): ");
        switch (tasks)
        {
            case 54:
                Task54();
                break;
            case 56:
                Task56();
                break;
            case 58:
                Task58();
                break;
            default:
                break;
        }
    }
}

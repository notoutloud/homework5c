namespace exercises;

class Program
{
    static void Main(string[] args)
    {
        void FillArray(int[] array)
            {
                Random rnd = new Random();
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = rnd.Next(-9, 10);
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
            
    }
}

namespace exercises;

class Program
{
    static void Main(string[] args)
    {
        int Input(string text){
            Console.Write(text);
            return Convert.ToInt32(Console.ReadLine());
        }

        void FillArray(int[] array){

                Random rnd = new Random();
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = rnd.Next(100, 1000);
                }
            }

        void Print(int[] array){
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write($"{array[i]}  ");
                }
                Console.WriteLine();
            }
        void Task34(){
                int size = 5;
                
            }
    }
}

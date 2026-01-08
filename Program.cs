namespace ConsoleAppF1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Diák neve: Farkas Márk");
            Console.WriteLine("1. feladat");

            Random rnd = new Random();

            int intervalNum = rnd.Next(10,31) * 3;

            Console.WriteLine(intervalNum);


            // Test #1
            //for (int i = 0; i < 100; i++)
            //{
            //    Console.WriteLine(rnd.Next(10, 31) * 3);
            //}
        }
    }
}

using System;

namespace TempConvert
{
    public class Program
    {
        float temperatura = Convert.ToInt32(Console.ReadLine());
        private static void Main(string[] args)
        {
            Console.Write("Input Temperature Value: ");
            float temperatura = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input Unity of Origin (C for Celciu and F for Farrenheit): ");
            string unidadeOrigem = Console.ReadLine().ToUpper();
        }
    }
}

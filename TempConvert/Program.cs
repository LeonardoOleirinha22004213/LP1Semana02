using System;

namespace TempConvert
{
    public class Program
    {
        
        private static void Main(string[] args)
        {
            Console.Write("Input Temperature Value: ");
            double temperatura = double.Parse(Console.ReadLine());
            Console.Write("Input Unity of Origin (C for Celciu and F for Farrenheit): ");
            string unidadeOrigem = Console.ReadLine().ToUpper();

            double formula;

           switch (unidadeOrigem)
            {
                case "C":
                formula = temperatura * 1.8 + 32;
                Console.WriteLine(temperatura + " " + unidadeOrigem + " = " + formula + " F");
                break;

                case "F":
                formula = (temperatura - 32) / 1.8;
                Console.WriteLine(temperatura + " " + unidadeOrigem + " = " + formula + " C");
                break;

                default:
                Console.WriteLine("Invalid Unit");
                return;


            }
        }
    }
}

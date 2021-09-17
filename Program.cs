using System;

namespace GrausCF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conversor de temperaturas");

            Console.WriteLine();

            Console.Write("Digite os graus(°C): ");
            string cValor = Console.ReadLine();
            double cNumero = Double.Parse(cValor);

            double fValor = cNumero*1.8+32;

            Console.WriteLine();

            Console.WriteLine("°C = " + cNumero);
            Console.WriteLine(cNumero + "°C é equivalente a " + fValor + "°F");
        }
    }
}

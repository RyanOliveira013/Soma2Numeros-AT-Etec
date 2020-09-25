using System;

namespace Soma2Numeros_AT_Etec
{
    class Program
    {
        static void Main(string[] args)
        {
            int PrimeiroNumero;
            int SegundoNumero;
            int Resultado;

            Console.Write("1o. numero: ");
            PrimeiroNumero = Convert.ToInt32(Console.ReadLine());

            Console.Write("2o. numero: ");
            SegundoNumero = Convert.ToInt32(Console.ReadLine());
            
            Resultado = PrimeiroNumero + SegundoNumero;

            Console.WriteLine($"O Resultado e {Resultado} ");
        }
    }
}

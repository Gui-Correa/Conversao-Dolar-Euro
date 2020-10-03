using System;

namespace Exercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {
            double r, d, e, conversao1, conversao2;
            Console.WriteLine("Digite um valor em reais: ");
            r = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a cotação do dolar: ");
            d = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a cotação do Euro: ");
            e = Convert.ToDouble(Console.ReadLine());

            conversao1 = r * d;
            conversao2 = r * e;

            Console.WriteLine("O valor da converão entre reais e dolar é: " + conversao1);
            Console.WriteLine("O valor da converão entre reais e euro é: " + conversao2);

            Console.ReadKey();







        }
    }
}

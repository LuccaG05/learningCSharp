using System;

namespace Ex_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor do litro de Etanol: ");
            double valorEtanol = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o consumo de Etanol: ");
            double consumoEtanol = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor do litro de Gasolina: ");
            double valorGasolina = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o consumo de Gasolina: ");
            double consumoGasolina = Convert.ToDouble(Console.ReadLine());

            double custoTotalEtanol = valorEtanol / consumoEtanol;
            double custoTotalGasolina = valorGasolina / consumoGasolina;

            if (custoTotalEtanol < custoTotalGasolina)
            {
                Console.WriteLine("Melhor opção: Etanol");
            }
            else
            {
                Console.WriteLine("Melhor opção: Gasolina");
            }
        }
    }
}

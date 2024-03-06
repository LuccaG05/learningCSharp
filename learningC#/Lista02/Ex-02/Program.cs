using System.Net;
using System.Runtime.ConstrainedExecution;

namespace Ex_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o peso da nota 1: ");
            double peso1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o peso da nota 2: ");
            double peso2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a nota 1: ");
            double nota1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a nota 2: ");
            double nota2 = Convert.ToDouble(Console.ReadLine());

            double calculoPeso1 = peso1 * nota1 / 100;
            double calculoPeso2 = peso2 * nota2 / 100;

            double resultado = calculoPeso1 + calculoPeso2;
            string status = "";


            if (peso1 + peso2 != 100) {
                Console.WriteLine("“Pesos inválidos. A soma dos pesos deve ser de 100%");
                return;
            }

            if (resultado >= 7)
            {
                status = "Aprovado";
            }
            else if (resultado < 7 && resultado >= 4)
            {
                status = "Exame";
            }
            else
            {
                status = "Reprovado";
            }


            Console.WriteLine($"Média: {resultado:f1} - {status}");
        }
    }
}

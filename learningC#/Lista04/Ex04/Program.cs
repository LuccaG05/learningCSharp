namespace Ex04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*4. Implemente uma calculadora fatorial. O usuário deve informar o
            número a ser calculado e o programa deve calcular o número fatorial
            daquele número e no final exibir o número que foi calculado e o
            resultado final.
            Exemplo
            Entrada: “5”
            Saída: “5! = 120”*/

            Console.WriteLine("Calculadora de Fatorial\n");
            Console.Write("Digite um numero a ser calculado: ");

            int numero = Convert.ToInt32(Console.ReadLine());

            Console.Write($"Fatorial de {numero}: ");

            int calculo = 1;

            while (numero > 0)
            {
                if (numero != 1)
                    Console.Write($"{numero} x ");
                else
                    Console.Write($"{numero} = ");

                calculo = calculo * numero;
                numero--;
            }

            Console.WriteLine(calculo);
        }
    }
}
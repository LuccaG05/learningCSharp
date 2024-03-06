using System;

namespace Ex_02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*2. Incremente o programa anterior, de forma a identificar a menor e a
            maior idade.
            Exemplo
            Saída: “Média: 32,2 | Mais novo: 13 / Mais velho: 54”*/

            Random rnd = new Random();

            int[] idades = new int[5];
            int soma = 0;
            idades[0] = rnd.Next(120);
            int maisVelho = idades[0];
            int maisNovo = idades[0]; 

            soma = idades[0];
            Console.WriteLine($"Idade 1: {idades[0]}");

            for (int i = 1; i < idades.Length; i++)
            {
                idades[i] = rnd.Next(120);
                soma = idades[i] + soma;
                Console.WriteLine($"Idade {i + 1}: {idades[i]}");
            }

            foreach (int i in idades)
            {
                if (i < maisNovo)
                {
                    maisNovo = i;
                }
                if (i > maisVelho)
                {
                    maisVelho = i;
                }
            }
            int media = soma / idades.Length;

            Console.WriteLine($"\nA média das idades é de {media}");
            Console.WriteLine($"\nMais velho tem: {maisVelho} anos");
            Console.WriteLine($"Mais novo tem: {maisNovo} anos");
        }
    }
}
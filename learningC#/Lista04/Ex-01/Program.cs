namespace Ex_01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*1. Implemente um programa que leia a idade de 5 usuários e calcule a
            média de idade (a idade máxima deve ser 120*/

            Random rnd = new Random();

            int[] idades = new int [5];
            int soma = 0;
            
            for (int i = 0; i < idades.Length; i++)
            {
                idades[i] = rnd.Next(120);
                soma = idades[i] + soma;
                Console.WriteLine($"Idade {i + 1}: {idades[i]}");
            }

            int media = soma / idades.Length;

            Console.WriteLine($"A média das idades é de {media}");
        }
    }
}

namespace Ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {/*1. Implemente um programa que gere 50 idades aleatórias e calcule a
            média de idade.
          */
            Random rnd = new Random();
            int[] idades = new int[50];

            for (int i = 0; i < idades.Length; i++)
            {
                idades[i] = rnd.Next(120);
            }

            int soma = idades.Sum();
            double media = idades.Average();


            foreach (int idade in idades)
            {
                Console.Write(idade + " ");
            }
            
            Console.WriteLine($"\n\nA média das idades é de: {media}");
        }
    }
}

namespace Ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*2. Incremente o programa anterior, de forma a identificar a menor e a
            maior idade.
            */
            Random rnd = new Random();
            int[] idades = new int[50];

            for (int i = 0; i < idades.Length; i++)
            {
                idades[i] = rnd.Next(120);
            }

            int soma = idades.Sum();
            double media = idades.Average();
            int maiorIdade = idades.Max();
            int menorIdade = idades.Min();

            foreach (int idade in idades)
            {
                Console.Write(idade + " ");
            }

            Console.WriteLine($"\n\nMenor idade: {menorIdade}\nMaior idade: {maiorIdade}");
            Console.WriteLine($"A média das idades é de: {media}");
        }
    }
}

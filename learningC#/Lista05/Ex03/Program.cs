namespace Ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*3. Incremente o programa anterior, de forma a ordenar os usuários por
            idade (do mais novo para o mais velho)
            */
            Random rnd = new Random();
            int[] idades = new int[50];

            for (int i = 0; i < idades.Length; i++)
            {
                idades[i] = rnd.Next(120);
            }

            Array.Sort(idades);

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

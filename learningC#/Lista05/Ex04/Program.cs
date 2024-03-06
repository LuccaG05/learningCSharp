namespace Ex04
{
    internal class Program
    {
        static void Main(string[] args)
        {/*4. Incremente o programa anterior, de forma a exibir os usuários de
            acordo com a decisão do usuário: do mais novo para o mais velho ou do
            mais velho para o mais novo.*/

            Random rnd = new Random();
            int[] idades = new int[50];

            for (int i = 0; i < idades.Length; i++)
            {
                idades[i] = rnd.Next(120);
            }
            Console.Write("Qual ordem? Mais novo primeiro: C | Mais velho primeiro: D: ");
            string decisao = Console.ReadLine().ToLower();

            switch (decisao)
            {
                case "c": Array.Sort(idades); break;
                case "d":
                    Array.Sort(idades);
                    Array.Reverse(idades); break;
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

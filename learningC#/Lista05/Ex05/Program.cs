namespace Ex05
{
    internal class Program
    {
        /*5. Incremente o programa anterior, de forma a calcular quantos usuários
        são mais velhos que a média e quantos usuários são mais novos que a
        média. O programa deve rodar dentro do laço de repetição o mínimo de
        vezes possível.
        */
        static void Main(string[] args)
        {
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

            int maisNovosQueMedia = 0;
            int maisVelhosQueMedia = 0;

            foreach (int idade in idades)
            {
                if (idade > media)
                { 
                    maisVelhosQueMedia++;
                }
                else if (idade < media)
                {
                    maisNovosQueMedia++;
                }
                Console.Write(idade + " ");
            }

            Console.WriteLine($"\n\nMenor idade: {menorIdade}\nMaior idade: {maiorIdade}");
            Console.WriteLine($"A média das idades é de: {media}");
            Console.WriteLine($"Quantidade de idades acima da média: {maisVelhosQueMedia} | Abaixo da média: {maisNovosQueMedia}");
        }
    }
}

namespace Ex_03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*3. Incremente o programa anterior, de forma a calcular quantos usuários
            são mais velhos que a média e quantos usuários são mais novos que a
            média
            Exemplo
            Entrada: “20”, “54”, “29”, “13”, “45”
            Saída: “
            Média: 32,2 | Mais novo: 13 / Mais velho: 54
            Acima da média: 2 / Abaixo da média: 3”*/

            Random rnd = new Random();

            int[] idades = new int[5];
            int soma = 0;
            idades[0] = rnd.Next(120);
            int maisVelho = idades[0];
            int maisNovo = idades[0];

            for (int i = 0; i < idades.Length; i++)
            {
                idades[i] = rnd.Next(120);
                soma = idades[i] + soma;
                Console.WriteLine($"Idade {i + 1}: {idades[i]}");
            }

            int media = soma / idades.Length;
            int acimaDaMedia = 0;
            int abaixoDaMedia = 0;

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
                if (i > media)
                {
                    acimaDaMedia++;
                }
                if (i < media)
                {
                    abaixoDaMedia++;
                }
            }

            Console.WriteLine($"\nA média das idades é de {media}");
            Console.WriteLine($"Acima da média: {acimaDaMedia} | Abaixo da média: {abaixoDaMedia}");
            Console.WriteLine($"\nMais velho tem: {maisVelho} anos");
            Console.WriteLine($"Mais novo tem: {maisNovo} anos");
        }
    }
}

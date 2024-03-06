namespace Ex07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*7. Implemente um programa que conte o número de cada uma das
            vogais em uma frase informada pelo usuário.
            Exemplo
            Entrada: “Sexta-feira, dia de programar!!! I love ADS”
            Saída: “A: 6 / E: 4 / I: 3 / O: 2 / U: 0””
            */

            Console.Write("Escreva uma frase: ");
            string frase = Console.ReadLine();

            int vogalA = 0;
            int vogalE = 0;
            int vogalI = 0;
            int vogalO = 0;
            int vogalU = 0;


            for (int i = 0; i < frase.Length; i++)
            {

                char letra = char.ToLower(frase[i]);

                switch (letra)
                {
                    case 'a': vogalA++; break;
                    case 'e': case 'é': vogalE++; break;
                    case 'i': vogalI++; break;
                    case 'o': vogalO++; break;
                    case 'u': vogalU++; break;
                }
            }

            Console.WriteLine($"Saída: \"A: {vogalA} / E: {vogalE} / I: {vogalI} / O: {vogalO} / U: {vogalU}\"");
        }
    }
}

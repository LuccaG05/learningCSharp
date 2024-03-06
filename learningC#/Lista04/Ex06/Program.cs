namespace Ex06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*6. Implemente um programa que leia o nome do usuário e exiba este
            nome escrito de trás para frente.
            */

            Console.Write("Escreva seu nome: ");
            string nome = Console.ReadLine();

            for (int i = nome.Length - 1; i >= 0; i--)
            {
                Console.Write(nome[i]);
            }
        }
    }
}

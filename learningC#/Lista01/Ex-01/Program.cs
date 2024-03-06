namespace Ex_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a nota 1: ");
            double nota1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a nota 2: ");
            double nota2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Média: {(nota1 + nota2) / 2}");
        }
    }
}

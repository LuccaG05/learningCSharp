namespace Ex_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o peso da nota 1: ");
            double peso1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o peso da nota 2: ");
            double peso2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a nota 1: ");
            double nota1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a nota 2: ");
            double nota2 = Convert.ToDouble(Console.ReadLine());

            double calculoPeso1 = peso1 * nota1 / 100;
            double calculoPeso2 = peso2 * nota2 / 100;
            
            double resultado = calculoPeso1 + calculoPeso2;

            Console.WriteLine($"Média: {resultado}");
        }
    }
}

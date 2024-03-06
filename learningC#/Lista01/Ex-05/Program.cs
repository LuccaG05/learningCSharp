namespace Ex_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome do produto 1: ");
            string produto1 = Console.ReadLine();

            Console.WriteLine("Digite o valor do produto 1: ");
            double valor1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a quantidade do 1 produto: ");
            int quantidade1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o nome do produto 2: ");
            string produto2 = Console.ReadLine();

            Console.WriteLine("Digite o valor do produto 2: ");
            double valor2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a quantidade do 2 produto: ");
            int quantidade2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o nome do produto 3: ");
            string produto3 = Console.ReadLine();

            Console.WriteLine("Digite o valor do produto 3: ");
            double valor3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a quantidade do 3 produto: ");
            int quantidade3 = Convert.ToInt32(Console.ReadLine());

            double totalCompra1 = valor1 * quantidade1;
            double totalCompra2 = valor2 * quantidade2;
            double totalCompra3 = valor3 * quantidade3;

            double totalDaCompra = (valor1 * quantidade1) + (valor2 * quantidade2) + (valor3 * quantidade3);

            Console.WriteLine($"Total: R$ {totalDaCompra:f2}\n\t- {quantidade1}x {produto1} - R$ {totalCompra1:f2}\n\t- {quantidade2}x {produto2} - R$ {totalCompra2:f2}\n\t- {quantidade3}x {produto3} - R$ {totalCompra3:f2}");
        }
    }
}
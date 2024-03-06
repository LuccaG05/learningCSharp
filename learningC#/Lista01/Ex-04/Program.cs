namespace Ex_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome do produto: ");
            string produto = Console.ReadLine();

            Console.WriteLine("Digite o valor do produto: ");
            double valor = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a quantidade: ");
            int quantidade = Convert.ToInt32(Console.ReadLine());


            double totalDaCompra = valor * quantidade;

            Console.WriteLine($"Total: R$ {totalDaCompra:f2}\n\t- {quantidade}x {produto}");
            
            //Outra forma de fazer
            Console.Write("Total: ");
            Console.WriteLine(totalDaCompra.ToString("C", CultureInfo.CurrentCulture));
            Console.WriteLine($"- {quantidade}x {produto}");
        }
    }
}

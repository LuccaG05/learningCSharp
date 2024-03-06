namespace Ex_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o nome do produto 1: ");
            string produto1 = Console.ReadLine();

            Console.Write("Digite o valor do produto 1: ");
            double valor1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a quantidade do 1 produto: ");
            int quantidade1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o nome do produto 2: ");
            string produto2 = Console.ReadLine();

            Console.Write("Digite o valor do produto 2: ");
            double valor2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a quantidade do 2 produto: ");
            int quantidade2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o nome do produto 3: ");
            string produto3 = Console.ReadLine();

            Console.Write("Digite o valor do produto 3: ");
            double valor3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a quantidade do 3 produto: ");
            int quantidade3 = Convert.ToInt32(Console.ReadLine());

            double totalCompra1 = valor1 * quantidade1;
            double totalCompra2 = valor2 * quantidade2;
            double totalCompra3 = valor3 * quantidade3;

            double totalDaCompra = totalCompra1 + totalCompra2 + totalCompra3;

            Console.WriteLine($"Total: R$ {totalDaCompra:f2}\n\t- {quantidade1}x {produto1} - R$ {totalCompra1:f2}\n\t- {quantidade2}x {produto2} - R$ {totalCompra2:f2}\n\t- {quantidade3}x {produto3} - R$ {totalCompra3:f2}");

            Console.Write("Forma de pagamento (1 - PIX, 2 - DINHEIRO, 3 - CARTÃO DE CRÉDITO/DÉBITO): ");
            string formaPagamento = Console.ReadLine();

            double valorFinal = totalDaCompra;
            if (formaPagamento == "1")
            {
                valorFinal *= 0.93;
            }
            else if (formaPagamento == "2")
            {
                valorFinal *= 0.95;
            }
            else if (formaPagamento == "3")
            {
                Console.Write("Número de parcelas: ");
                int numParcelas = Convert.ToInt32(Console.ReadLine());
                if (numParcelas > 5 && numParcelas <= 10)
                {
                    valorFinal *= 1.05;
                }
                else if (numParcelas > 10)
                {
                    valorFinal *= 1.07;
                }
                if (numParcelas > 1)
                {
                    double valorParcela = valorFinal / numParcelas;
                    Console.WriteLine($"Valor final: R$ {valorFinal:f2} em {numParcelas} parcelas de R$ {valorParcela:f2}");
                }
            }
            else
            {
                Console.WriteLine("Forma de pagamento inválida.");
                return;
            }
            Console.WriteLine($"Valor final da compra: R$ {valorFinal:f2}");
        }
    }
}

namespace Ex_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor do Etanol: ");
            double valorEtanol = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor da Gasolina: ");
            double valorGasolina = Convert.ToDouble(Console.ReadLine());

            double calculo = valorGasolina * 0.70;

            if (valorEtanol < calculo)
            {
                Console.WriteLine("Melhor opção: Etanol");
            }
            else
            {
                Console.WriteLine("Melhor opção: Gasolina");
            }
        }
    }
}

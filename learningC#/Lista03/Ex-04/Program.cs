namespace Ex_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor do litro de Etanol: ");
            double valorEtanol = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o consumo urbano de Etanol: ");
            double consumoUrbanoEtanol = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o consumo rodoviário de Etanol: ");
            double consumoRodoviarioEtanol = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor do litro de Gasolina: ");
            double valorGasolina = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o consumo urbano de Gasolina: ");
            double consumoUrbanoGasolina = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o consumo rodoviário de Gasolina: ");
            double consumoRodoviarioGasolina = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a distância em trecho urbano: ");
            double distanciaUrbana = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a distância em trecho rodoviário: ");
            double distanciaRodoviaria = Convert.ToDouble(Console.ReadLine());

            double custoUrbanoEtanol = (distanciaUrbana / consumoUrbanoEtanol) * valorEtanol;
            double custoRodoviarioEtanol = (distanciaRodoviaria / consumoRodoviarioEtanol) * valorEtanol;

            double custoUrbanoGasolina = (distanciaUrbana / consumoUrbanoGasolina) * valorGasolina;
            double custoRodoviarioGasolina = (distanciaRodoviaria / consumoRodoviarioGasolina) * valorGasolina;

            double economiaEtanol = custoUrbanoEtanol + custoRodoviarioEtanol - custoUrbanoGasolina - custoRodoviarioGasolina;
            string melhorCombustivel;
            if (economiaEtanol < 0)
            {
                melhorCombustivel = "Etanol";
                economiaEtanol *= -1;
            }
            else
            {
                melhorCombustivel = "Gasolina";
            }

            double economiaPercentual = (economiaEtanol / (custoUrbanoGasolina + custoRodoviarioGasolina)) * 100;

            Console.WriteLine($"Custo Etanol: R$ {custoUrbanoEtanol + custoRodoviarioEtanol:F2}");
            Console.WriteLine($"Custo Gasolina: R$ {custoUrbanoGasolina + custoRodoviarioGasolina:F2}");
            Console.WriteLine($"Melhor combustível: {melhorCombustivel} - Economia de R$ {economiaEtanol:F2} ({economiaPercentual:F2}%)");
        }
    }
}


namespace Ex_08
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.Write("Digite o valor do Etanol: ");
                double valorEtanol = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite o consumo urbano de Etanol: ");
                double consumoUrbanoEtanol = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite o consumo rodoviário de Etanol: ");
                double consumoRodoviarioEtanol = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite o valor da Gasolina: ");
                double valorGasolina = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite o consumo urbano de Gasolina: ");
                double consumoUrbanoGasolina = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite o consumo rodoviário de Gasolina: ");
                double consumoRodoviarioGasolina = Convert.ToDouble(Console.ReadLine());

                double custoUrbanoEtanol = valorEtanol / consumoUrbanoEtanol;
                double custoRodoviarioEtanol = valorEtanol / consumoRodoviarioEtanol;

                double custoUrbanoGasolina = valorGasolina / consumoUrbanoGasolina;
                double custoRodoviarioGasolina = valorGasolina / consumoRodoviarioGasolina;

                string melhorCombustivelUrbano;
                if (custoUrbanoEtanol < custoUrbanoGasolina)
                {
                    melhorCombustivelUrbano = "Etanol";
                }
                else
                {
                    melhorCombustivelUrbano = "Gasolina";
                }

                string melhorCombustivelRodoviario;
                if (custoRodoviarioEtanol < custoRodoviarioGasolina)
                {
                    melhorCombustivelRodoviario = "Etanol";
                }
                else
                {
                    melhorCombustivelRodoviario = "Gasolina";
                }

                Console.WriteLine($"Trajeto urbano - Etanol: R$ {custoUrbanoEtanol:f2} por KM / Gasolina: R$ {custoUrbanoGasolina:f2} por KM - Melhor: {melhorCombustivelUrbano}");
                Console.WriteLine($"Trajeto rodoviário - Etanol: R$ {custoRodoviarioEtanol:f2} por KM / Gasolina: R$ {custoRodoviarioGasolina:f2} por KM - Melhor: {melhorCombustivelRodoviario}");
            }
        }
    }


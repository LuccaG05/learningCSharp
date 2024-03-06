namespace Ex_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Valor total do financiamento: ");
            double valorFinanciamento = Convert.ToDouble(Console.ReadLine());

            Console.Write("Numero de Parcelas: ");
            int numeroDeParcelas = Convert.ToInt32(Console.ReadLine());

            Console.Write("Numero de parcelas pagas: ");
            int parcelasPagas = Convert.ToInt32(Console.ReadLine());

            double parcelaMensal = valorFinanciamento / numeroDeParcelas;

            double totalPago = parcelasPagas * parcelaMensal;

            double valorTotal = valorFinanciamento;

            double progresso = (totalPago * 100) / valorFinanciamento;

            double parcelasFaltantes = numeroDeParcelas - parcelasPagas;

            double valorAPagar = parcelasFaltantes * parcelaMensal;


            Console.WriteLine(@$"Resumo do Financiamento:
- Parcela mensal: R$ {parcelaMensal:f2}
- Valor total pago: R$ {totalPago:f2} | Valor a pagar: R$ {valorAPagar:f2}
- Valor total: {valorFinanciamento:f2}");

            Console.WriteLine($"- Progresso {parcelasPagas} / {numeroDeParcelas} ({progresso:f2}%) de parcelas pagas - {parcelasFaltantes} parcelas a pagar"); 
        }
    }
}

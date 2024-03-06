namespace Ex_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o 1º numero: ");
            double n1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o operador (\" + , - , * ou / \"): ");
            string operador = Console.ReadLine();

            Console.Write("Digite o 2º numero: ");
            double n2 = Convert.ToDouble(Console.ReadLine());

            double calculo;

            switch (operador)
            {
                case "+": calculo = n1 + n2; break;
                case "-": calculo = n1 - n2; break;
                case "*": calculo = n1 * n2; break;
                case "/": calculo = n1 / n2; break;
                default: Console.WriteLine("Informe um operador certo");
                    return;
            }
            Console.WriteLine($"Resultado: {calculo}");

        }
    }
}
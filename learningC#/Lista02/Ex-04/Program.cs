namespace Ex_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o terceiro número: ");
            double num3 = Convert.ToDouble(Console.ReadLine());

            if (num1 > num2 && num2 > num3)
            {
                Console.Write($"{num3} {num2} {num1}");
            }
            else if (num1 > num3 && num3 > num2)
            {
                Console.Write($"{num2} {num3} {num1}");
            }
            else if (num2 > num1 && num1 > num3)
            {
                Console.Write($"{num3} {num1} {num2}");
            }
            else if (num2 > num3 && num3 > num1)
            {
                Console.Write($"{num1} {num3} {num2}");
            }
            else if (num3 > num1 && num1 > num2)
            {
                Console.Write($"{num2} {num1} {num3}");
            }
            else if (num3 > num2 && num2 > num1)
            {
                Console.Write($"{num1} {num2} {num3}");
            }
            else
            {
                Console.Write("Nenhuma ordem correta.");
            }


        }
    }
}
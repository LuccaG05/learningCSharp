namespace Ex_01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite a nota 1: ");
            double nota1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a nota 2: ");
            double nota2 = Convert.ToDouble(Console.ReadLine());

            double calculo = (nota1 + nota2) / 2;
            string status = "";

            if (calculo >= 7)
            {
                status = "Aprovado";
                
            }
            else if (calculo < 7 && calculo >= 4)
            {
                status = "Exame";
                
            }
            else
            {
                status = "Reprovado";
                
            }

            Console.WriteLine($"Média: {calculo:f2} - {status}");
        }
    }
}

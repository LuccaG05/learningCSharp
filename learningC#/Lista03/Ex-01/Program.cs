namespace Ex_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um ano para verificar se é bissexto:");
            int ano = Convert.ToInt32(Console.ReadLine());

            if ((ano % 4 == 0 && ano % 100 != 0) || (ano % 400 == 0))
            {
                Console.WriteLine($"{ano} é bissexto.");
            }
            else
            {
                Console.WriteLine($"{ano} não é bissexto.");
            }
        }
    }
}

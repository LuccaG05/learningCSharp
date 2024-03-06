namespace Ex_06
{
    internal class Program
    {
        static void Main(string[] args)
        {

            const string nomeEmpresa = "Sociedade Codificadora ADS";
            Console.WriteLine(nomeEmpresa);

            Console.Write("Digite seu nome: ");
            string nomeUsuario = Console.ReadLine();


            Console.WriteLine($@"Olá {nomeUsuario}.
Nós da {nomeEmpresa} estamos felizes com sua visita!

Atenciosamente,
{nomeEmpresa}.");
        }
    }
}

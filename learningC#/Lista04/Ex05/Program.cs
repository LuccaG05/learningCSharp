namespace Ex05
{
    internal class Program
    {

        /*5. Implemente um programa que crie 2 listas com 5 elementos cada e
        preencha essas listas com números aleatórios (entre 1 e 10). Calcule a
        interseção entre duas listas. No final, o programa deve exibir as 3 listas
        (iniciais e interseção). Caso não haja interseção entre as listas, informar
        ao usuário.
        Exemplo
        Saída: “
        Lista 1: [5, 1, 2, 6 e 8]
        Lista 2: [1, 10, 6, 8 e 5]
        Interseção: [5, 1, 6 e 8]”
        Nota: A lista de interseção pode conter -1 nas posições que não for preenchida*/
        static void Main(string[] args)
        {
            Random rdn = new Random();

            int[] array1 = new int[5];
            int[] array2 = new int[5];

            Console.WriteLine("Array1:");
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = rdn.Next(10);
                Console.WriteLine(array1[i]);
            }

            Console.WriteLine("\nArray2:");
            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = rdn.Next(10);
                Console.WriteLine(array2[i]);
            }

            Console.WriteLine("\nInterseção: ");
            for (int i = 0; i < array1.Length; i++)
            {
                for (int j = 0; j < array2.Length; j++)
                {
                    if (array1[i] == array2[j])
                    {
                        Console.WriteLine(array1[i]);
                        array2[j] = int.MinValue;
                        break;
                    }
                }
            }
        }
    }
}

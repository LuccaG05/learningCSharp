namespace Ex06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*6. Implemente um programa que crie 2 listas com 10 elementos cada e
                preencha essas listas com números aleatórios (entre 1 e 20). Calcule a
                interseção entre duas listas. No final, o programa deve exibir as 3 listas
                (iniciais e interseção). Caso não haja interseção entre as listas, informar
                ao usuário. O terceiro array (array de interseção) não deve conter
                elementos vazios, mas deve ser do exato tamanho do número de
                elementos repetidos.*/


            // Criando as arrays e preenchendo com números aleatórios
            int[] array1 = new int[10];
            int[] array2 = new int[10];
            Random random = new Random();

            // Preenchendo e exibindo a primeira array
            Console.Write("Array 1: ");
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = random.Next(1, 21);
                Console.Write(array1[i] + " ");
            }

            // Preenchendo e exibindo a segunda array
            Console.Write("\nArray 2: ");
            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = random.Next(1, 21);
                Console.Write(array2[i] + " ");
            }

            // Calculando e exibindo a interseção
            Console.Write("\nInterseção: ");
            bool intersecaoEncontrada = false;
            for (int i = 0; i < array1.Length; i++)
            {
                for (int j = 0; j < array2.Length; j++)
                {
                    if (array1[i] == array2[j])
                    {
                        Console.Write(array1[i] + " ");
                        intersecaoEncontrada = true;
                        break;
                    }
                }
            }

            if (!intersecaoEncontrada)
            {
                Console.Write("Não há interseção entre as arrays.");
            }
        }
    }
}

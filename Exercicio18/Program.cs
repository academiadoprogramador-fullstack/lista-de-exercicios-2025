namespace Exercicio18
{
    internal class Program
    {
        // Escrever um algoritmo que gera e escreve os números ímpares entre 100 e 200.
        static void Main(string[] args)
        {
            for (int i = 101; i <= 199; i += 2)
            {
                Console.Write(i + " ");
            }

            Console.ReadLine();
        }
    }
}

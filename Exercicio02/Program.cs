namespace Exercicio02
{
    internal class Program
    {
        // Crie um programa para calcular o volume de um Cilindro
        // V = π . r² . h
        static void Main(string[] args)
        {
            double raio = 3.1;
            double altura = 10;

            double volume = Math.PI * Math.Pow(raio, 2) * altura;

            Console.WriteLine($"O volume do cilindro é: {volume} cm³.");

            Console.ReadLine();
        }
    }
}

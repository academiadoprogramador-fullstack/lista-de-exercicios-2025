namespace Exercicio06
{
    internal class Program
    {
        // Crie um programa para calcular a média harmônica das notas de um Aluno
        static void Main(string[] args)
        {
            double nota1, nota2, nota3, nota4;

            Console.WriteLine("Digite as quatro notas do aluno:");
            nota1 = Convert.ToDouble(Console.ReadLine());
            nota2 = Convert.ToDouble(Console.ReadLine());
            nota3 = Convert.ToDouble(Console.ReadLine());
            nota4 = Convert.ToDouble(Console.ReadLine());

            double mediaHarmonica = 4.0 / ((1.0 / nota1) + (1.0 / nota2) + (1.0 / nota3) + (1.0 / nota4));

            Console.WriteLine("A média harmônica das notas é: " + mediaHarmonica);

            Console.ReadLine();
        }
    }
}

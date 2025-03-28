﻿namespace Exercicio21
{
    internal class Program
    {
        // Escreva um algoritmo que leia um valor inicial A e imprima a sequência de valores do cálculo de A! e o seu
        // resultado.
        static void Main(string[] args)
        {
            int a, fatorial = 1;

            Console.Write("Digite um valor para A: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write(a + "! = ");

            for (int i = a; i >= 1; i--)
            {
                Console.Write(i + " ");
                fatorial *= i;

                if (i > 1)
                {
                    Console.Write("X ");
                }
            }

            Console.Write("= " + fatorial);

            Console.ReadLine();
        }
    }
}

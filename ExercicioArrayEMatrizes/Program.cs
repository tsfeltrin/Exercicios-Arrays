using System;

namespace ExercicioArrayEMatrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void NumerosPares()
            //Faça um programa que imprima todos os números pares até 100
            {
                for (int i = 0; i <= 100; i = i + 2)
                {                                        
                        Console.WriteLine(i);
                }
            }
            //NumerosPares();

            //Faça um programa que imprima todos os números ímpares que esteja entre 100 e 0, de forma inversa.
            void NumerosImpares()
            {
                for (int i = 100; i >= 1; i--)
                {
                    if (i % 2 != 0)
                    {
                    Console.WriteLine(i);
                    }
                }
            }
            //NumerosImpares();

            //Faça um programa que receba um array e imprima ele da forma inversa.
            //Exemplo:
            //Entrada:
            //[1, 2, 3, 4, 5]
            //Saída:
            //[5, 4, 3, 2, 1]

            void ArrayInverso()
            {
                int[] numeros = {1, 2, 3, 4, 5};
                for (int i = (numeros.Length - 1); i >= 0; i--)
                {
                    Console.WriteLine(numeros[i]);
                }
            }
            ArrayInverso();
        }
    }
}


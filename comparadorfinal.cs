using System;
//Henrique Feitosa, Eduardo Fonseca, Gabriel Evaristo Pimenta;
namespace ConsoleApp13
{
    internal class Program

    {
        static void Main(string[] args)
        {
           int n, m, pares = 0, impares = 0, j = 0, i = 0, g = 0, maioresm =0, menoresm = 0, iguaism = 0, maior=0, soma =0, media = 0;
            float menor = 10000000000000000000;
            Console.WriteLine("Insira a quantidade de numeros: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira um numero para ser comparado: ");
            m = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            while ( i <n)
            {
                Console.WriteLine("Insira um numero: ");
                v[i] = int.Parse(Console.ReadLine());
                i++;
            }
            while (j < n)
            {
                if (v[j] % 2 == 0)
                {
                    pares++;
                    
                }
                j++;
            }
            while (g < n)
            {
                if (v[g] % 2 == 1)
                {
                    impares++;

                }
                g++;
            }
            for (i = 0; i < n; i++) 
            {
                if (v[i]>m)
                {
                    maioresm++;
                }
               else if (v[i] < m)
                {
                    menoresm++;
                }
                else
                    iguaism++;

            }
            for (i = 0; i < n; i++)
            {
                if (v[i] > maior)
                maior = v[i];
            }
            for (i = 0; i < n; i++)
            {
                if (v[i] < menor)
                    menor = v[i];
            }
            for (i = 0; i < n; i++)
            {
               soma = soma + v[i];
            }

            media = soma / n;

            Console.WriteLine($" São pares: {pares}");
            Console.WriteLine($" São impares: {impares}");
            Console.WriteLine($" São maiores que {m}: {maioresm}");
            Console.WriteLine($" São menores que {m}: {menoresm}");
            Console.WriteLine($" São iguais a {m}: {iguaism}");
            Console.WriteLine($" o maior numero é: {maior}");
            Console.WriteLine($" o menor numero é: {menor}");
            Console.WriteLine($" A soma dos numeros: {soma}");
            Console.WriteLine($" A media dos numeros é: {media}");
        }
    }
}

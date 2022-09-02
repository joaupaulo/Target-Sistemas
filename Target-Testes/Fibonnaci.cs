using System;
using System.Linq;

namespace Target_Testes
{
    public class Fibonnaci
    {
        public static void FibonnaciSequencie()
        {
            Console.WriteLine($"Digite o 1 número da sequencia");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Digite o 2 número da sequencia");
            int numero2 = Convert.ToInt32(Console.ReadLine());
            int soma = 0;
            int[] ArrayFibbonaci;
            ArrayFibbonaci = new int[101];

            for (var i = 1; i <= 100; i++)
            {
                soma = numero1 + numero2;
                numero2 = numero1;
                numero1 = soma;
                ArrayFibbonaci[i] = soma;

                Console.WriteLine($"A sequencia é : {soma}");
            }

            if (ArrayFibbonaci.Contains(numero1) && ArrayFibbonaci.Contains(numero2))
            {
                Console.WriteLine($"O Número informado pertence a sequencia de fibonacci");
            }
            else
            {
                Console.WriteLine($"O Número informado não pertence a sequencia de fibonacci");
            }
        }
    }
}
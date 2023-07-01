using System;
using System.Globalization;

namespace questao01 {
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Entre com o estoque Mínimo:");
            int EstoqueMinimo = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o estoque Máximo:");
            int EstoqueMaximo = int.Parse(Console.ReadLine());

            Console.WriteLine("Estoque Máximo: " +EstoqueMaximo);
            Console.WriteLine("Estoque Mínumo: " +EstoqueMinimo);
            Console.WriteLine("Média do estoque: "+ (EstoqueMaximo + EstoqueMinimo) / 2);

        }
    }
}
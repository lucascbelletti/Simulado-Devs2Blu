using System;
using System.ComponentModel.Design;
using System.Linq.Expressions;
using System.ComponentModel.Design;
using System.Linq;
using System.ComponentModel;

class Program
{

    public static void Main(string[] args)
    {
        Console.WriteLine("Vamos escrever uma lista de números para depois ordená-la."); 
        List<int> lista = new List<int>();  
        for (int i = 0; i < 10; i++)
        {
            Console.Write("\nEscreva um número inteiro:");
            int numero = int.Parse(Console.ReadLine());
            lista.Add(numero);
        }

        Console.WriteLine(" ");
        lista.Sort();
        for (int i = 1; i <= lista.Count; i++) 
        {
            Console.WriteLine(lista[i-1]);            
        }

        Console.WriteLine("\nEsta foi a lista que você escreveu ordenada crescentemente");




        Console.ReadKey();

    }

}
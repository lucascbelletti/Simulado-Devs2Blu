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
        Console.WriteLine("Escreva uma palavra e o programa dírá se ela é um palindromo ou não");
        string palavra = Console.ReadLine();
        string pInvertida = new string(palavra.Reverse().ToArray());    
        if (palavra.Equals(pInvertida) == true)
        {
            Console.WriteLine("Essa palavra é um palíndromo");
        }

        else
        {
            Console.WriteLine("Essa palavra não é um palindromo");

        }







        Console.ReadKey();

    }

}
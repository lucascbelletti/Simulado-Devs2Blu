using System;
using System.ComponentModel.Design;
using System.Linq.Expressions;
using System.ComponentModel.Design;
using System.Linq;
using System.Xml;
using System.Globalization;

class Program
{

    public static void Main(string[] args)
    {

        Console.WriteLine("Bem vindo ao jogo da forca!!!");
        
        string[] palavras = { "abacate", "banana", "cachorro", "dado", "elefante", "futebol", "gato", "hipopótamo", "igreja", "jornal" };

        Random aleatorio = new Random();
        string palavra = palavras[aleatorio.Next(palavras.Length)];

        char[] palavraExibida = new char[palavra.Length];
        for (int i = 0; i < palavra.Length; i++)
        {
            palavraExibida[i] = '_';
        }

        bool acertouPalavra = false;
        while (acertouPalavra == false )
        {
            Console.WriteLine("\nAdivinhe a palavra:");
            Console.WriteLine(new string(palavraExibida));
            Console.Write("\nDigite uma letra: ");
            char letra = Console.ReadLine()[0];

            bool letraEncontrada = false;
            for (int i = 0; i < palavra.Length; i++)
            {
                if (palavra[i] == letra)
                {
                    palavraExibida[i] = letra;
                    letraEncontrada = true;
                }
            }

            if (letraEncontrada)
            {
                Console.WriteLine("A palavra tem essa letra!");
            }
            else
            {
                Console.WriteLine("A palavra não tem essa letra!");
                
            }

            if (new string(palavraExibida) == palavra)
            {
                acertouPalavra = true;
                Console.WriteLine("\nParabéns, você acertou a palavra!");
                Console.WriteLine($"Era '{palavra}'!");
            }
        }

        Console.ReadKey();


    }

}
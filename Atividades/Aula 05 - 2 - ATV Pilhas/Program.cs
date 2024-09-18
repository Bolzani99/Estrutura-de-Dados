using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Solicita a entrada do usuário
        Console.Write("Digite uma palavra: ");
        string palavra = Console.ReadLine();

        // Verifica se a palavra é um palíndromo
        if (IsPalindromo(palavra))
        {
            Console.WriteLine($"A palavra '{palavra}' é um palíndromo.");
        }
        else
        {
            Console.WriteLine($"A palavra '{palavra}' não é um palíndromo.");
        }
    }

    static bool IsPalindromo(string palavra)
    {
        // Cria uma pilha para armazenar os caracteres
        Stack<char> pilha = new Stack<char>();

        // Empilha todos os caracteres da palavra
        foreach (char c in palavra)
        {
            pilha.Push(c);
        }

        // Reconstrói a palavra a partir da pilha
        string palavraReversa = "";
        while (pilha.Count > 0)
        {
            palavraReversa += pilha.Pop();
        }

        // Compara a palavra original com a palavra reconstruída
        return palavra.Equals(palavraReversa, StringComparison.OrdinalIgnoreCase);
    }
}

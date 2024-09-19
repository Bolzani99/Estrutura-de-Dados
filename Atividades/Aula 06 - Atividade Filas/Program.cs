using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<string> chamados = new List<string>();
        while (true)
        {
            Console.WriteLine("1. Gerar Senha");
            Console.WriteLine("2. Fazer Chamado");
            Console.WriteLine("3. Listar Chamados");
            Console.WriteLine("4. Sair");
            Console.Write("Escolha uma opção: ");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    string senha = GerarSenha();
                    Console.WriteLine($"Senha gerada: {senha}");
                    break;

                case "2":
                    Console.Write("Digite a descrição do chamado: ");
                    string descricao = Console.ReadLine();
                    string chamado = $"{GerarSenha()} - {descricao}";
                    chamados.Add(chamado);
                    Console.WriteLine("Chamado registrado com sucesso!");
                    break;

                case "3":
                    Console.WriteLine("Chamados:");
                    foreach (var item in chamados)
                    {
                        Console.WriteLine(item);
                    }
                    break;

                case "4":
                    Console.WriteLine("Saindo...");
                    return;

                default:
                    Console.WriteLine("Opção inválida! Tente novamente.");
                    break;
            }
        }
    }

    static string GerarSenha()
    {
        Random random = new Random();
        string caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        char[] senha = new char[6]; // Senha de 6 caracteres

        for (int i = 0; i < senha.Length; i++)
        {
            senha[i] = caracteres[random.Next(caracteres.Length)];
        }

        return new string(senha);
    }
}

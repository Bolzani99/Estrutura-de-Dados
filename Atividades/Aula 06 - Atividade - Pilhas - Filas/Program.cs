﻿using System;
using System.Collections.Generic;
using System.Linq;

Console.Write("Digite o comprimento da senha: ");
int length = int.Parse(Console.ReadLine());

string password = GeneratedPassword(length);
Console.WriteLine($"Senha gerada: {password}");

static string GeneratedPassword(int length)
{
    const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()";
    Stack<char> passwordStack = new Stack<char>();

    Random random = new Random();

    for(int i = 0; i < length; i++)
    {
        char randomChar = chars[random.Next(chars.Length)];
        passwordStack.Push(randomChar);
    }

    char[] passwordArray = passwordStack.ToArray();
    Array.Reverse(passwordArray);

    return new string(passwordArray);
}
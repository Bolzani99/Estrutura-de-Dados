using System.Collections;

// Utilizando a Lista Simples;

ArrayList arrList = new();
arrList.Add(5);
arrList.Add("Joao");

// É possivel adicionar um conjunto de valores de uma so vez;

arrList.AddRange(new int[] {1,2,3});

// O metodo .Add() insere o valor ao final do vetor;

arrList.Insert(0, 15);

// Já o metodo insert, me permite incluir o valor desejado na posição especificada no primeiro parâmetro;
// Lendo valores da Lista;

object primeiro = arrList[0]!;
int quarto = (int)arrList[3]!;

//Percorrendo a Lista com foreach;

foreach(Object obj in arrList)
{
    Console.Write($" | {obj}"); 
}

// Obtendo o tamanho total da lista, quantos elementos tem;

int tamanho = arrList.Count;

// Oter a capacidade, quantos podem ser armazenados;

int capacidade = arrList.Capacity;

// Percorrendo no modo classico;

for( int i = 0; i < arrList.Count; i++)
{
    Console.WriteLine($" | {arrList[i]}");
}

// Recursos importantes da Lista;
// Verificar se um valor é contido na lista;

bool contemNome = arrList.Contains("Joao");
if(!contemNome)
{
    Console.WriteLine("Nome Joao não encontrado");
}

// Para saber o indice que contem o valor buscado;
// Neste caso se o valor existir na lista ele retorna o indice (numero inteiro);
// Caso o valor não existe na lista, retorna -1;

int indiceDoValor = arrList.IndexOf("Joao");
if(indiceDoValor >= 0)
{
    Console.WriteLine($"Joao esta em [{indiceDoValor}]");
}
else
{
    Console.WriteLine("É, realmente não tem.");
}

// É possivel tambem remover itens da lista;

arrList.Remove("Joao"); // Remove pelo valor;
arrList.RemoveAt(4); // Remove no indice;
arrList.RemoveRange(0,5); // O primeiro parametro é o indice, e o segundo é quantas casa apos o indice;
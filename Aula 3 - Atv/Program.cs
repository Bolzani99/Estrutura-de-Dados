
// Definir o tamanho dos vetores
const int tamanho = 100;

// Criar os vetores para armazenar números pares e ímpares
int[] pares = new int[tamanho];
int[] impares = new int[tamanho];

// Preencher os vetores com os primeiros 100 números pares e ímpares
for (int i = 0; i < tamanho; i++)
{
    pares[i] = 2 * i;
    impares[i] = 2 * i + 1;  
}

// Imprimir os números pares
Console.WriteLine("Números pares:");
for (int i = 0; i < tamanho; i++)
{
   Console.Write(pares[i] + " ");
}
Console.WriteLine();

// Imprimir os números ímpares
Console.WriteLine("Números ímpares:");
for (int i = 0; i < tamanho; i++)
{
    Console.Write(impares[i] + " ");
}
Console.WriteLine();

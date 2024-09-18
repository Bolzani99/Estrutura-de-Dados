// Basicamente as pilhas trabalham com 
// uma estrutura LIFO -> Last in Firt Out 
// Três métodos importantes:
// Push () -> Insere um elemento no topo da pilha
// pop () -> Removo um elemento do topo e o retorna
// peek () -> Retorna o elemento do topo sem removê-lo 

// Invertendo as bolas

Stack<char> Carcteres = new Stack<char>();
foreach(char c in "DARCY DA MONTANHA")
{
    Carcteres.Push(c);
}

//Desempilhando
string invertido = string.Empty;
while(Carcteres.Count > 0)
{
    invertido += Carcteres.Pop();
}

Console.WriteLine(invertido);


//atividade: Utilizando o conceito de pilha (stack<>) com os métodos pop() e push(), escreva um programa
//que leia uma entrada do usuário e identifique se a palavra informada é ou não e um PALÍNDROMO 

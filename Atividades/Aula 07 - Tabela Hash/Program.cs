// Exemplo de uma agenda telefônica 


using System.Collections;

Hashtable phoneBook = new Hashtable()
{
    // { "Chave", "Valor" },
    { "Silvio", "49-99830-0705" },
    { "Zoe", "49-2222-2222" },
    { "Jake", "49-1111-1111" },
};

// É possivel adicionar elementos de diversas formas, pelo proprio indice chave inexistente

phoneBook["Joao"] = "49-99918-8470";

//Ou pelo método add()

phoneBook.Add("Zo", "49-1111-2222");

//Entretando, a TabelaHash verifica se há duplicidade de chave e pode lançar uma Exception (excessão/erro)

try
{
    phoneBook.Add("Jake", "49-1111-1111");
}catch(Exception ex)
{
    Console.WriteLine($"Erro ao tentar incluir valor repetido.");
    Console.WriteLine(ex.Message);
}

//Percorrendo Itens da HashTable

Console.WriteLine("Agenda Telefônica:");
if(phoneBook.Count == 0)

    Console.WriteLine("A agenda está vazia.");
else
    foreach(DictionaryEntry entry in phoneBook)
        Console.WriteLine($"{entry.Key}:{entry.Value}");
    

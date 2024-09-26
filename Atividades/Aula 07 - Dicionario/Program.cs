// Diferente da TabelaHash, o Dictionary nos permite espificicar o tipo de dado que será utilizado nos pares 
// Kete -> Value 
// Isso nos forcene uma estrutura fortemente tipada 


using Aula_07__Dicionario;

Dictionary<string, string> dictionary = new Dictionary<string, string>()
{
    {"Chave 1", "Valor 1"},
    {"Chave 2", "Valor 2"},
};

// Obter valor do dictionary 

string val = dictionary ["Chave 1"];

try
{
    val = dictionary["Chave 3"];
}
catch (Exception ex)
{
    Console.WriteLine("Erro ao Obter valor chave 3");
    Console.WriteLine(ex.Message);
}

// Veficando se a chave existe antes de acessar para evitar erros e prejuizos de excuções 

if (dictionary.ContainsKey("Chave 2") )
{
        Console.WriteLine($"Chave 2: {dictionary["Chave 2"]}");

}

// Outra forma de obter o valor e evitar erro 
dictionary.TryGetValue("Chave 4", out string? valor);
if(valor is not null)
    Console.WriteLine($"Chave 4: {valor}");

    //Podemos adicionar da mesma forma pela chave inexstente 
dictionary["Chave 0"] = "Valor 0";

// Percorrer o dicionário

foreach(KeyValuePair<string, string> kvp in dictionary)
{
    Console.WriteLine($"{kvp.Key}:{kvp.Value}"); 
}

// Utilizando Tipos Abstrator de dados com dicionário 

Dictionary<int, Pessoa> dicPessoa = new Dictionary<int, Pessoa>();

dicPessoa.Add(1, new Pessoa(){
    Id = 0, 
    BirthDate = new DateTime(2003, 01, 05),
    Name = "Silvio Bolzani",
    
    }
);

dicPessoa.Add(2, new Pessoa(){
    Id = 0, 
    BirthDate = new DateTime(2019, 07, 20),
    Name = "Jake",
    
    }
);

foreach(KeyValuePair<int, Pessoa> kvp in dicPessoa)
{
    Console.WriteLine(kvp.Key);
    Console.WriteLine(kvp.Value.Id);
    Console.WriteLine(kvp.Value.Name);
    Console.WriteLine(kvp.Value.BirthDate);
}
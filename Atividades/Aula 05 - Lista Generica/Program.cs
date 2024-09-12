using Aula_05___Lista_Generica;


List<double> numbers = new List<double>();

do
{
    Console.WriteLine("Informe um Número");
    string? numberStr = Console.ReadLine();

    //Validando a entrada do Usuário 

    if(!double.TryParse(numberStr, out double number))
    {
        break;
    }

    numbers.Add(number);
    Console.WriteLine($"A Média dos valores é {numbers.Average()}");

}
while(true);

// -- Lista de Pessoas
List<Person> people = new List<Person>();
Person p1 = new Person();
p1.Name = "Silvio";
p1.Age = 21;
p1.country = CountryEnum.BR;
people.Add(p1);

p1.Name = "Silvio Bolzani";

people.Add(new Person(){
    Name = "Jake",
    Age = 5,
    country = CountryEnum.BR,

});

Person p3 = new Person(){
    Name = "Zoe",
    Age= 5,
    country = CountryEnum.BR,
};
people.Add(p3);

// Formas de percorrer a Lista Generica

foreach(Person p in people)
{
    Console.WriteLine(p.Name);
}

//Modo for Tradicional

for(int i = 0; i < people.Count; i++)
{
    Console.WriteLine(people[i].Name);
}
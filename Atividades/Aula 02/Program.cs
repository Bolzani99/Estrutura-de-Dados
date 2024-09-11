using Aula_02;

Person person = new Person();
Console.WriteLine(person.Name);
Console.WriteLine(person.Age);

Person person1 = new Person("Joao Vitor", 22);
Console.WriteLine(person1.Name);
Console.WriteLine(person1.Age);

Person person2 = new Person();
person2.Name = "Vladimir Ulyanov";
person2.Age = 45;
Console.WriteLine(person2.Name);
Console.WriteLine(person2.Age);

Person person3 = new Person()
{
    Name = "Lionel Messi",
    Age = 35
};
Console.WriteLine(person3.Name);
Console.WriteLine(person3.Age);
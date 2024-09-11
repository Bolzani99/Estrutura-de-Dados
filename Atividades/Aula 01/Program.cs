using Aula_01;

//Declarando Variavel
int number;

// Atribuindo valor
number = 10;

// Declarando constante
const int DAYS_IN_WEEK = 7;

// Imprimindo String concatenada
Console.WriteLine($"A semana tem {DAYS_IN_WEEK} dias.");

// new TipoEnumerador() -> Invoca o método construtor do objeto;
// Toda classe tem o seu construtor padrão implicito sem argumentos/params.
// É possivel sobreescrever este metodo especificando argumentos, Todavia, se o fizermos, perdemos o original implicito e precisamos defini-lo explicitamente.
TipoEnumerador tipoEnum = new TipoEnumerador();

TipoEnumerador.Language enumEnglish = tipoEnum.GetLanguageEnum("ingles");

Console.WriteLine($"O enum de english é {enumEnglish}");

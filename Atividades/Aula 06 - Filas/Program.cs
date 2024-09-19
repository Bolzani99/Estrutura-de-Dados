// Uma fila é a estrutura de dados que pode ser aplicada para representar  a fila de atendimento da cantina 
// As pessoas que chegam entram no final da fila  e as primeiras que chegaram são as primeiras 
// a serem atendidas. 

// A Função ENQUEUE é responsável por adicionar
// novos elementos à fila 

// A função DEQUEUE removo elementos da fila. 

// Desta forma, obedece o o princípio do FIFO
// First in, First Out -> Primeiro que entra é o primeiro que sai

using Aula_06___Filas;

Random random = new Random();

CallCenter center = new ();
center.call(1234);
center.call(1369);
center.call(2468);
center.call(1478);


while(center.AreWaitCalls())
{
    Thread.Sleep(3000);
    IncomingCall call = center.Answer("Silvio");
    Console.WriteLine(
        @$"{DateTime.Now:HH:mm:ss}
        Chamado: #{call.Id}
        De: {call.ClientId}
        Atendido por: {call.Consultant}");
        
        Thread.Sleep(random.Next(1000, 10000));
        center.End(call);
        Console.WriteLine(
            @$"Chamado: {call.Id}
               Encerrado às: {call.EndTime}"
        );
        
        
};
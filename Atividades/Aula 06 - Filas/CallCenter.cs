using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_06___Filas
{
    public class CallCenter
    {
        private int _counter  = 0;
        public Queue<IncomingCall>? Calls { get; set; } 
        
        public CallCenter()
        {
            Calls = new Queue<IncomingCall>();
        }

        // Metodo para abertura de chamados

        public void call(int clientId)
        {
            IncomingCall call = new IncomingCall()
            {
                Id = ++_counter,
                ClientId = clientId,
                CallTime = DateTime.Now,
            };

            Calls!.Enqueue(call);
        }

        public IncomingCall Answer(string Consultant)
        {
           // Validação: Verificar se tem atendimentos na fila
           if(Calls!.Count > 0)
           {
                IncomingCall call = Calls.Dequeue();
                call.Consultant = Consultant;
                call.StartTime = DateTime.Now;

                return call;
           }

           return null!;

        }

        public void End(IncomingCall call)
        {
            call.EndTime = DateTime.Now;
        }
        
        public bool AreWaitCalls()
        {
            return (Calls!.Count > 0); 
        }

    }
}
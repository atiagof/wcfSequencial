using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace servico
{
    [ServiceContract]
    public interface IServico
    {
        [OperationContract]
        string Mensagem(string nome);

        [OperationContract]
        int Dispositivo(int numero);
    }
}

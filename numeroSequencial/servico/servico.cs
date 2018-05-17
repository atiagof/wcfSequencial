using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace servico
{
    public class Servico : IServico
    {
        public string Mensagem(string nome)
        {
            return "Ola " + nome + ", o serviço está funcionando";
        }

        public int Dispositivo(int numero)
        {
            return (numero + Convert.ToInt32(1));
        }
    }
}

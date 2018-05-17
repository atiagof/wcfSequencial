using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace AppCliente
{
    class Program
    {
        static void Main(string[] args)
        {
            var servico = new ServicoClient();

            //Console.WriteLine(servico.Mensagem(Console.ReadLine()));
            //Console.ReadKey();

            Console.WriteLine(servico.Dispositivo(Convert.ToInt32(Console.ReadLine())));
            Console.ReadKey();

        }
    }
}

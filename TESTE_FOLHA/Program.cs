using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using API_FOLHA;

namespace TESTE_FOLHA
{
    class Program
    {
        static List<ICalculoSalario> Empregados;

        static void Main(string[] args)
        {
            Empregados = new List<ICalculoSalario>();
            Empregados.Add(new CalculoSalarioFuncionario(1, "JOÂO NINGUEM DA SILVA", 32));
            Empregados.Add(new CalculoSalarioFuncionario(1, "MARIA ALGUÉM DE OLIVEIRA", 32));
            Empregados.ForEach(e => e.Imprimir());
            Console.ReadKey();
        }
    }
}

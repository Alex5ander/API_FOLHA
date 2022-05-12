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
        static List<ICalculoSalario> Aposentados;
        static List<ICalculoSalario> Estagiarios;

        static void Main(string[] args)
        {
            Empregados = new List<ICalculoSalario>();
            for (int i = 0; i < 50; i++)
            {
                Empregados.Add(new CalculoSalarioFuncionario(1, "JOÂO NINGUEM DA SILVA", 32));
                Empregados.Add(new CalculoSalarioFuncionario(2, "MARIA ALGUÉM DE OLIVEIRA", 32));
            }

            Empregados.ForEach(e => e.Imprimir());

            Aposentados = new List<ICalculoSalario>();
            for (int i = 0; i < 100; i++)
            {
                Aposentados.Add(new CalculoSalarioAposentado(i, "Nome do aposentado"));
            }

            Aposentados.ForEach(e => e.Imprimir());

            Estagiarios = new List<ICalculoSalario>();
            for (int i = 0; i < 100; i++)
            {
                Estagiarios.Add(new CalculoSalarioEstagiario(i, "Nome do aposentado", 100));
            }

            Estagiarios.ForEach(e => e.Imprimir());
            
            Console.ReadKey();
        }
    }
}

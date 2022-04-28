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
        static ICalculoSalario emp;

        static void Main(string[] args)
        {
            emp = new CalculoSalarioFuncionario(1, "JOÂO NINGUEM DA SILVA", 32);
            emp.Imprimir();
            Console.ReadKey();
        }
    }
}

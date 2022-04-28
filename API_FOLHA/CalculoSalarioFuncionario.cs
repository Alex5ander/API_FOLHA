using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_FOLHA
{
    class CalculoSalarioFuncionario : ICalculoSalario
    {
        public string Nome { get; set; }
        public long Cod { get; set; }
        public double HorasTrabalhadas { get; set; }

        public CalculoSalarioFuncionario(long Cod, string Nome, double HorasTrabalhadas)
        {
            this.Cod = Cod;
            this.Nome = Nome;
            this.HorasTrabalhadas = HorasTrabalhadas;
        }

        public double Calcular(double SalarioHora)
        {
            return SalarioHora * HorasTrabalhadas;
        }

        public double Imposto(double valor)
        {
            return valor * 0.15;  
        }

        public void Imprimir()
        {
            Console.WriteLine("HOLERITE - FUNCIONÁRIO");
            Console.WriteLine("COD: {0} ", Cod);
            Console.WriteLine("Nome: {0}", Nome);
            Console.WriteLine("Horas trabalhadas: {0}", HorasTrabalhadas);
            double bruto = Calcular(160);
            double desconto = Imposto(bruto);
            Console.WriteLine("SAL BRUTO: {0:C2}", bruto);
            Console.WriteLine("IMPOSTO: {0:C2}", desconto);
            Console.WriteLine("SAL LIQ: {0:C2}", bruto - desconto);
        }
    }
}

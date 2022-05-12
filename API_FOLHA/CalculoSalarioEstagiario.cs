using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_FOLHA
{
    public class CalculoSalarioEstagiario : ICalculoSalario 
    {

        public string Nome { get; set; }
        public long Cod { get; set; }
        public double Ajuda { get; set; }

        public CalculoSalarioEstagiario(long Cod, string Nome, double Ajuda)
        {
            this.Cod = Cod;
            this.Nome = Nome;
            this.Ajuda = Ajuda;
        }

        public double Calcular(double SalarioHora)
        {
            return SalarioHora * 80 > 1212 ? 1212 : SalarioHora * 80 + Ajuda;
        }

        public double Imposto(double valor)
        {
            return 0;
        }

        public void Imprimir()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("HOLERITE - ESTAGIÁRIO");
            Console.WriteLine("COD: {0} ", Cod);
            Console.WriteLine("Nome: {0}", Nome);
            double bruto = Calcular(160);
            double desconto = Imposto(bruto);
            Console.WriteLine("SAL BRUTO: {0:C2}", bruto);
            Console.WriteLine("IMPOSTO: {0:C2}", desconto);
            Console.WriteLine("SAL LIQ: {0:C2}", bruto - desconto);
            Console.WriteLine("Ajuda: {0:C2}", Ajuda);
        }
    }
}

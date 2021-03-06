using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_FOLHA
{
    public class CalculoSalarioAposentado : ICalculoSalario
    {
        public string Nome { get; set; }
        public long Cod { get; set; }

        public CalculoSalarioAposentado(long Cod, string Nome) {
            this.Cod = Cod;
            this.Nome = Nome;
        }

        public double Calcular(double SalarioHora)
        {
            return SalarioHora * 160 > 6050 ? 6050 : SalarioHora * 160;
        }

        public double Imposto(double valor)
        {
            return valor * 0.01;
        }

        public void Imprimir()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("HOLERITE - INATIVO");
            Console.WriteLine("COD: {0} ", Cod);
            Console.WriteLine("Nome: {0}", Nome);
            double bruto = Calcular(160);
            double desconto = Imposto(bruto);
            Console.WriteLine("SAL BRUTO: {0:C2}", bruto);
            Console.WriteLine("IMPOSTO: {0:C2}", desconto);
            Console.WriteLine("SAL LIQ: {0:C2}", bruto - desconto);
        }
    }
}

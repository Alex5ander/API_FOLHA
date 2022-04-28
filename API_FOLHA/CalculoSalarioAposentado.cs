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
            return SalarioHora * 10;
        }

        public double Imposto(double valor)
        {
            return valor * 0.05;
        }

        public void Imprimir()
        {
            
        }
    }
}

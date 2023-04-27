using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PClasses
{
    class Horista : Empregado
    {
       
        
        //prop e 2 x tab cria estrutura da propriedade
        public double SalarioHora { get; set; }
        public double NumeroHora { get; set; }
        public int DiasFalta { get; set; }


        public override double SalarioBruto()
        {
            return SalarioHora * NumeroHora;
        }

        // everride indica sobreescrever
        public override int TempoTrabalho()
        {
            // o metodo retorna um tipo span
            TimeSpan span = DateTime.Today.Subtract(DataEntradaEmpresa);
            return (span.Days - DiasFalta);
        }


    }
}

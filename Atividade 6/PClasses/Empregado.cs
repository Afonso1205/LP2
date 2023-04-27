using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PClasses
{
    abstract class Empregado
    {
        private int matricula; // atributo
        private string nomeEmpregado;
        private DateTime dataEntradaEmpresa;
        private char homeOffice;


        public int Matricula // propriedade
        {
            get { return matricula; }
            set { matricula = value; }
        }

        public string NomeEmpregado
        {
            get { return nomeEmpregado; }
            set { nomeEmpregado = value; }
        }

        public DateTime DataEntradaEmpresa
        {
            get { return dataEntradaEmpresa; }
            set { dataEntradaEmpresa = value; }
        }

        public Char HomeOffice
        {
            get { return homeOffice; }
            set { homeOffice = value; }
        }

        // método são ações e comportamentos
        public String VerificaHome()//metodo
        {
            if (homeOffice == 'S')
                return "Empregado trabalha em home office";
            else
                return "Empregado NÃO trabalha em home office";
        }

        //virtual --> pode ser sobreescrito
        public virtual int TempoTrabalho()
        {
            // representa um intervalo de tempo
            TimeSpan span = DateTime.Today.Subtract(DataEntradaEmpresa);

            return (span.Days);
        }

        // deve ser implementado classes filhas (subclasses)

        public abstract double SalarioBruto(); // não preciso implementar

        public Empregado() // CONSTRUTOR --> NEW
        {

        }
    }
}

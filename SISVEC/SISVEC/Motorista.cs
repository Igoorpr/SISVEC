using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISVEC
{
    class Motorista
    {
        private string nome;
        private string numCarteira;
        private int pontuacaoCarteira;
        private string cpf;
        private string dataNasc;
        private List<Veiculo> ListaVeiculos = new List<Veiculo>();

        public Motorista(string nome, string numCarteira, int pontuacaoCarteira, string cpf, string dataNasc, List<Veiculo> listaVeiculos)
        {
            this.Nome = nome;
            this.NumCarteira = numCarteira;
            this.PontuacaoCarteira = pontuacaoCarteira;
            this.Cpf = cpf;
            this.DataNasc = dataNasc;
            ListaVeiculos1 = listaVeiculos;
        }

        public string Nome { get => nome; set => nome = value; }
        public string NumCarteira { get => numCarteira; set => numCarteira = value; }
        public int PontuacaoCarteira { get => pontuacaoCarteira; set => pontuacaoCarteira = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string DataNasc { get => dataNasc; set => dataNasc = value; }
        internal List<Veiculo> ListaVeiculos1 { get => ListaVeiculos; set => ListaVeiculos = value; }
    }
}

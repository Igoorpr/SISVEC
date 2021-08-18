using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISVEC
{
    class Veiculo
    {
        private string placa;
        private string cor;
        private string chassi;
        private string modelo;
        private string ano;
        private string CPF_CNPJ;
        private string numeroDoc;
        private string List<Multas>;
        private int cargaMaxima;
        private int numPassageiros;
        private int eixos;
        private string tipo;

        public string Placa { get => placa; set => placa = value; }
        public string Cor { get => cor; set => cor = value; }
        public string Chassi { get => chassi; set => chassi = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Ano { get => ano; set => ano = value; }
        public string CPF_CNPJ1 { get => CPF_CNPJ; set => CPF_CNPJ = value; }
        public string NumeroDoc { get => numeroDoc; set => numeroDoc = value; }
        public int CargaMaxima { get => cargaMaxima; set => cargaMaxima = value; }
        public int NumPassageiros { get => numPassageiros; set => numPassageiros = value; }
        public int Eixos { get => eixos; set => eixos = value; }
        public string Tipo { get => tipo; set => tipo = value; }

        public Veiculo(string placa, string cor, string chassi, string modelo, string ano, string cPF_CNPJ, string numeroDoc, int cargaMaxima, int numPassageiros, int eixos, string tipo)
        {
            this.Placa = placa;
            this.Cor = cor;
            this.Chassi = chassi;
            this.Modelo = modelo;
            this.Ano = ano;
            CPF_CNPJ1 = cPF_CNPJ;
            this.NumeroDoc = numeroDoc;
            this.CargaMaxima = cargaMaxima;
            this.NumPassageiros = numPassageiros;
            this.Eixos = eixos;
            this.Tipo = tipo;
        }
        
    }
}

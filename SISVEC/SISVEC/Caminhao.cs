using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISVEC
{
    class Caminhao : Veiculo
    {
        public Caminhao(string placa, string cor, string chassi, string modelo, string ano, string cPF_CNPJ, string numeroDoc, int cargaMaxima, int numPassageiros, int eixos, string tipo) : base(placa, cor, chassi, modelo, ano, cPF_CNPJ, numeroDoc, cargaMaxima, numPassageiros, eixos, tipo)
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

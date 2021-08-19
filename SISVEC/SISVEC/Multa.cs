using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISVEC
{
    class Multa
    {
        private int id;
        private int gravidade;
        private string dataMulta;
        private double valor;
        private int penalidade;
        private string cpfMultado;
        private bool justificada;
        private bool quitada;
        private string justificativa;

        public Multa(int id, int gravidade, string dataMulta, double valor, int penalidade, string cpfMultado, bool justificada, bool quitada, string justificativa)
        {
            this.Id = id;
            this.Gravidade = gravidade;
            this.DataMulta = dataMulta;
            this.Valor = valor;
            this.Penalidade = penalidade;
            this.CpfMultado = cpfMultado;
            this.Justificada = justificada;
            this.Quitada = quitada;
            this.Justificativa = justificativa;
        }

        public int Id { get => id; set => id = value; }
        public int Gravidade { get => gravidade; set => gravidade = value; }
        public string DataMulta { get => dataMulta; set => dataMulta = value; }
        public double Valor { get => valor; set => valor = value; }
        public int Penalidade { get => penalidade; set => penalidade = value; }
        public string CpfMultado { get => cpfMultado; set => cpfMultado = value; }
        public bool Justificada { get => justificada; set => justificada = value; }
        public bool Quitada { get => quitada; set => quitada = value; }
        public string Justificativa { get => justificativa; set => justificativa = value; }

        public void CalcularPenalidade(int gravidade)
        {
        }

        public void QuitarMulta()
        {
        }

        public void JustificarMulta(string justificativa)
        {
        }
    }
}

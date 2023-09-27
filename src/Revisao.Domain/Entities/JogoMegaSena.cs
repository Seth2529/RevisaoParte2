using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Domain.Entities
{
    public class JogoMegaSena
    {
        #region Construtores
        public JogoMegaSena(string nome, string cpf, int primeiroNro, int segundoNro, int terceiroNro, int quartoNro, int quintoNro, int sextoNro, DateTime datajogo) 
        { 
            Nome = nome;
            Cpf = cpf;
            PrimeiroNro = primeiroNro;
            SegundoNro = segundoNro;
            TerceiroNro = terceiroNro;
            QuartoNro = quartoNro;
            QuintoNro = quintoNro;
            SextoNro = sextoNro;
        }

        #endregion 

        #region Propriedades
        public string Nome { get; set; }

        public string Cpf { get; set; }

        public int PrimeiroNro { get; set; }

        public int SegundoNro { get; set; }

        public int TerceiroNro { get; set; }

        public int QuartoNro { get; set; }

        public int QuintoNro { get; set; }

        public int SextoNro { get; set; }

        public DateTime Datajogo { get; set; }
        #endregion

    }
}

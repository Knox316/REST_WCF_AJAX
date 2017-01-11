using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ImoServicos.Model
{
    [DataContract(Namespace = "")]
    public class HistoricoAluguer
    {
        int idHistoricoAluguer;
        int idQuarto;
        int idHabitacao;
        int idCliente;
        DateTime dataInicio;
        DateTime dataFim;
        string descricao;

        [DataMember(Order = 0)]
        public int IdHistoricoAluguer
        {
            get { return idHistoricoAluguer; }
            set { idHistoricoAluguer = value; }
        }
        [DataMember(Order = 1)]
        public int IdQuarto
        {
            get { return idQuarto; }
            set { idQuarto = value; }
        }

        [DataMember(Order = 2)]
        public int IdHabitacao
        {
            get { return idHabitacao; }
            set { idHabitacao = value; }
        }

        [DataMember(Order = 3)]
        public int IdCliente
        {
            get { return idCliente; }
            set { idCliente = value; }
        }

        public DateTime DataInicio
        {
            get { return dataInicio; }
            set { dataInicio = value; }
        }

        public DateTime DataFim
        {
            get { return dataFim; }
            set { dataFim = value; }
        }

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        /// <summary>
        /// Inicio a entidade
        /// </summary>
        public HistoricoAluguer()
        {
            IdHistoricoAluguer = 0;
            IdQuarto = 0;
            IdHabitacao = 0;
            IdCliente = 0;
            DataInicio = this.DataInicio;
            DataFim = this.DataFim;
            Descricao = "";
        }


        /// <summary>
        /// Construtor de  um datarow para uma entidade
        /// </summary>
        /// <param name="dataRow">DataRow</param>
        public HistoricoAluguer(DataRow dataRow)
        {
            IdHistoricoAluguer = Convert.ToInt32(dataRow["idHistoricoAluguer"]);
            IdQuarto = Convert.ToInt32(dataRow["idQuarto"]);
            IdHabitacao = Convert.ToInt32(dataRow["idHabitacao"]);
            IdCliente = Convert.ToInt32(dataRow["idCliente"]);
            DataInicio = Convert.ToDateTime(dataRow["dataInicio"]);
            DataFim = Convert.ToDateTime(dataRow["dataFim"]);
            Descricao = dataRow["descricao"].ToString();
        }
    }
}
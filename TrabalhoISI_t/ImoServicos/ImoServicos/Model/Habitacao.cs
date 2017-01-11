using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ImoServicos.Model
{
    [DataContract(Namespace = "")]
    public class Habitacao
    {
        int idHabitacao;
        int idCliente;
        int preco;
        bool ocupado;
        string tipoOcupacao;

        [DataMember(Order = 0)]
        public int IdHabitacao
        {
            get { return idHabitacao; }
            set { idHabitacao = value; }
        }

        [DataMember(Order = 1)]
        public int IdCliente
        {
            get { return idCliente; }
            set { idCliente = value; }
        }

        [DataMember(Order = 2)]
        public int Preco
        {
            get { return preco; }
            set { preco = value; }
        }

        [DataMember(Order = 3)]
        public bool Ocupado
        {
            get { return ocupado; }
            set { ocupado = value; }
        }

        [DataMember(Order = 4)]
        public string TipoOcupacao
        {
            get { return tipoOcupacao; }
            set { tipoOcupacao = value; }
        }


        ///// <summary>
        ///// Inicio a entidade
        ///// </summary>
        //public Habitacao()
        //{
        //    idHabitacao = 0;
        //    idCliente = 0;
        //    preco = 0;
        //    ocupado = false;
        //    tipoOcupacao = "";
        //}

        public Habitacao()
        {

        }

        /// <summary>
        /// Construtor de  um datarow para uma entidade
        /// </summary>
        /// <param name="dataRow">DataRow</param>
        public Habitacao(DataRow dataRow)
        {
            IdHabitacao = Convert.ToInt32(dataRow["idCliente"]);
            IdCliente = Convert.ToInt32(dataRow["idCliente"]);
            Preco = Convert.ToInt32(dataRow["preco"]);
            Ocupado = Convert.ToBoolean(dataRow["ocupado"]);
            TipoOcupacao = dataRow["tipoOcupacao"].ToString();
        }
    }
}
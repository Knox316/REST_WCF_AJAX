using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ImoServicos.Model
{
    [DataContract(Namespace = "")]
    public class Cliente
    {
        [DataMember(Order = 0)]
        int idCliente;
        [DataMember(Order = 1)]
        string nomeUtilizador;
        [DataMember(Order = 2)]
        string password;
        [DataMember(Order = 3)]
        int tipoUtilizador;
        [DataMember(Order = 4)]
        bool ativo;


        public int IdCliente
        {
            get { return idCliente; }
            set { idCliente = value; }
        }


        public string NomeUtilizador
        {
            get { return nomeUtilizador; }
            set { nomeUtilizador = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }


        public int TipoUtilizador
        {
            get { return tipoUtilizador; }
            set { tipoUtilizador = value; }
        }


        public bool Ativo
        {
            get { return ativo; }
            set { ativo = value; }
        }

        /// <summary>
        /// Inicio a entidade
        /// </summary>
        public Cliente()
        {
            IdCliente = 0;
            NomeUtilizador = "";
            Password = "";
            TipoUtilizador = 0;
            Ativo = false;
        }


        /// <summary>
        /// Construtor de um datarow para uma entidade
        /// </summary>
        /// <param name="dataRow">DataRow</param>
        public Cliente(DataRow dataRow)
        {
            IdCliente = Convert.ToInt32(dataRow["idCliente"]);
            NomeUtilizador = dataRow["nomeUtilizador"].ToString();
            Password = dataRow["password"].ToString();
            TipoUtilizador = Convert.ToInt32(dataRow["tipoUtilizador"]);
            Ativo = Convert.ToBoolean(dataRow["ativo"]);
        }

    }
}
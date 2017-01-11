using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ImoServicos.Model
{
    [DataContract(Namespace = "")]
    public class Imagem
    {
        [DataMember(Order = 0)]
        int idImagem;
        [DataMember(Order = 1)]
        int idHabitacao;
        [DataMember(Order = 2)]
        int idQuarto;
        [DataMember(Order = 3)]
        string imagens;
        

        public int IdImagem
        {
            get { return idImagem; }
            set { idImagem = value; }
        }


        public int IdHabitacao
        {
            get { return IdHabitacao; }
            set { idHabitacao = value; }
        }

        public int IdQuarto
        {
            get { return idQuarto; }
            set { idQuarto = value; }
        }


        public string Imagens
        {
            get { return imagens; }
            set { imagens = value; }
        }


        /// <summary>
        /// Inicio a entidade
        /// </summary>
        public Imagem()
        {
            idImagem = 0;
            idImagem = 0;
            idQuarto = 0;
            imagens = "";
        }

        /*
        /// <summary>
        /// Construtor de um datarow para uma entidade
        /// </summary>
        /// <param name="dataRow">DataRow</param>
        public Imagem(DataRow dataRow)
        {
            IdCliente = Convert.ToInt32(dataRow["idCliente"]);
            NomeUtilizador = dataRow["nomeUtilizador"].ToString();
            Password = dataRow["password"].ToString();
            TipoUtilizador = Convert.ToInt32(dataRow["tipoUtilizador"]);
            Ativo = Convert.ToBoolean(dataRow["ativo"]);
        }
        */
    }
}
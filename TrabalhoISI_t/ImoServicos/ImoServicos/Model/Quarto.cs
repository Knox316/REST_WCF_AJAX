using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ImoServicos.Model
{
    [DataContract(Namespace = "")]
    public class Quarto
    {
        int idQuarto;
        int idHabitacao;
        int preco;
        bool ocupado;

        [DataMember(Order = 0)]
        public int IdQuarto
        {
            get { return idQuarto; }
            set { idQuarto = value; }
        }

        [DataMember(Order = 1)]
        public int IdHabitacao
        {
            get { return idHabitacao; }
            set { idHabitacao = value; }
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

        /// <summary>
        /// Inicio a entidade
        /// </summary>
        public Quarto()
        {
            IdQuarto = 0;
            IdHabitacao = 0;
            Preco = 0;
            Ocupado = false;
        }


        /// <summary>
        /// Construtor de  um datarow para uma entidade
        /// </summary>
        /// <param name="dataRow">DataRow</param>
        public Quarto(DataRow dataRow)
        {
            IdQuarto = Convert.ToInt32(dataRow["idQuarto"]);
            IdHabitacao = Convert.ToInt32(dataRow["idHabitacao"]);
            Preco = Convert.ToInt32(dataRow["preco"]);
            Ocupado = Convert.ToBoolean(dataRow["ocupado"]);
        }
    }
}
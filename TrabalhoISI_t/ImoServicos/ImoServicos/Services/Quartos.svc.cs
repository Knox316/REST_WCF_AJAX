using ImoServicos.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ImoServicos.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Quartos" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Quartos.svc or Quartos.svc.cs at the Solution Explorer and start debugging.
    public class Quartos : IQuartos
    {
        #region QUARTO
        /// <summary>
        /// Metodo para Adicionar um Quarto
        /// </summary>
        /// <param name="qua"></param>
        public void AdicionarQuarto(Quarto qua)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("INSERT INTO Quarto(idHabitacao, preco, ocupado) Values");
                sb.AppendFormat("('{0}', '{1}', '{2}' )",
                    qua.IdHabitacao, qua.Preco, qua.Ocupado);

                (new Dal.DbHelper()).SqlExecute(sb.ToString());
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Inserir", ex);
            }
        }
        #endregion

        #region DELETE
        /// <summary>
        /// Metodo para apagar um quarto pelo ID
        /// </summary>
        /// <param name="id"></param>
        public void ApagarQuarto(string id)
        {

            try
            {
                (new Dal.DbHelper()).SqlExecute("DELETE FROM Quarto where idQuarto = " + id);
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao apagar", ex);
            }
        }
        #endregion

        #region LIST
        /// <summary>
        /// Metodo para listar Quartos
        /// </summary>
        /// <returns></returns>
        public List<Quarto> ListarQuartos()
        {

            try
            {
                var dt = (new Dal.DbHelper()).GetResultSet("SELECT idQuarto, idHabitacao, preco, ocupado FROM Quarto");
                List<Quarto> listaQuartos = new List<Quarto>();
                foreach (DataRow item in dt.Rows)
                {
                    listaQuartos.Add(new Quarto(item));
                }
                return listaQuartos;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro a devolver lista", ex);
            }
        }
        #endregion

        #region SEARCH
        /// <summary>
        /// Procurar quarto por ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Quarto ProcurarQuartoId(string id)
        {
            try
            {
                var dt = (new Dal.DbHelper()).GetResultSet("SELECT idQuarto, idHabitacao, preco, ocupado FROM Quarto WHERE idQuarto = " + id);
                if (dt.Rows.Count > 0)
                {
                    List<Quarto> listaQuartos = new List<Quarto>();
                    foreach (DataRow item in dt.Rows)
                    {
                        listaQuartos.Add(new Quarto(item));
                    }
                    return listaQuartos.First();
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro a procurar Habitacao", ex);
            }
        }
        #endregion

        #region UPDATE
        /// <summary>
        /// Atualizar os dados dos Quartos
        /// </summary>
        /// <param name="qua"></param>
        public void UpdateQuarto(Quarto qua)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("UPDATE Quarto SET");
                sb.AppendFormat("idQuarto = '{0}', ", qua.IdQuarto);
                sb.AppendFormat("idHabitacai = '{0}', ", qua.IdQuarto);
                sb.AppendFormat("preco = '{0}', ", qua.Preco);
                sb.AppendFormat("ocupado = '{0}', ", qua.Ocupado ? 1 : 0);

                (new Dal.DbHelper()).SqlExecute(sb.ToString());
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao atualizar", ex);
            }
        }
        #endregion
    }
}

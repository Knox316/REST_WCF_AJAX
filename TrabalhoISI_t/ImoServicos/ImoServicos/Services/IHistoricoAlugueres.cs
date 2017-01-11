using ImoServicos.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ImoServicos.Services
{
    /// <summary>
    /// Assinatura dos Metodos para o Historico de Alugueres
    /// </summary>
    [ServiceContract]
    public interface IHistoricoAlugueres
    {
        [OperationContract()]
        [WebInvoke(Method = "GET", UriTemplate = "/ListarHistoricoAlu", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<HistoricoAluguer> ListarHistoricoAlu();

        [OperationContract()]
        [WebInvoke(Method = "GET", UriTemplate = "/ProcurarHistoricoAluId/{id}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        HistoricoAluguer ProcurarHistoricoAluId(string id);

        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "/AdicionarHistoricoAlu", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        void AdicionarHistoricoAlu(HistoricoAluguer ha);

        [OperationContract()]
        [WebInvoke(Method = "PUT", UriTemplate = "/UpdateHistoricoAlu", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        void UpdateHistoricoAlu(HistoricoAluguer ha);

        [OperationContract()]
        [WebInvoke(Method = "DELETE", UriTemplate = "/ApagarHistoricoAlu/{id}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        void ApagarHistoricoAlu(string id);
    }
}

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
    /// Assinaturas dos metodos para Quartos
    /// </summary>
    [ServiceContract]
    public interface IQuartos
    {
        [OperationContract()]
        [WebInvoke(Method = "GET", UriTemplate = "/ListarQuartos", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Quarto> ListarQuartos();

        [OperationContract()]
        [WebInvoke(Method = "GET", UriTemplate = "/ProcurarQuartoId/{id}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        Quarto ProcurarQuartoId(string id);

        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "/AdicionarQuarto", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        void AdicionarQuarto(Quarto qua);

        [OperationContract()]
        [WebInvoke(Method = "PUT", UriTemplate = "/UpdateQuarto", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        void UpdateQuarto(Quarto qua);

        [OperationContract()]
        [WebInvoke(Method = "DELETE", UriTemplate = "/ApagarQuarto/{id}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        void ApagarQuarto(string id);
    }
}

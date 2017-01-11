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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IClientes" in both code and config file together.
    [ServiceContract]
    public interface IClientes
    {
        /// <summary>
        /// GET Clientes
        /// </summary>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(Method = "GET", UriTemplate = "/ListarClientes", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Cliente> ListarClientes();

        /// <summary>
        /// GET Clientes by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(Method = "GET", UriTemplate = "/ProcurarClienteId/{id}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        Cliente ProcurarClienteId(string id);

        /// <summary>
        /// POST Clientes
        /// </summary>
        /// <param name="cli"></param>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "/AdicionarCliente", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        void AdicionarCliente(Cliente cli);

        /// <summary>
        /// PUT CLientes
        /// </summary>
        /// <param name="cli"></param>
        [OperationContract()]
        [WebInvoke(Method = "PUT", UriTemplate = "/UpdateCliente", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        void UpdateCliente(Cliente cli);

        /// <summary>
        /// DELETE Clientes
        /// </summary>
        /// <param name="id"></param>
        [OperationContract()]
        [WebInvoke(Method = "DELETE", UriTemplate = "/ApagarCliente/{id}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        void ApagarCliente(string id);
    }
}

$(document).ready(function () {
            $("#btn").click(function () {
                $.ajax({
                    url: "http://localhost:3332/Services/Clientes.svc/ListarClientes",
                    type: "GET",
                    Accept: "aplication/json",
                    success: function (resultdata) {
                        $.each(resultdata, function (k, v) {
                            var IdCliente = v.IdCliente;
                            var NomeUtilizador = v.NomeUtilizador;
                            var Password = v.Password;
                            var TipoUtilizador = v.TipoUtilizador;
                            var Ativo = v.Ativo;


                            $("#caption").append($("#tbl").append("<tr><td>" + IdCliente + "</td><td>" + NomeUtilizador + "</td><td>" + Password + "</td><td>" + TipoUtilizador + "</td><td>" + Ativo + "</td></tr>"))
                        })
                    },
                    error:function(e)
                    {
                        alert("Alguma coisa aconteceu");
                    }

                    
                });
            });
        });
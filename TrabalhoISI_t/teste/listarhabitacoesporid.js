$(document).ready(function () {
    $("#btn").click(function () {
        $.ajax({
            url: "http://localhost:2089/Services/Habitacoes.svc/ListarHabitacao",
            type: "GET",
            Accept: "aplication/json",
            success: function (resultdata) {
                $.each(resultdata, function (k, v) {
                
                    var IdHabitacao = v.IdHabitacao;
                    var IdCliente = v.IdCliente;
                    var Preco = v.Preco;
                    var Ocupado = v.Ocupado;
                    var TipoOcupacao = v.TipoOcupacao;

                    $("#tbl").append("<tr><td>" + IdHabitacao + "</td><td>" + IdCliente + "</td><td>" + Preco + "</td><td>" + Ocupado + "</td><td>" + TipoOcupacao + "</td></tr>")
                })
            },
            error: function (e) {
                alert("Alguma coisa aconteceu");
            }
        });
    });
});
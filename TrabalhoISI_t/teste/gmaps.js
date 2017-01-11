$(document).ready(function () {
    $("#btn").click(function () {
        $.ajax({
            url: "http://localhost:2089/Services/DadosHabitacoes.svc/ListarDadosHabitacao",
            type: "GET",
            Accept: "aplication/json",
            success: function (resultdata) {
                $.each(resultdata, function (k, v) {
                
                    var IdDadosHabitacao = v.IdDadosHabitacao;
                    var Latitude = v.Latitude;
                    var Longitude = v.Longitude;
					
					$("#tbl").append("<tr><td>" + IdDadosHabitacao + "</td><td>" + Latitude + "</td><td>" + Longitude + "</td></tr>")
                })
            },
            error: function (e) {
                alert("Alguma coisa aconteceu");
            }
        });
    });
});

//string uri = "https://maps.googleapis.com/maps/api/place/nearbysearch/json?";

                //uri += "location=" + l + "," + g + "&";
                //uri += "radius=" + "500" + "&";
                //uri += "types=point_of_interest&";
                //uri += "key=AIzaSyDali7EBKIxoMHmPkkdrkwk6jRzucb4Cxs"
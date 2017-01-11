$(document).ready(function () {
    var urlService = "http://localhost:38958/Services/TryGmaps.svc/";
    var puntos = [];
    function getPaciente() {
        try {
            var param = $("#txtNom").val();
            $.ajax({
                type: "POST",
                url: urlService + "getPacientes",
                data: '{"idh":"' + param + '"}',
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (data) {
                    alert(data.d);
                    var pacientes = eval(data.d);
                    var html = "";
                    $.each(pacientes, function () { 
                        html += "<tr data-='" + JSON.stringify(this) +
                            "'><td><a onclick='mostrarDireccion(this)'>OK</a></td><td>" + this.IdHabitacao +
                            "</td><td>" + this.IdCliente + "</td><td>" + this.Preco + "</td><td>" + this.Ocupado + "</td><td>" + this.TipoOcupacao + "</td></tr>";
                    });
                    $("#tabCliente tbody").html(html);
                },
                error: function (da) {                        
                    alert('Error ' + da.responseText);
                }
            });
        } catch (e) {                
            alert(e.message);
        }
    };
})

$(document).ready(function() {
    $.ajax({
		url: "http://localhost:38958/Services/DadosHabitacoes.svc/ProcurarDadosHabitacao/1",
            type: "GET",
            Accept: "aplication/json",
    }).then(function(data) {
       $('.greeting-id').append(data.Longitude);
       $('.greeting-content').append(data.Latitude);
    });
});
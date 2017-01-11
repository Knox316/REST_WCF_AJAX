$(document).ready(function () {
    $("#btnInsert").click(function () {
        jQuery.support.cors=true;
         var idHabitacao = $("#txt1").val();
         var idCliente = $("#txt2").val();
         var preco = $("#txt3").val();
         var ocupado = $("#txt4").val();
         var tipoOcupacao = $("#txt5").val();

         $.ajax({

            url:'http://localhost:2089/Services/Habitacoes.svc/UpdateHabitacao',
            type:'PUT',
            contentType:"application/json",
            dataType: "json",
            //data: '{"":"'+IdHabitacao+'","":"'+IdCliente+'","":"'+Preco+'","":"'+Ocupado+'","":"'+TipoOcupacao+'"}',
            data: {
                'TipoOcupacao': 'idHabitacao', 
                'IdCliente':'idCliente',
                'Preco':'preco',
                'Ocupado':'ocupado',
                'TipoOcupacao':'tipoOcupacao'
            },
            success:function(data){
                $("#tbl").append("<tr><td>" + IdHabitacao + "</td><td>" + IdCliente + "</td><td>" + Preco + "</td><td>" + Ocupado + "</td><td>" + TipoOcupacao + "</td></tr>")
                alert("Inserido com sucesso");
            },
            error: function(e){
                alert("something went wrong");
            }
         });
     });
});
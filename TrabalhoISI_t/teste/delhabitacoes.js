$(document).ready(function () {
    $("#btnInsert").click(function () {
        jQuery.support.cors=true;
         var idHabitacao = $("#txt1").val();
         
         $.ajax({

            url:'http://localhost:2089/Services/Habitacoes.svc/ApagarHabitacao/{ID}',
            type:'DELETE',
            contentType:"application/json",
            dataType: "json",
            //data: '{"":"'+IdHabitacao+'","":"'+IdCliente+'","":"'+Preco+'","":"'+Ocupado+'","":"'+TipoOcupacao+'"}',
            data: {
                'ID': 'idHabitacao', 
                
            },
            success:function(data){
               console.log(data);
            },
            error: function(e){
                alert("something went wrong");
            }
         });
     });
});
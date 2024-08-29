

$(document).ready(function () {
    $('#Emprestimos').DataTable({
        language: {
            "decimal": "",
            "emptyTable": "No data available in table",
            "info": "Mostrando _START_ registro de _END_ em um total de _TOTAL_ entradas",
            "infoEmpty": "Showing 0 to 0 of 0 entries",
            "infoFiltered": "(filtered from _MAX_ total entries)",
            "infoPostFix": "",
            "thousands": ",",
            "lengthMenu": "Mostrar _MENU_ Entradas",
            "loadingRecords": "Loading...",
            "processing": "",
            "search": "Procurar:",
            "zeroRecords": "No matching records found",
            "paginate": {
                "first": "Primeiro",
                "last": "Último",
                "next": "Proximo",
                "previous": "Anterior"
            },
            "aria": {
                "orderable": "Order by this column",
                "orderableReverse": "Reverse order this column"
            }
        }

 
    });


    setTimeout(function () {
        $(".alert").fadeOut("slow", function () { //ENTRANDO NA DIV DE ALERTA E DANDO UM FADEOUT(EFEITO DE SAIDA), 
            $(this).alert('close'); //PASSANDO UMA DURAÇÃO PARA ELE E FAZENDO UMA FUNÇÃO QUE MOSTRA OQUE ELE VAI FAZER 
        })

    }, 5000) //Executando a função de mensagem de sucesso e erro sumir depois de algum tempo

});
let App = {
    Core: {
        CreateTable: function(id) {
            $("#" + id).DataTable({
                "language": {
                    "url": "//cdn.datatables.net/plug-ins/1.10.19/i18n/Spanish.json"
                }
            });      
        }
    },
    Page:{
        Students:{
            List:{
                OnLoad: function() {
                    App.Core.CreateTable("estudiantes");
                }
            }
        }
    }
}
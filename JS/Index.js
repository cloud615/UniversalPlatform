$(function () {
    LoadWebList();
});


function LoadWebList() {
    
    $.ajax({
        url: "../RequestAction/Home/IndexAction.aspx?action=list",
        type: "get",
        data: "",
        success: function (data) {
            var list = $.parseJSON(data);
            var webList = $("#webList");
            var tr;
            var td;
            for (var i = 0; i < list.length; i++) {
                var model = list[i];
                tr = $("<tr></tr>");
                td = $("<td>" + model.ID + "</td><td>" + model.Name + "</td><td><a href=\""+model.URL+"\" target=\"_blank\">" + model.URL + "</a></td>");
                tr.append(td);
                webList.append(tr);
            }
            
        },
        error: function (ex) {

        }
    });

}
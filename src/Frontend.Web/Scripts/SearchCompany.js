var companyId;

$(function () {
    $('a[href*=#modalDelete]').click(function () {
        companyId = companyId = $(this).attr("data-copmpanyId");
        populateDeleteCompanyModal(companyId);
    });

    $('#btnCloseQuestionDelete').click(function () {
        $("#modalDelete").modal('hide');
    });

    $('#confirmQuestionDelete').click(function () {
        deleteCompany(companyId);
        $("#divRow-" + companyId).hide(1000);
        $("#leftNavTotalCompanies").html($("#leftNavTotalCompanies").html() - 1);
        $("#modalDelete").modal('hide');
    });

});

function populateDeleteCompanyModal(companyId) {
    $.ajax({
        type: 'POST',
        url: "/SearchCompany/DeleteDetails/" + companyId,
        cache: false,
        success: function (result) {
            $("#modalDeleteTitle").html(result.companyName.toString() + " löschen");
            $("#spanTitle").html(result.companyName.toString());
        },
        error: function (error) {
            console.log(error);
            alert("Ein Fehler ist aufgetreten");
        }
    });
}

function deleteCompany(companyId) 
{
    $.ajax({
        type: 'POST',
        url: "/SearchCompany/DeleteCompany/" + companyId,
        cache: false,
        error: function (error) {
            console.log(error);
            alert("Ein Fehler ist aufgetreten");
        }
    });    
}
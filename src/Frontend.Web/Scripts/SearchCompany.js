$(function () {
    $('a[href*=#modalDelete]').click(function () {
        var companyIdToDelete = $(this).attr("data-copmpanyId");
        populateDeleteCompanyModal(companyIdToDelete);
    });

    $('#btnCloseQuestionDelete').click(function () {
        $("#modalDelete").modal('hide');
    });

    $('#confirmQuestionDelete').click(function () {
        //deleteQuestion(questionIdToDelete);
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
        },
        error: function (error) {
            console.log(error);
            alert("Ein Fehler ist aufgetreten");
        }
    });
}
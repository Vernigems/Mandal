$(document).ready(function () {
    window.setTimeout(function () {
        $(".toast").fadeTo(1000, 0).slideUp(1000, function () {
            $(this).remove();
        });
    }, 5000);
    GetUserNameAccountDetail();

    $("#AddEditSave").click(function () {        
        //event.preventDefault();
        var emailData = $("#emiAddEditForm").serialize();
        
        if ($("#emiAddEditForm")[0].checkValidity()) {
            $.ajax({
                type: 'POST',
                async: true,
                url: '/account/AddEmi',
                data: emailData,
                beforeSend: function () {
                    //$('.div-loader').removeAttr('hidden');
                },
                success: function (data) {

                    if (data > 0) {
                        setTimeout(function () {
                            $.toast('success', 'Record Add/Edit Successfully1.');
                        }, 1000);
                        $.toast('success', 'Record Add/Edit Successfully2.');
                    }
                    else {
                        setTimeout(function () {
                            $.toast('warning', $("#emiAddEditForm").serializeArray()[3].value + ' Emi Already add.');
                        }, 1000);
                    }
                        

                    $("#AddEmi").modal('hide');
                    //window.location.reload;
                },
                complete: function () {
                    /*$('.div-loader').attr('hidden');*/
                },
                error: function (jqXHR, textStatus, errorThrown) {
                    alert(jqXHR.responseText);
                    //$('.div-loader').attr('hidden');
                }
            });
        }

    })
});

function AddEmi() {
    $("#AddEmi").modal('show');
    $(".emi-modal-title").html("Add Emi");
    $("#NickName").val(getParameterByName("NickName"))
    $("#MemberId").val(getParameterByName("MemberId"))
    $("#TransactionId").val('');
    $("#Emi").val('');
    $("#Intrest").val('');
    $("#Debit").val('');
    $("#Credit").val('');
    $("#Fine").val('');
    $("#Month").val('');
}

function GetUserNameAccountDetail() {
    $("#UserName").html(getParameterByName("NickName"))
}

function getParameterByName(name, url = window.location.href) {
    name = name.replace(/[\[\]]/g, '\\$&');
    var regex = new RegExp('[?&]' + name + '(=([^&#]*)|&|#|$)'),
        results = regex.exec(url);
    if (!results) return null;
    if (!results[2]) return '';
    return decodeURIComponent(results[2].replace(/\+/g, ' '));
}

function EditEmi(TransactionID) {
    $("#AddEmi").modal('show');
    $(".emi-modal-title").html("Edit Emi");

    $.ajax({
        type: 'POST',
        async: true,
        url: '/account/GetEmiById?TransactionId=' + TransactionID,
        beforeSend: function () {
            //$('.div-loader').removeAttr('hidden');
        },
        success: function (data) {
            $("#NickName").val(data[0].nickName);
            $("#MemberId").val(data[0].memberId);
            $("#TransactionId").val(data[0].transactionId);
            $("#Emi").val(data[0].emi);
            $("#Intrest").val(data[0].intrest);
            $("#Debit").val(data[0].debit);
            $("#Credit").val(data[0].credit);
            $("#Fine").val(data[0].fine);
            $("#Month").val(data[0].month);
            //window.location.reload;
        },
        complete: function () {
            /*$('.div-loader').attr('hidden');*/
        },
        error: function (jqXHR, textStatus, errorThrown) {
            alert(jqXHR.responseText);
            //$('.div-loader').attr('hidden');
        }
    });
}

function DeleteEmi(TransactionID) {
    $.ajax({
        type: 'POST',
        async: true,
        url: '/account/DeleteEmi?TransactionId=' + TransactionID,
        beforeSend: function () {

        },
        success: function (data) {

        },
        complete: function () {

        },
        error: function (jqXHR, textStatus, errorThrown) {
            alert(jqXHR.responseText);

        }
    });
}
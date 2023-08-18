$('.checkbox-country').change(function () {
    var listCountrySelect = [];
    $("input:checkbox[name=selected-country]:checked").each(function () {
        listCountrySelect.push($(this).val());
    });
    if (listCountrySelect.length > 0) {
        $('.btn-delete-country').prop("disabled", false);
    } else {
        $('.btn-delete-country').prop("disabled", true);
    }
});


$(document).on('change', '.check-all-country',  function (e) {
    try {
        var listCountrySelect = [];
        $("input:checkbox[name=selected-country]:checked").each(function () {
            listCountrySelect.push($(this).val());
        });
        if (listCountrySelect.length > 0) {
            $('.btn-delete-country').prop("disabled", false);
        } else {
            $('.btn-delete-country').prop("disabled", true);
        }
    } catch (e) {
        console.log(e);
    }
});

$(document).on('click', '.btn-delete-country', async function (event) {
    event.stopImmediatePropagation();
    try {
        $('#modal-confirm-delete').modal('show');
    } catch (e) {
        console.log(e);
    }
});

$(document).on('click', '.btn-confirm-delete-country', async function (event) {
    event.stopImmediatePropagation();
    try {
        $('#modal-confirm-delete').modal('hide');
        var listCountrySelect = [];
        $("input:checkbox[name=selected-country]:checked").each(function () {
            listCountrySelect.push($(this).val());
        });
    } catch (e) {
        console.log(e);
    }
});

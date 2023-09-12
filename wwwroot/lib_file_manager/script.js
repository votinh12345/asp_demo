var lfm_route = document.getElementById('link-file-manager').href;
var show_list;
var sort_type = 'alphabetic';
var multi_selection_enabled = false;
var selected = [];
var items = [];

$.fn.fab = function (options) {
    var menu = this;
    menu.addClass('fab-wrapper');

    var toggler = $('<a>')
        .addClass('fab-button fab-toggle')
        .append($('<i>').addClass('fas fa-plus'))
        .click(function () {
            menu.toggleClass('fab-expand');
        });

    menu.append(toggler);

    options.buttons.forEach(function (button) {
        toggler.before(
            $('<a>').addClass('fab-button fab-action')
                .attr('data-label', button.label)
                .attr('id', button.attrs.id)
                .append($('<i>').addClass(button.icon))
                .click(function () {
                    menu.removeClass('fab-expand');
                })
        );
    });
};

function loadFolders() {
    performLfmRequest('Folders', {})
        .done(function (data) {
            const tree = new Tree(document.getElementById('tree'));
            tree.on('created', (e, node) => {
                e.node = node;
            });
            tree.on('select', e => {
                console.log(tree.hierarchy(e).map(e => e.node));
            });
            tree.json(data);
            loadItems("all", 1);
        });
}
function defaultParameters() {
    return {
        working_dir: $('#working_dir').val(),
        type: $('#type').val()
    };
}

function performLfmRequest(url, parameter) {
    var data = {};
    if (parameter != null) {
        $.each(parameter, function (key, value) {
            data[key] = value;
        });
    }
    return $.ajax({
        type: 'GET',
        beforeSend: function (request) {
            var token =  $('input[name="__RequestVerificationToken"]').val();
            if (token !== null) {
                request.setRequestHeader("Authorization", 'Bearer ' + token);
            }
        },
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',
        url: lfm_route + '/' + url,
        data: data,
        cache: false
    }).fail(function (jqXHR, textStatus, errorThrown) {
        //displayErrorResponse(jqXHR);
    });
}

function loading(show_loading) {
    $('#loading').toggleClass('d-none', !show_loading);
}

function renderListItemFolder(data) {
    let html = '';
    data.forEach(function (item, index) {
        html += '<div class="col-sm-3 col-6 mb-3 text-center">';
        html += '<div class="h-100">';
        if (item.type == "folder") {
            html += '<a href="javascript:void(0)" class="directory mb-1"><i class="fas fa-folder fa-5x"></i></a>';
        } else if (item.type == "file") {
            html += '<a href="javascript:void(0)" class="thumbnail mb-1"><img src="/FileManager/' + item.name + '" alt="profile-pic.png" title="profile-pic.png" class="img-thumbnail"></a>';
        }
        html += '<div>';
        html += '<div class="form-check">';
        html += '<label for="input-path-0" class="form-check-label mt-1">' + item.name + '</label>';
        html += '<input type="checkbox" name="path[]" value="demo" id="input-path-0" class="form-check-input">';
        html += '</div></div></div></div>';
    });
    return html;
}
function loadItems(working_dir, page) {
    loading(true);
    performLfmRequest('GetAllItemOnFolder', { Dir: working_dir, page: page || 1 })
        .done(function (data) {
            let htmlItem = renderListItemFolder(data);
            $('#list-item-folder').empty().append(htmlItem);
        });
}
$(document).ready(function () {
    Dropzone.autoDiscover = false;
    var previewNode = document.querySelector("#template")
    previewNode.id = ""
    var previewTemplate = previewNode.parentNode.innerHTML
    previewNode.parentNode.removeChild(previewNode)

    var myDropzone = new Dropzone(document.body, {
        url: "/target-url", // Set the url
        thumbnailWidth: 80,
        thumbnailHeight: 80,
        parallelUploads: 20,
        previewTemplate: previewTemplate,
        autoQueue: false,
        previewsContainer: "#previews",
        clickable: "#button-upload"
    })

    myDropzone.on("addedfile", function (file) {
        file.previewElement.querySelector(".start").onclick = function () { myDropzone.enqueueFile(file) }
    });

    myDropzone.on("totaluploadprogress", function (progress) {
        document.querySelector("#total-progress .progress-bar").style.width = progress + "%"
    });

    myDropzone.on("sending", function (file) {
        document.querySelector("#total-progress").style.opacity = "1"
        // And disable the start button
        file.previewElement.querySelector(".start").setAttribute("disabled", "disabled")
    });

    // Hide the total progress bar when nothing's uploading anymore
    myDropzone.on("queuecomplete", function (progress) {
        document.querySelector("#total-progress").style.opacity = "0"
    });

    loadFolders();

    $(document).on('click', '#button-folder', function (event) {
        event.stopImmediatePropagation();
        if ($('#modal-folder').hasClass('show')) {
            $('#modal-folder').removeClass('show').fadeOut("slow");
        } else if (!$('#modal-folder').hasClass('show')) {
            $('#modal-folder').addClass('show').fadeIn("slow");
        }
    });

    $(document).on('click', '#button-create', function (event) {
        event.stopImmediatePropagation();

    });

});

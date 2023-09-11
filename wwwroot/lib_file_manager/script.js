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

function loadItems(working_dir, page) {
    loading(true);
    performLfmRequest('GetAllItemOnFolder', { Dir: working_dir, page: page || 1 })
        .done(function (data) {
            console.log(data);
            
        });
}
$(document).ready(function () {
    $('#fab').fab({
        buttons: [
            {
                icon: 'fas fa-upload',
                label: 'Upload',
                attrs: { id: 'upload' }
            },
            {
                icon: 'fas fa-folder',
                label: 'New Folder',
                attrs: { id: 'add-folder' }
            }
        ]
    });

    actions.reverse().forEach(function (action) {
        $('#nav-buttons > ul').prepend(
            $('<li>').addClass('nav-item').append(
                $('<a>').addClass('nav-link d-none')
                    .attr('data-action', action.name)
                    .attr('data-multiple', action.multiple)
                    .append($('<i>').addClass('fas fa-fw fa-' + action.icon))
                    .append($('<span>').text(action.label))
            )
        );
    });

    sortings.forEach(function (sort) {
        $('#nav-buttons .dropdown-menu').append(
            $('<a>').addClass('dropdown-item').attr('data-sortby', sort.by)
                .append($('<i>').addClass('fas fa-fw fa-' + sort.icon))
                .append($('<span>').text(sort.label))
                .click(function () {
                    sort_type = sort.by;
                    loadItems();
                })
        );
    });

    loadFolders();
    performLfmRequest('errors')
        .done(function (response) {
            JSON.parse(response).forEach(function (message) {
                $('#alerts').append(
                    $('<div>').addClass('alert alert-warning')
                        .append($('<i>').addClass('fas fa-exclamation-circle'))
                        .append(' ' + message)
                );
            });
        });

    $(window).on('dragenter', function () {
        $('#uploadModal').modal('show');
    });

    if (usingWysiwygEditor()) {
        $('#multi_selection_toggle').hide();
    }
});

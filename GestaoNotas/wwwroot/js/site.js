// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function PostData(url, data, successCallback)
{
    $.ajax
    ({
        url: url,
        type: 'POST',
        data: data,
        cache: false,
        success: function (Result) {
            successCallback(Result)

        },

        error: function (xhr) {
            toastr["error"]("Erro: Tente novamente")

        }

    })
}
function RequestPartialView(url, requestType, data,successCallback, ReplaceTarget) {
    ReplaceTarget.html("&nbsp;")

    $.ajax
    ({
        url: url,
        type: requestType,
        data: data,
        cache: false,
        success: function (Result) {
            successCallback(Result)

        },

        error: function (xhr) {
            toastr["error"]("Erro: Tente novamente")

        }

    })
}
function RenderPartial(result, replace) {
    $(replace).html(result);
}
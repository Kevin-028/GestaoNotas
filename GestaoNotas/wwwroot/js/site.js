// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function PostData(url, data, successCallback) {

    console.log(url)
    console.log(data)

        $.ajax
            ({
                url: url,
                type: 'POST',
                data: data,
                cache: false,
                success: function (result) {
                    successCallback(result)
                },

                error: function (xhr) {
                    console.log(xhr)
                }
            })
}
//$.ajax
//    ({
//        url: url,
//        type: 'POST',
//        data: new FormData(data),
//        cache: false,
//        success: function (result) {
//            successCallback(result)
//        },

//        error: function (xhr) {
//            console.log(xhr)
//        }
//    })

//type: 'POST',
//    url: url,
//        data: JSON.stringify(data),
//            contentType: "application/json; chatset=utf-8",
//                dataType: "json",
//                    success: function (result) {
//                        successCallback(result)
//                    },

//error: function (xhr) {
//    console.log(xhr)
//}
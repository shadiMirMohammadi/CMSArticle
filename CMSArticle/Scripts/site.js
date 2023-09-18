
function imagePreview(input) {
    if (input.files && input.files[0]) {
        var filerdr = new FileReader();
        filerdr.onload = function (e) {
            jQuery('#newImagePreview').attr('src', e.target.result);
        }
        filerdr.readAsDataURL(input.files[0]);
    }
}

function DeleteCategories(id) {
    $.ajax({

        /*url: '@Url.Action("/Categories/Delete")',*/
        url: "/Categories/DeleteCategories/",
        type: 'POST',
        data: { id: id },

        success: function (res) {
            alert("حذف انجام شد(مجددا تازه سازی کنید)");
        },
        error: function () {
            alert("حذف انجام شد(مجددا تازه سازی کنید)");
        }
    });
}

function DeleteArticles(id) {
    $.ajax({

        /*url: '@Url.Action("/Categories/Delete")',*/
        url: "/Articles/DeleteArticles/",
        type: 'POST',
        data: { id: id },

        success: function (res) {
            alert("حذف انجام شد(مجددا تازه سازی کنید)");
        },
        error: function () {
            alert("حذف انجام شد(مجددا تازه سازی کنید)");
        }
    });
}

function DeleteComment(id) {
    $.ajax({

        /*url: '@Url.Action("/Categories/Delete")',*/
        url: "/Comments/DeleteComment/",
        type: 'POST',
        data: { id: id },

        success: function (res) {
            alert("حذف انجام شد(مجددا تازه سازی کنید)");
        },
        error: function () {
            alert("حذف انجام شد(مجددا تازه سازی کنید)");
        }
    });
}

function UserDelete(id) {
    $.ajax({

        /*url: '@Url.Action("/Categories/Delete")',*/
        url: "/UserRoles/UserDelete/",
        type: 'POST',
        data: { id: id },

        success: function (res) {
            alert("حذف انجام شد(مجددا تازه سازی کنید)");
        },
        error: function () {
            alert("حذف انجام شد(مجددا تازه سازی کنید)");
        }
    });
}

//success: function (res) {
//    $("#List").html(res);
//},


$(function () {
    $('#Content').ckeditor();
});



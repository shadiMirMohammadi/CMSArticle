
function imagePreview(input) {
    if (input.files && input.files[0]) {
        var filerdr = new FileReader();
        filerdr.onload = function (e) {
            jQuery('#newImagePreview').attr('src', e.target.result);
        }
        filerdr.readAsDataURL(input.files[0]);
    }
}

function Delete(id) {
    $.ajax({

        /*url: '@Url.Action("/Categories/Delete")',*/
        url: "/Categories/Delete/",
        type: 'POST',
        data: { id: id },

        success: function (res) {
            alert("حذف انجام شد");
            alert("مجدد صفحه را تازه سازی کنید");
        },
        error: function () {
            alert("حذف انجام شد");
            alert("مجدد صفحه را تازه سازی کنید");
        }
    });
}

//success: function (res) {
//    $("#List").html(res);
//},
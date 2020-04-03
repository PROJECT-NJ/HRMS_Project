function Login() {



    var settings = {
        "url": "/Login/ProcessLogin",
        "method": "POST",
        "async": "false",
        "timeout": 0,
        "headers": {
            "Content-Type": ["application/json", "application/json"]
        },
        "data": JSON.stringify({
            "username": $('#exampleInputEmail').val(),
            "password": $('#exampleInputPassword').val()
        }),
    };

    $.ajax(settings).done(function (response) {
        console.log(response);
        if (response == "success") {
            window.location.href = "Employee/Home";
        } else {

        }
    });


    //var serviceURL = '/Login/ProcessLogin2';
    //console.log(DataModel);
    //$.ajax({
    //    type: 'POST',
    //    dataType: 'json',
    //    contentType: 'application/json; charset=utf-8',
    //    data: DataModel,
    //    url: serviceURL,
    //    async: false,
    //    success: function (data) {
    //        console.log(111111);
    //        console.log(data);
    //        var res = data.replace(/\"/g, '');
    //        console.log(res);
    //        if (res == "success") {

    //        } else {

    //        }
    //    },
    //    error: function (xhr, status, error) {
    //        console.log(22222);
    //        if (xhr.status == 401) {
    //            window.location.href = "SessionExpire";
    //            return;
    //        }

    //    }
    //});

}
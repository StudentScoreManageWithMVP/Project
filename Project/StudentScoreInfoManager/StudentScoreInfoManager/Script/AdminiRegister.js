//姓名
$('.input_class').eq(0).blur(function () {
    if ($(this).val() == "") {
        $(this).next('label').html("*不能为空");
    }
    else if ($(this).val().length <= 1 || $(this).val().length > 40) {
        $(this).next('label').html("*姓名长度必须在2-40个字符内");
    }
    else {
        $(this).next('label').html("*");
    }
});
//密码
$('.input_class').eq(1).blur(function () {
    if ($(this).val() == "") {
        $(this).next('label').html("*不能为空");
    }
    else if ($(this).val().length < 3 || $(this).val().length > 8) {
        $(this).next('label').html("*密码长度必须在3-8个字符内");
    }
    else {
        $(this).next('label').html("*");
    }
});
//确认密码
$('.input_class').eq(2).blur(function () {
    if ($(this).val() == "") {
        $(this).next('label').html("*不能为空");
    }
    else if ($(this).val() != $('.input_class').eq(1).val()) {
        $(this).next('label').html("*密码不一致");
    }
    else {
        $(this).next('label').html("*");
    }
});
//性别
$('.input_class').eq(3).blur(function () {
    if ($(this).val() == "") {
        $(this).next('label').html("*不能为空");
    }
    else {
        $(this).next('label').html("*");
    }
});
//年龄
$('.input_class').eq(4).blur(function () {
    if ($(this).val() != "") {
        if (Number($(this).val()) <= 0 || Number($(this).val()) > 65) {
            $(this).next('label').html("*年龄必须在0-65之间");
        }
        else {
            $(this).next('label').html("");
        }
    }
});
//手机号码
$('.input_class').eq(5).blur(function () {
    if ($(this).val() != "") {
        if (!$(this).val().match(/^1\d{10}$/)) {
            $(this).next('label').html("*请输入正确格式的手机号码");
        }
        else {
            $(this).next('label').html("");
        }
    }
});
//出生地
$('.input_class').eq(6).blur(function () {
    if ($(this).val() != "") {
        if ($(this).val().length <= 0 || $(this).val().length > 40) {
            $(this).next('label').html("*字数必须在40字以内");
        } else {
            $(this).next('label').html("");
        }
    }
});
$('.textarea_class').eq(0).blur(function () {
    if ($(this).val().length > 200) {
        $(this).next('label').html("*字数必须在200字以内");
    } else {
        $(this).next('label').html("");
    }
});
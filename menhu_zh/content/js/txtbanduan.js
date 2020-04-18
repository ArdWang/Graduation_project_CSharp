window.onload = function () {
    regx(thisObj);
    //getsize();
}
function regx(thisObj) {
    var lbe = document.getElementById('lbe');
    var tvs = thisObj.value;
    if (tvs.search(/</) >= 0) {

        alert("警告！不允许输入该字符。");
        thisObj.value = tvs.substr(0, tvs.indexOf("<"));
    }
    if (tvs.search(/>/) >= 0) {

        alert("警告！不允许输入该字符。");
        thisObj.value = tvs.substr(0, tvs.indexOf(">"));
    }
    if (tvs.search(/&/) >= 0) {

        alert("警告！不允许输入该字符。");
        thisObj.value = tvs.substr(0, tvs.indexOf("&"));
    }
}

/*自动修改图片的大小
function getsize() {
    var img = new Image();
    img.src = document.getElementById("imgxy1").value;
    if (img.width >= 560 || img.height >= 300)
    {
        img.width = 560;
        img.height = 300;
    }
    
}*/

function getsize()//缩略图
{
    var pic_array = document.img;
    var pic_num = pic_array.length;
    var width = 80;
    var height = 80;
    var offset_height;
    var offset_width;
    var nh = 1;
    for (var i = 0; i < pic_num; i++) {
        offset_height = pic_array[i].offsetHeight;
        offset_width = pic_array[i].offsetWidth;
        if (offset_width > offset_height && pic_array[i].className == "abbr") {
            nh = width / offset_width;
            pic_array[i].height = offset_height * nh;
            pic_array[i].width = width;
        }
        else if (pic_array[i].className == "abbr") {
            nh = height / offset_height;
            pic_array[i].height = height;
            pic_array[i].width = offset_width * nh;
        }
    }
}
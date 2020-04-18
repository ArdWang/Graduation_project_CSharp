/*汽车频道显示的JS代码*/
window.onload = function() {
    focusChange();
    Shangpin();
    Meishi();
    mainfun("movePic1", 5000);
    //gotoTop();

}
function qc(id) { return document.getElementById(id); }
function moveElement(elementID, final_x, final_y, interval) {
    if (!document.getElementById) return false;
    if (!document.getElementById(elementID)) return false;
    var elem = document.getElementById(elementID);
    if (elem.movement) {
        clearTimeout(elem.movement);
    }
    if (!elem.style.left) {
        elem.style.left = "0px";
    }
    if (!elem.style.top) {
        elem.style.top = "0px";
    }
    var xpos = parseInt(elem.style.left);
    var ypos = parseInt(elem.style.top);
    if (xpos == final_x && ypos == final_y) {
        return true;
    }
    if (xpos < final_x) {
        var dist = Math.ceil((final_x - xpos) / 10);
        xpos = xpos + dist;
    }
    if (xpos > final_x) {
        var dist = Math.ceil((xpos - final_x) / 10);
        xpos = xpos - dist;
    }
    if (ypos < final_y) {
        var dist = Math.ceil((final_y - ypos) / 10);
        ypos = ypos + dist;
    }
    if (ypos > final_y) {
        var dist = Math.ceil((ypos - final_y) / 10);
        ypos = ypos - dist;
    }
    elem.style.left = xpos + "px";
    elem.style.top = ypos + "px";
    var repeat = "moveElement('" + elementID + "'," + final_x + "," + final_y + "," + interval + ")";
    elem.movement = setTimeout(repeat, interval);
}

function classNormal() {
    var focusBtnList = qc('focus_change_btn').getElementsByTagName('li');
    for (var i = 0; i < focusBtnList.length; i++) {
        focusBtnList[i].className = '';
    }
}

function focusChange() {
    var focusBtnList = qc('focus_change_btn').getElementsByTagName('li');
    focusBtnList[0].onmouseover = function () {
        moveElement('focus_change_list', 0, 0, 5);
        classNormal()
        focusBtnList[0].className = 'current'
    }
    focusBtnList[1].onmouseover = function () {
        moveElement('focus_change_list', -320, 0, 5);
        classNormal()
        focusBtnList[1].className = 'current'
    }
    focusBtnList[2].onmouseover = function () {
        moveElement('focus_change_list', -640, 0, 5);
        classNormal()
        focusBtnList[2].className = 'current'
    }
    focusBtnList[3].onmouseover = function () {
        moveElement('focus_change_list', -960, 0, 5);
        classNormal()
        focusBtnList[3].className = 'current'
    }
}

//商品展示区JS代码
function Shangpin() {
    var Oul = document.getElementById("wz");
    var Oli = Oul.getElementsByTagName("li");
    for (var i = 0; i < Oli.length; i++) {
        Oli[i].index = i; //使用对象的任意属性来保存变量值,这是循环语句的关键地方
        Oli[i].onmouseover = function() {
            //alert(this.index);
            for (var j = 0; j <= 3; j++) {
                if (this.index == j) {

                    var Odiv = document.getElementById("a" + (j + 1));
                    Odiv.style.display = "block";
                    this.style.backgroundColor = "#666";
                    this.style.color = "white";
                }
                else {
                    var Odiv = document.getElementById("a" + (j + 1));
                    Odiv.style.display = "none";
                    Oli[j].style.backgroundColor = "";
                    Oli[j].style.color = "";
                }
            }
        }
        Oli[i].onmouseout = function() {
            this.style.backgroundColor = "";
            this.style.color = "";
        }
    }
}

/*美食图片js代码*/
function Meishi() {
    var Oul = document.getElementById("ms_min");
    var Oli = Oul.getElementsByTagName("li");
    for (var i = 0; i < Oli.length; i++) {
        Oli[i].index = i; //使用对象的任意属性来保存变量值,这是循环语句的关键地方
        Oli[i].onmouseover = function () {
            //alert(this.index);
            for (var j = 0; j <= 3; j++) {
                if (this.index == j) {

                    var Odiv = document.getElementById("b" + (j + 1));
                    Odiv.style.display = "block";
                    this.style.backgroundColor = "";
                    this.style.color = "white";
                }
                else {
                    var Odiv = document.getElementById("b" + (j + 1));
                    Odiv.style.display = "none";
                    Oli[j].style.backgroundColor = "";
                    Oli[j].style.color = "";
                }
            }
        }
        Oli[i].onmouseout = function () {
            this.style.backgroundColor = "";
            this.style.color = "";
        }
    }
}

//旅游图片显示
function mainfun(mainObj, t) { //mianfun是层 而t代表的是时间
    function getID(id) { return document.getElementById(id) }
    function getTag(tag, obj) {
        return (typeof obj == 'object' ? obj : getID(obj)).getElementsByTagName(tag);
    }
    var cut = 0;
    var timer = '';
    var num = getTag('li', getTag('div', getID(mainObj))[0]).length;
    var getpic = getTag('li', getTag('div', getID(mainObj))[0]);
    var getbtn = getTag('li', getTag('div', getID(mainObj))[1]);
    var gettext = getTag('li', getTag('div', getID(mainObj))[2]);
    for (i = 0; i < num; i++) {
        getpic[i].style.display = "none";
        gettext[i].style.display = "none";
        getbtn[i].onclick = (function (i) {
            return function () {
                getbtn[i].className = "sel";
                changePic(i);
            }
        })(i);
    }
    getpic[cut].style.display = "block";
    getbtn[cut].className = "sel";
    gettext[cut].style.display = "block";
    getID(mainObj).onmouseover = function () {
        clearInterval(timer);
    }
    getID(mainObj).onmouseout = function () {
        timer = setInterval(autoPlay, t);
    }

    function changePic(ocut) {
        for (i = 0; i < num; i++) {
            cut = ocut;
            getpic[i].style.display = "none";
            getbtn[i].className = ""
            gettext[i].style.display = "none";
        }
        getpic[cut].style.display = "block";
        getbtn[cut].className = "sel";
        gettext[cut].style.display = "block"
    }

    function autoPlay() {
        if (cut >= num - 1) { cut = 0; }
        else { cut++; }
        changePic(cut);
    }
    timer = setInterval(autoPlay, t);
}

/*此代码放弃*/
function gotoTop(min_height) {
    //预定义返回顶部的html代码，它的css样式默认为不显示 
    var gotoTop_html = '<div id="gotoTop">返回顶部</div>';
    //将返回顶部的html代码插入页面上id为page的元素的末尾 
    $("#page").append(gotoTop_html);
    $("#gotoTop").click(//定义返回顶部点击向上滚动的动画 
    function () {
        $('html,body').animate({ scrollTop: 0 }, 700);
    }).hover(//为返回顶部增加鼠标进入的反馈效果，用添加删除css类实现 
    function () { $(this).addClass("hover"); },
    function () {
        $(this).removeClass("hover");
    });
    //获取页面的最小高度，无传入值则默认为600像素 
    min_height ? min_height = min_height : min_height = 600;
    //为窗口的scroll事件绑定处理函数 
    $(window).scroll(function () {
        //获取窗口的滚动条的垂直位置 
        var s = $(window).scrollTop();
        //当窗口的滚动条的垂直位置大于页面的最小高度时，让返回顶部元素渐现，否则渐隐 
        if (s > min_height) {
            $("#gotoTop").fadeIn(100);
        } else {
            $("#gotoTop").fadeOut(200);
        };
    });
};


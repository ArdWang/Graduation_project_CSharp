window.onload = function () {
    Banner();
}
function Banner() {
    var odiv = document.getElementById("n_right");
    var oli = odiv.getElementsByTagName("li");
    for (var i = 0; i < oli.length; i++) {
        oli[i].onmouseover = function () {
            this.className = "show";
            this.style.backgroundColor = "#4b72f2";
        }
        oli[i].onmouseout = function () {
            this.className = "";
            this.style.backgroundColor = "";
        }
    }
}
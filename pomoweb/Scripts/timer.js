var sec = 00;
var min = 25;
var IsStarted = false;
var time = "";
var SD;

function DateReplace(replaceText) {
    var text = "";
    var img = " <img src='Content/themes/base/images/numbers/";
    for (var i = 0; i < replaceText.length; i++) {
        if (replaceText[i] == ":") {
            text += img + "colon2.gif'/> ";
        }
        if (isNaN(replaceText[i]) == false)
        {
            text += img + replaceText[i] + ".gif'/> ";
        }
    }
    return text;
}

function countDown() {
    if (IsStarted == false) {
        return;
    }
    sec--;
    if (sec == -01) {
        sec = 59;
        min = min - 1;
    }
    else {
        min = min;
    }

    if (sec <= 9) { sec = "0" + sec; }

    time = (min <= 9 ? "0" + min : min) + ":" + sec;

    if (document.getElementById) {
        document.getElementById('dial').innerHTML = DateReplace(time);
    }

    SD = window.setTimeout("countDown();", 1000);
    if (min == '00' && sec == '00') { sec = "00"; window.clearTimeout(SD); }
}

function registerEvents() {
    var elt = document.getElementById("start_btn");
    
    elt.onclick = function () {
        if (IsStarted == false) {
            IsStarted = true;
            elt.innerHTML = "Stop timer";
            countDown();
        } else {
            IsStarted = false;
            elt.innerHTML = "Start timer";
        }
        
        min = 25;
        sec = 00;
        document.getElementById('dial').innerHTML = DateReplace("25:00");
    };
}

function Init_Scripts() {
    document.getElementById('dial').innerHTML = DateReplace("25:00");
    registerEvents();
}

window.onload = Init_Scripts;
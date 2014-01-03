var sec = 00;   // set the seconds
var min = 25;   // set the minutes

function DateReplace ($ReplaceText)
{
    $Numbers=array(
		'1' => "<img src='~/images/numbers/1.gif' />",
		'2' => "<img src='~/images/numbers/2.gif' />",
		'3' => "<img src='~/images/numbers/3.gif' />",
		'4' => "<img src='~/images/numbers/4.gif' />",
		'5' => "<img src='~/images/numbers/5.gif' />",
		'6' => "<img src='~/images/numbers/6.gif' />",
		'7' => "<img src='~/images/numbers/7.gif' />",
		'8' => "<img src='~/images/numbers/8.gif' />",
		'9' => "<img src='~/images/numbers/9.gif' />",
		'0' => "<img src='~/images/numbers/0.gif' />"
	);

    $Date=str_replace(array_keys($Numbers), array_values($Numbers), $ReplaceText);

    return $Date;	
}

function countDown() {
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

    if (document.getElementById) { document.getElementById('dial').innerHTML = time; }

    SD = window.setTimeout("countDown();", 1000);
    if (min == '00' && sec == '00') { sec = "00"; window.clearTimeout(SD); }
}
window.onload = countDown;
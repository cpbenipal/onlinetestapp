//Disable back button
window.history.forward();

//Disable right click
document.onmousedown = disableclick;
status = "";
function disableclick(e) {
    if (event.button == 2) {
        alert("Right Click Disabled!");
        return false;
    }

    document.onkeydown = function () {
        switch (event.keyCode) {
            case 116: //F5 button
                event.returnValue = false;
                event.keyCode = 0;
                return false;
            case 8: //F5 button
                event.returnValue = false;
                event.keyCode = 0;
                return false;

            case 82: //R button
                if (event.ctrlKey) {
                    event.returnValue = false;
                    event.keyCode = 0;
                    return false;
                }
        }
    }
}

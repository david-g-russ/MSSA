var i = 0;
function countNumbers() {
    if (i < 500) {
        i++;
        postMessage(i); // web worker communicates with web page by posting messages
    }
    setTimeout("countNumbers()", 500); // intentional delay
}
countNumbers(); // first time call
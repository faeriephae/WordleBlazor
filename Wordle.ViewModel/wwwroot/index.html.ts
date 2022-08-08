//Focus Square/letter input
const setFocus = function getFocus(e: Element) {
    document.getElementById(e.id).focus();
}

const setBreak = function insertBreak(e: Element) {
    document.getElementById(e.id).append("<br>");
}


class StringBuilder {
    constructor(value) {
        this.strings = new Array();
        this.append(value);
    }
    append(value) {
        if (value) {
            this.strings.push(value);
        }
    }
    clear() {
        this.strings.length = 0;
    }
    toString() {
        return this.strings.join("");
    }
}

/*
function StringBuilder(value) {
    this.strings = new Array();
    this.append(value);
}
StringBuilder.prototype.append = function(value) {
    if (value) {
        this.strings.push(value);
    }
}
StringBuilder.prototype.clear = function() {
    this.strings.length = 0;
}
StringBuilder.prototype.toString = function() {
    return this.strings.join("");
}
*/

var sb = new StringBuilder();
sb.append("This is");
sb.append("much better looking");
sb.append("than using +=");
// joins the string
var myString = sb.toString();
// Cleans out the string buffer in the StringBuilder.
// This effectively makes it empty in case you did not
// know what cleaning out a buffer in this context
// meant.
sb.clear();
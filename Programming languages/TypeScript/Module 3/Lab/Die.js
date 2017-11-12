"use strict";
exports.__esModule = true;
var Die = /** @class */ (function () {
    function Die(div) {
        this.div = div;
    }
    Die.prototype.ChangeText = function (text) {
        var elem = this.div;
        elem.innerText = text;
    };
    return Die;
}());
exports["default"] = Die;

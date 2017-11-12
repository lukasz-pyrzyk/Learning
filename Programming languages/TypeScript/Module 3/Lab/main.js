"use strict";
exports.__esModule = true;
var Die_js_1 = require("./Die.js");
var Chance = require("chance");
var elementSets = [];
for (var index = 0; index < 4; index++) {
    var div = document.createElement('div');
    var die = new Die_js_1["default"](div);
    elementSets.push(die);
    document.body.appendChild(div);
}
var Values;
(function (Values) {
    Values[Values["One"] = 0] = "One";
    Values[Values["Two"] = 1] = "Two";
    Values[Values["Three"] = 2] = "Three";
    Values[Values["Four"] = 3] = "Four";
    Values[Values["Five"] = 4] = "Five";
})(Values || (Values = {}));
var button = document.createElement('button');
button.onclick = function (event) {
    var chance = new Chance();
    elementSets.forEach(function (e) {
        var index = chance.integer({ min: 0, max: 4 });
        var text = Values[index];
        e.ChangeText(text);
    });
};
document.body.appendChild(button);

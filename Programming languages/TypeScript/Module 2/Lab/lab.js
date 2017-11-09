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
var elementSets = [];
for (var index = 0; index < 4; index++) {
    var div = document.createElement('div');
    var die = new Die(div);
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
    elementSets.forEach(function (e) {
        var index = getRandomIntInclusive(0, 4);
        var text = Values[index];
        e.ChangeText(text);
    });
};
var getRandomIntInclusive = function (min, max) {
    min = Math.ceil(min);
    max = Math.floor(max);
    return Math.floor(Math.random() * (max - min + 1)) + min;
};
document.body.appendChild(button);

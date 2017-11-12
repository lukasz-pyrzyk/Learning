import Die from './Die.js'
import Chance = require('chance');

let elementSets: Array<Die> = [];
for (let index: number = 0; index < 4; index++) {
    let div: Element = document.createElement('div')
    let die = new Die(div);
    elementSets.push(die)
    document.body.appendChild(div);
}

enum Values {
    One,
    Two,
    Three,
    Four,
    Five
}

let button: Element = document.createElement('button');
(button as HTMLElement).onclick = (event) => {
    let chance = new Chance();
    elementSets.forEach(e => {
        let index = chance.integer({ min: 0, max: 4 });        
        let text = Values[index];
        e.ChangeText(text)
    });
}

document.body.appendChild(button);
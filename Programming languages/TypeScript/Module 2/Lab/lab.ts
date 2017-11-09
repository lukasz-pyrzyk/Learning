class Die {
    div : Element;
    constructor(div : Element) {
        this.div = div;
    }

    public ChangeText(text : string){
        let elem = this.div as HTMLElement;
        elem.innerText = text;
    }
}

let elementSets : Array<Die> = [];
for (let index: number = 0; index < 4; index++) {
    let div : Element = document.createElement('div')
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

let button : Element = document.createElement('button');
(button as HTMLElement).onclick = (event) => {
    elementSets.forEach(e => {
        let index = getRandomIntInclusive(0, 4);
        let text = Values[index]; 
        e.ChangeText(text)
    });
}

let getRandomIntInclusive: Function = (min, max) => {
    min = Math.ceil(min);
    max = Math.floor(max);
    return Math.floor(Math.random() * (max - min + 1)) + min;
}

document.body.appendChild(button);
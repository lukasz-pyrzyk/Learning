class ColorChange {
    div: Element;
    constructor(div: Element) {
        this.div = div; 
    }

    public changeColor(color: string) {
        (this.div as HTMLElement).style.backgroundColor = color;
    }
}

interface ElementSet {
    'div': Element,
    'button': Element
}

enum Colors {
    Green,
    Red,
    Blue,
    Orange
}

let elementSets : Array<ElementSet> = [];
let squareSizeNum = 100
let squareSize = `${ squareSizeNum }px`;

for (let index: number = 0; index < 4; index++) {
    elementSets.push({
        'div': document.createElement('div'),
        'button': document.createElement('button')
    })
}

elementSets.map((elem, index) => {
    let v = new ColorChange(elem.div);
    (elem.div as HTMLElement).style.width = squareSize;
    (elem.div as HTMLElement).style.height = squareSize;
    elem.button.textContent = "Change Color";
    (elem.button as HTMLElement).onclick = (event) => {
        v.changeColor(Colors[index]);
    }

    document.body.appendChild(elem.button);
    document.body.appendChild(elem.div);
});
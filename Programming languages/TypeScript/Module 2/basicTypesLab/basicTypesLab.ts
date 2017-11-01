let color = "green"
let squareSizeNum = 100
let squareSize = `${ squareSizeNum }px`;


let button: Element = document.createElement('button');
let div: Element = document.createElement('div');

button.textContent = "Change Color";


(div as HTMLElement).style.width = squareSize;
(div as HTMLElement).style.height = squareSize;

let colorChange: Function = (elem : Element, color : string): boolean => {
    (<HTMLElement>elem).style.backgroundColor = color;
    return true;
}

(button as HTMLElement).onclick = (event) => {
    colorChange(div, color);
}

document.body.appendChild(button);
document.body.appendChild(div);
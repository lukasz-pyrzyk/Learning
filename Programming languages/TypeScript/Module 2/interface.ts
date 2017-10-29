function printLabel(labelledObj: { label: string }) {
    console.log(labelledObj.label);
}

let myObj = {size: 10, label: "Size 10 Object"};
printLabel(myObj);


// This can be also written as:

interface LabelledValue{
    label: string
}

function printLabelViaInterace(obj : LabelledValue) {
    console.log(obj.label);
}

// Optional properties:
interface SquareConfig {
    color? : string;
    width? : number;
}

function CreateSquare(config: SquareConfig) : {color: string, area : number} {
    let newSquare = {color: "white", area: 15};
    if(config.color){
        newSquare.color = config.color;
    }
    if(config.width){
        newSquare.area = config.width * config.width;
    }


    return newSquare;
}

let mySquare = CreateSquare({color: "black"})

// read only!
interface Point {
    readonly x: number;
    readonly y: number;
}

let p1 : Point = {x: 5, y: 6};
// p1.x = 5; // error!


let a : number[] = [1, 2, 3]
let readonlyNumbers : ReadonlyArray<number> = a;
let b = readonlyNumbers as number[];
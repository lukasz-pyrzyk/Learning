let someVariable : string;

someVariable = "this is a string";

// someVariable = 3; invalid type

let numArray : Array<any> = [
    1,
    2,
    'interruping code',
    {
        index: 3,
        title: "title!"
    }
]

let add1 = (num : number) => {
    return 1 + num;
}

numArray.map((item) => {
    alert(add1(item));
    return item;
});


let someString : string;
let someNumber : number;
let trueorFalse : boolean;
let someArray : Array<any>
let someElement : Element;
let someObject: object;
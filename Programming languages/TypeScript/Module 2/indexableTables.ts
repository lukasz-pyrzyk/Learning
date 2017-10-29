interface StringArray {
    [index: number]: string;
}

let myArray: StringArray;
myArray = ["Bob", "Fred"];
let myStr: string = myArray[0];

interface MyObjectArray {
    [index: number] : {age: number, name: string};
}

let persons : MyObjectArray;
persons = [{age: 14, name: "Lukasz"}];
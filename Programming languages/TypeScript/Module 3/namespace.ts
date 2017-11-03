namespace SomeNameSpace {
    let someVariable = "string";

    export namespace internalNameSpace {
        export let internalVariable = "string";
    }
    export let somePublicVariable = "string";
    export function someFunction () {
        
    }

    export class someClass {
    }
}

SomeNameSpace.someFunction();
let localVariable = SomeNameSpace.somePublicVariable;
let instanceOfClass = new SomeNameSpace.someClass();
let someValueFromLongVariable = SomeNameSpace.internalNameSpace.internalVariable;
import internalSpace = SomeNameSpace.internalNameSpace;
let someShorterVariable = internalSpace.internalVariable;



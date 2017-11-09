// Named function
function add(x, y) {
    return x + y;
}

// Anonymous function
let myAdd = function(x, y) { return x+y; };

let z = 100;

function addToZ(x, y) {
    return x + y + z;
}

// it can be also written as
let myAdd1: (baseValue:number, increment:number) => number =
    function(x: number, y: number): number { 
        return x + y; 
    };


// Optional and default parameters:
function buildName(firstName: string, lastName: string) {
    return firstName + " " + lastName;
}

// let result1 = buildName("Bob");                  // error, too few parameters
// let result2 = buildName("Bob", "Adams", "Sr.");  // error, too many parameters
let result3 = buildName("Bob", "Adams");         // ah, just right

function buildNameWithOptional(firstName: string, lastName?: string) {
    if (lastName)
        return firstName + " " + lastName;
    else
        return firstName;
}

let result11 = buildNameWithOptional("Bob");                  // works correctly now
// let result22 = buildNameWithOptional("Bob", "Adams", "Sr.");  // error, too many parameters
let result33 = buildNameWithOptional("Bob", "Adams");         // ah, just right


// DEFAULT
function buildNameWithDefault(firstName = "Will", lastName: string) {
    return firstName + " " + lastName;
}

// let result111 = buildNameWithDefault("Bob");                  // error, too few parameters
// let result222 = buildNameWithDefault("Bob", "Adams", "Sr.");  // error, too many parameters
let result333 = buildNameWithDefault("Bob", "Adams");         // okay and returns "Bob Adams"
let result444 = buildNameWithDefault(undefined, "Adams");     // okay and returns "Will Adams"


// REST parameters
function buildNameWithRest(firstName: string, ...restOfName: string[]) {
    return firstName + " " + restOfName.join(" ");
}

let employeeName = buildNameWithRest("Joseph", "Samuel", "Lucas", "MacKinzie");
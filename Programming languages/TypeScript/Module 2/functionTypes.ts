interface SearchFunc {
    (source: string, subString: string): boolean;
}

let mySearch: SearchFunc;
mySearch = function(source: string, subString: string) : boolean {
    let result = source.search(subString);
    return result > -1;
}

// name of the arguments can be different
mySearch = function(src: string, sub: string) : boolean {
    let result = src.search(sub);
    return result > -1;
}

// types of the arguments can be skipped
mySearch = function(src, sub) {
    let result = src.search(sub);
    return result > -1;
}
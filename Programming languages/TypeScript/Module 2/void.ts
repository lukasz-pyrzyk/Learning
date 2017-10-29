function warnUser(): void {
    alert("This is my warning message");
}

let unusable: void = undefined;
let unusable1: void = null;
let unusable2: () => void = warnUser;
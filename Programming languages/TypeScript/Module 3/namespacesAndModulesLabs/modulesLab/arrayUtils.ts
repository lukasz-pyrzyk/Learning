namespace ArrayUtilities {
    export function reverseArray(array: Array<number>) {
        return array.slice(0).reverse();
    }

    export function firstItemOfArray(array: Array<number>) {
        return array.slice(0).shift();
    }

    export function lastItemOfArray(array: Array<number>) {
        return array.slice(0).pop();
    }

    export function concat(left : Array<number>, right : Array<number>) {
        return left.concat(right);
    }
}
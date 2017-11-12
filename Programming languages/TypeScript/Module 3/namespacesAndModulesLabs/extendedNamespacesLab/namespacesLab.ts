/// <reference path="extendedNamespacesLab_part2.ts" />

namespace ArrayUtilities {
    export function firstItemOfArray(array: Array<number>) {
        return array.slice(0).shift();
    }

    export function concat(left : Array<number>, right : Array<number>) {
        return left.concat(right);
    }
}
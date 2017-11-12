var ArrayUtilities;
(function (ArrayUtilities) {
    function reverseArray(array) {
        return array.slice(0).reverse();
    }
    ArrayUtilities.reverseArray = reverseArray;
    function firstItemOfArray(array) {
        return array.slice(0).shift();
    }
    ArrayUtilities.firstItemOfArray = firstItemOfArray;
    function lastItemOfArray(array) {
        return array.slice(0).pop();
    }
    ArrayUtilities.lastItemOfArray = lastItemOfArray;
    function concat(left, right) {
        return left.concat(right);
    }
    ArrayUtilities.concat = concat;
})(ArrayUtilities || (ArrayUtilities = {}));

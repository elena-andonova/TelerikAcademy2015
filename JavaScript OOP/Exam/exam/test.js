var issbn = '0134567890';

function isIsbnValid(str) {
    var digitsOnly = /^[0-9]+$/;
    return typeof(str) === 'string' &&
        str.match(digitsOnly) !== null &&
        (str.length === 10 || str.length === 13);
}

console.log(isIsbnValid(issbn))
console.log(issbn.match(/^[0-9]+$/))



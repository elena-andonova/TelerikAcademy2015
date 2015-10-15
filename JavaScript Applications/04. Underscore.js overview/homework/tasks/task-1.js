/* 
Create a function that:
*   Takes an array of students
    *   Each student has a `firstName` and `lastName` properties
*   **Finds** all students whose `firstName` is before their `lastName` alphabetically
*   Then **sorts** them in descending order by fullname
    *   fullname is the concatenation of `firstName`, ' ' (empty space) and `lastName`
*   Then **prints** the fullname of founded students to the console
*   **Use underscore.js for all operations**
*/
var _ = require('underscore');

function solve() {

    return function(students) {
        var students = students;
        var filtered = _.filter(students, function(student) {
            return student.firstName < student.lastName;
        });

        var mapped = _.map(filtered, function(student) {
            return student.firstName + ' ' + student.lastName;
        });

        var ordered = _.sortBy(mapped, function(fullname){
        	return fullname;
        }).reverse();

        _.forEach(ordered, function(fullname) {
            console.log(fullname);
        });
    };
}

// var students = [{
//     firstName: 'NAME #3',
//     lastName: 'NAME #2'
// }, {
//     firstName: 'NAME #4',
//     lastName: 'NAME #1'
// }, {
//     firstName: 'Alpha',
//     lastName: 'Beta'
// }];


// var testFunc = solve();
// testFunc(students);

module.exports = solve;

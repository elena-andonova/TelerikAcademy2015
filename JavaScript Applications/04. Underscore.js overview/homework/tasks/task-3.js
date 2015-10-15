/* 
Create a function that:
*   Takes an array of students
    *   Each student has:
        *   `firstName`, `lastName`, `age` and `marks` properties
        *   `marks` is an array of decimal numbers representing the marks         
*   **finds** the student with highest average mark (there will be only one)
*   **prints** to the console  'FOUND_STUDENT_FULLNAME has an average score of MARK_OF_THE_STUDENT'
    *   fullname is the concatenation of `firstName`, ' ' (empty space) and `lastName`
*   **Use underscore.js for all operations**
*/


var _ = require('underscore');


function solve() {
    return function(students) {
        var students = students;

        // var filteredByAvg = _.sortBy(students, function(student) {
        //     return -(_.reduce(student.marks, function(a, b) {
        //         return (a + b);
        //     }) / student.marks.length);
        // });


        var filteredByAvg = _.sortBy(students, function(student) {
            student.marks = _.reduce(student.marks, function(a, b) {
                return (a + b);
            }) / student.marks.length;

            return -student.marks;
        });

        var student = _.first(filteredByAvg, 1);

        // var mapped = _.map(filtered, function(student) {
        //     return student.firstName + ' ' + student.lastName;
        // });

        // var ordered = _.sortBy(mapped, function(fullname) {
        //     return fullname;
        // });

        _.forEach(student, function(student) {
            var fullname = student.firstName + ' ' + student.lastName;
            var avgMark = student.marks;
            console.log(fullname + ' has an average score of ' + avgMark);
        });

    };
}

// var students = [{
//     firstName: 'Stanimir',
//     lastName: 'Jakov',
//     age: 24,
//     marks: [6, 4]
// }, {
//     firstName: 'Stanimir',
//     lastName: 'Jakov',
//     age: 17,
//     marks: [5, 5]
// }, {
//     firstName: 'Frederick',
//     lastName: 'Jacob',
//     age: 1,
//     marks: [4.2, 3.7]
// }, {
//     firstName: 'Joukahainen',
//     lastName: 'Valerian',
//     age: 1,
//     marks: [4, 3.7]
// }, {
//     firstName: 'Teodor',
//     lastName: 'Mervyn',
//     age: 8,
//     marks: [6, 1.2]
// }, {
//     firstName: 'Kristaps',
//     lastName: 'lfsige',
//     age: 30,
//     marks: [7.3, 6.9]
// }, {
//     firstName: 'Varnava',
//     lastName: 'Peter',
//     age: 42,
//     marks: [3, 4]
// }, {
//     firstName: 'Aibek',
//     lastName: 'Patricio',
//     age: 9,
//     marks: [7, 8]
// }, {
//     firstName: 'Lovre',
//     lastName: 'Thoko',
//     age: 11,
//     marks: [2, 10]
// }, {
//     firstName: 'Ambrosius',
//     lastName: 'Volos',
//     age: 26,
//     marks: [4, 4.2]
// }];

// var testFunc = solve();
// testFunc(students);

module.exports = solve;

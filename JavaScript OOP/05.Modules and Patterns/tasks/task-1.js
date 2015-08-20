function solve() {
    function isTitleValid(title) {
        var white = ' ';
        var consWhite = /\s{2,}/;

        if (typeof(title) !== 'string' || title.length < 1) {
            return false;
        };
        if (title[0] === white || title[title.length - 1] === white) {
            return false;
        };

        if (consWhite.test(title) === true) {
            return false;
        };

        return true;
    }

    function arePresentationsValid(presentations) {
        var index, len = presentations.length;
        if (typeof presentations === 'undefined' || presentations.length <= 0) {
            throw new Error('No presentations');
        }
        for (index = 0; index < len; index = index + 1) {
            if (isTitleValid(presentations[index]) === false) {
                throw new Error('Not valid presentations');
            };
        };

    }

    function isNameValid(name) {
        var index,
            capital,
            smalls,
            len = 2,
            names = name.split(' ');
        if (typeof name !== 'string') {
            throw new Error('Not a string!');
        };

        if (names.length !== len) {
            throw new Error('Less or more than one name!');
        };

        for (index = 0; index < len; index += 1) {
            if (names[index].length == 1) {
                if (names[index] !== names[index].toUpperCase()) {
                    throw new Error('Single letter not capital!');
                };
            }
            if (names[index].length > 1) {
                capital = names[index].substring(0, 1);
                smalls = names[index].substring(1, names[index].length - 1)

                if (capital !== capital.toUpperCase() || smalls !== smalls.toLowerCase()) {
                    throw new Error('First letter not capital or rest not lower!');
                };
            };
        };
    }
    var Course = {
        init: function(title, presentations) {
            if (!isTitleValid(title)) {
                throw new Error('Invalid title');
            }
            this.title = title;
            this.students = [];
            studentIDs = 0;
            arePresentationsValid(presentations);
            this.presentations = presentations;
            return this;
        },
        addStudent: function(name) {
            isNameValid(name);
            var names = name.split(' ');
            studentIDs = studentIDs + 1;
            this.students.push({
                firstname: names[0],
                lastname: names[1],
                id: studentIDs
            });
            return studentIDs;
        },
        getAllStudents: function() {
            return this.students.slice();
        },
        submitHomework: function(studentID, homeworkID) {
            if (studentID !== studentID || studentID <= 0 || studentID > studentIDs || (studentID !== (studentID | 0))) {
                throw new Error('Invalid student ID!');

            };
            if (homeworkID !== homeworkID || homeworkID < 1 || homeworkID > this.presentations.length) {
                throw new Error('Invalid homework ID!');
            }
        },
        pushExamResults: function(results) {

        },
        getTopStudents: function() {
          
        }
    };

    return Course;
}
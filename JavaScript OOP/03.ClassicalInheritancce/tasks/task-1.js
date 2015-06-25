function solve() {
    var Person = (function() {
        function Person(firstname, lastname, age) {
            this.firstname = firstname,
                this.lastname = lastname,
                this.age = age;
        };


        function isValidName(name) {
            var latinLetters = new RegExp("^[a-zA-Z]+$");
            if (typeof(name) !== 'string' || name.length < 3 || name.length > 20) {
                return false;
            };
            if (name.match(latinLetters) === null) {
                return false;
            };
            return true;
        }

        function isValidAge(age) {
            if (parseInt(age) === 'NaN' || parseInt(age) < 0 || parseInt(age) > 150) {
                return false;
            };
            return true;
        }

        Object.defineProperty(Person.prototype, 'age', {
            get: function() {
                return this._age;
            },
            set: function(value) {
                if (!isValidAge(value)) {
                    throw new Error('Invalid age!');
                };
                this._age = value;
                return this;
            }
        });

        Object.defineProperty(Person.prototype, 'firstname', {
            get: function() {
                return this._firstname;
            },
            set: function(value) {
                if (!isValidName(value)) {
                    throw new Error('Invalid name!');
                };
                this._firstname = value;
                return this;
            }
        });

        Object.defineProperty(Person.prototype, 'lastname', {
            get: function() {
                return this._lastname;
            },
            set: function(value) {
                if (!isValidName(value)) {
                    throw new Error('Invalid name!');
                };
                this._lastname = value;
                return this;
            }
        });

        Object.defineProperty(Person.prototype, 'fullname', {
            get: function() {
                return this._firstname + ' ' + this._lastname;
            },
            set: function(value) {
                var names = value.split(' ');
                if (!isValidName(names[0])) {
                    throw new Error('Invalid name!');
                };
                this._firstname = names[0];

                if (!isValidName(names[1])) {
                    throw new Error('Invalid name!');
                };
                this._lastname = names[1];
            }
        });

        Person.prototype.introduce = function() {
            return 'Hello! My name is ' + this.fullname + ' and I am ' + this.age + '-years-old';
        };

        return Person;
    }());

    return Person;
}
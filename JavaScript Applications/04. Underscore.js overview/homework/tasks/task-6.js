/* 
Create a function that:
*   **Takes** a collection of books
    *   Each book has propeties `title` and `author`
        **  `author` is an object that has properties `firstName` and `lastName`
*   **finds** the most popular author (the author with biggest number of books)
*   **prints** the author to the console
	*	if there is more than one author print them all sorted in ascending order by fullname
		*   fullname is the concatenation of `firstName`, ' ' (empty space) and `lastName`
*   **Use underscore.js for all operations**
*/

function solve(){
  return function (books) {
  	var books = books;

  	var authors = _.pluck(books, 'author');
  	var grouped = _.groupBy(books, 'author')


  	console.log(grouped)


  };
}

module.exports = solve;

var _ = require('underscore');

		var books = [{
			title: 'Book is 3',
			author: {
				firstName: 'Toyger',
				lastName: 'Ninos'
			}
		}, {
			title: 'Big hit',
			author: {
				firstName: 'Miles',
				lastName: 'Pietari'
			}
		}, {
			title: 'Boo is k42',
			author: {
				firstName: 'Toyger',
				lastName: 'Ninos'
			}
		}, {
			title: 'Avtobiografiq na Zlatko',
			author: {
				firstName: 'neSumZlatko',
				lastName: 'Hardmod'
			}
		}, {
			title: 'n00b',
			author: {
				firstName: 'Miles',
				lastName: 'Pietari'
			}
		}, {
			title: 'Just a bOOk',
			author: {
				firstName: 'Toyger',
				lastName: 'Ninos'
			}
		}];

var testFunc = solve();
testFunc(books);
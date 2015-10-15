/* 
Create a function that:
*   **Takes** an array of animals
    *   Each animal has propeties `name`, `species` and `legsCount`
*   **finds** and **prints** the total number of legs to the console in the format:
    *   "Total number of legs: TOTAL_NUMBER_OF_LEGS"
*   **Use underscore.js for all operations**
*/

function solve(){
  return function (animals) {
  	var animals = animals;
  	//console.log(animals)
  	var totalLegs = _.reduce(animals, function(memo, obj){
  		return memo + obj.legsCount;
  	}, 0);

  	console.log('Total number of legs: ' + totalLegs);
  };
}


module.exports = solve;

//var _ = require('underscore');

// var animals = [{
//     name: 'Minkov',
//     species: 'Bogomolka',
//     legsCount: 4
// }, {
//     name: 'Minkov',
//     species: 'Bogomolka',
//     legsCount: 5
// }, {
//     name: 'Doncho',
//     species: 'Centipede',
//     legsCount: 201
// }, {
//     name: 'Komara',
//     species: 'Mosquito',
//     legsCount: 8
// }];

// var testFunc = solve();
// testFunc(animals);

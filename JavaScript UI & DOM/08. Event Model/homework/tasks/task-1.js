/* globals $ */

/* 

Create a function that takes an id or DOM element and:
  

*/

function solve() {
    return function(selector) {
        var selectedElement = document.getElementById(selector);
        if (selectedElement === null || selectedElement === undefined) {
            throw new Error('Invalid id!')
        };

        var btns = document.getElementsByClassName('button');
        var len = btns.length;
        for (var i = 0; i < len; i = i + 1) {
            btns[i].innerHTML = 'hide';
        };

        var root = document.getElementById('root');
        root.addEventListener('click', toggleElements, false);

        function toggleElements(ev) {
            if (ev.target.className === 'button') {
                var target = ev.target;
                var next = target;

                while (next) {
                    if (next.className === 'content') {
                        break;
                    }
                    next = next.nextElementSibling;
                }

                if (next.style.display === '') {
                    target.innerHTML = 'show';
                    next.style.display = 'none';
                } else if (next.style.display === 'none') {
                    target.innerHTML = 'hide';
                    next.style.display = '';
                }
            }
        }
        //console.log(btns.length);
    }
};

module.exports = solve;
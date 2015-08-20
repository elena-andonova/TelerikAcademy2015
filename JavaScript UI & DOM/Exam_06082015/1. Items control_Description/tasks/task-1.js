function solve() {
    return function(selector, isCaseSensitive) {
        var selectedItem = document.querySelector(selector);

        //var isCaseSensitive = isCaseSensitive || false;

        var newElements = document.createElement('div');
        newElements.className = 'items-control';


        var addingElements = document.createElement('div');
        addingElements.className = 'add-controls';
        var addText = document.createElement('label')
        addText.innerHTML = 'Enter text';
        var addInputBox = document.createElement('input');
        //addInputBox.setAttribute('width','100px' );
        var addButton = document.createElement('button');
        addButton.className = 'button';
        addButton.setAttribute('content', 'Add');
        addButton.innerHTML = 'Add';

        addingElements.appendChild(addText);
        addingElements.appendChild(addInputBox);
        addingElements.appendChild(addButton);

        addingElements.addEventListener('click', function(ev) {
            if (ev.target.className === 'button') {
                var newLi = document.createElement('li');
                newLi.innerHTML = addInputBox.value;
                newLi.className = 'list-item';

                //console.log(addInputBox.value);

                var newLiButton = document.createElement('button');
                newLiButton.className = 'button';
                newLiButton.setAttribute('content', 'X');
                newLiButton.innerHTML = 'X';

                newLi.appendChild(newLiButton);
                itemsList.appendChild(newLi);
            }
        })

        var searchElements = document.createElement('div');
        searchElements.className = 'search-controls';
        var searchText = document.createElement('label');
        searchText.innerHTML = 'Search';
        var searchInputBox = document.createElement('input');


        searchElements.appendChild(searchText);
        searchElements.appendChild(searchInputBox);


        searchInputBox.addEventListener('input', function(ev) {
            var text = ev.target.value;
            //console.log(text);

            var liChildren = selectedItem.getElementsByClassName('result-controls').getElementsByClassName('list-item');
            var len = liChildren.length;
            //console.log(len);

            for (var k = 0; k < len; k++) {
                var currentLi = liChildren[k];

                var header = currentLi.innerText.split('X')[0];
                //console.log(header);

                // if (!isCaseSenstive) {
                //     if (header.indexOf(text) >= 0) {
                //         currentLi.style.display = 'block';
                //     } else {
                //         currentLi.style.display = 'none';
                //     }

                // }

                if (header.toLowerCase().indexOf(text.toLowerCase()) >= 0) {
                    currentLi.style.display = 'block';
                } else {
                    currentLi.style.display = 'none';
                }

            }
        }, false);


        var resultElements = document.createElement('div');
        resultElements.className = 'result-controls';
        var itemsList = document.createElement('ul');
        itemsList.className = 'items-list';

        resultElements.appendChild(itemsList);

        resultElements.addEventListener('click', function(ev) {
            if (ev.target.className === 'button') {
                var target = ev.target;
                //console.log(target.parentNode);
                target.parentNode.remove();
            }
        })


        newElements.appendChild(addingElements);
        newElements.appendChild(searchElements);
        newElements.appendChild(resultElements);

        selectedItem.appendChild(newElements);
    };
}

module.exports = solve;

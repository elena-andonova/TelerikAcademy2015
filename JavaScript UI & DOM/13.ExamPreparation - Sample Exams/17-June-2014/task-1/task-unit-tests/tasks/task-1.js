/* globals module */
function solve() {

    return function(selector, items) {
        var root = document.querySelector(selector);
        var rightPanel = document.createElement('div');
        rightPanel.className = 'image-container';
        //rightPanel.style.width = '75%';

        var len = items.length;
        for (var i = 0; i < len; i = i + 1) {
            var image = document.createElement('img');
            image.src = items[i].url;
            image.title = items[i].title;
            rightPanel.appendChild(image);
        };

        var leftPanel = document.createElement('div');
        leftPanel.className = 'image-preview';
        //leftPanel.style.width = '25%';

        var firstImage = document.createElement('img');
        firstImage.src = items[0].url;
        firstImage.title = items[0].title;

        root.appendChild(rightPanel);
        root.appendChild(leftPanel);

    };
}

module.exports = solve;

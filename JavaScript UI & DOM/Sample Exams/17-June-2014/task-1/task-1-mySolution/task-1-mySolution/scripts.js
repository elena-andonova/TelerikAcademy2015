function createImagesPreviewer(selector, items) {
    var root = document.querySelector(selector);

    var leftPanel = document.createElement('div');
    leftPanel.className = 'image-preview';
    leftPanel.style.width = '75%';
    leftPanel.style.float = 'left';
    leftPanel.style.textAlign = 'center';

    var image = document.createElement('img');
    image.src = items[0].url;
    image.style.width = '70%';
    var imageTitle = document.createElement('h1');
    imageTitle.innerHTML = items[0].title;

    leftPanel.appendChild(imageTitle);
    leftPanel.appendChild(image);

    //rightpanel
    var rightPanel = document.createElement('div');
    //rightPanel.className = 'image-container';
    rightPanel.style.width = '25%';
    rightPanel.style.height = '700px';
    rightPanel.style.display = 'inline-block';
    rightPanel.style.textAlign = 'center';
    rightPanel.style.overflowY = 'scroll';


    var inputSearch = document.createElement('input');
    var inputHeader = document.createElement('h3');
    inputHeader.innerHTML = 'Filter';



    rightPanel.appendChild(inputHeader);
    rightPanel.appendChild(inputSearch);

    var listOfImages = document.createElement('ul');
    var li = document.createElement('li');
    li.style.listStyleType = 'none';
    li.className = 'image-container';

    var imageTitleSmall = document.createElement('h3');

    var len = items.length;
    for (var i = 0; i < len; i = i + 1) {
        var currentLi = li.cloneNode(true);
        var currentTitle = imageTitleSmall.cloneNode(true);
        currentTitle.innerHTML = items[i].title;
        var currentImg = image.cloneNode(true);

        currentImg.src = items[i].url;
        currentImg.style.width = '70%';

        currentLi.appendChild(currentTitle);
        currentLi.appendChild(currentImg);
        listOfImages.appendChild(currentLi);
        rightPanel.appendChild(listOfImages);
    };

    rightPanel.addEventListener('click', function (ev) {
        var target = ev.target;
        if (!(target instanceof HTMLImageElement)) {
            return;
        }
        image.src = target.src;
        imageTitle.innerHTML = target.previousElementSibling.innerHTML;
    });

    rightPanel.addEventListener('mouseover', function (ev) {
        var target = ev.target;
        //console.log(target.className);
        //console.log(target.className == 'image-container')
        if (target.className == 'image-container') {
            target.style.background = 'grey';
        }

    });

    rightPanel.addEventListener('mouseout', function (ev) {
        var target = ev.target;
        //console.log(target.className);
        //console.log(target.className == 'image-container')
        if (target.className == 'image-container') {
            target.style.background = 'white';
        }

    });

    inputSearch.addEventListener('keyup', function (ev) {
        
        var text = ev.target.value;
        console.log(text);
        var liChildren = listOfImages.getElementsByTagName('li');
        var len = liChildren.length;
        console.log(len);
        for (var k = 0; k < len; k++) {
            var currentLi = liChildren[k];

            var header = currentLi.firstElementChild.innerText;
            console.log(header.toLowerCase().indexOf(text.toLowerCase()));
            if (header.toLowerCase().indexOf(text.toLowerCase()) >= 0) {
                currentLi.style.display = 'block';
            }
            else {
                currentLi.style.display = 'none';
            }
        }
    }, false)

    root.appendChild(leftPanel);
    root.appendChild(rightPanel);

}

/* globals $ */

/*
Create a function that takes a selector and:
* Finds all elements with class `button` or `content` within the provided element
  * Change the content of all `.button` elements with "hide"
* When a `.button` is clicked:
  * Find the topmost `.content` element, that is before another `.button` and:
    * If the `.content` is visible:
      * Hide the `.content`
      * Change the content of the `.button` to "show"       
    * If the `.content` is hidden:
      * Show the `.content`
      * Change the content of the `.button` to "hide"
    * If there isn't a `.content` element **after the clicked `.button`** and **before other `.button`**, do nothing
* Throws if:
  * The provided ID is not a **jQuery object** or a `string` 

*/
function solve() {
    return function(selector) {
        var selectedElement = $(selector);
        if (selector === null || selector === undefined) {
            throw new Error('Invalid id!')
        };
        if (selectedElement.length === 0) {
            throw new Error('Invalid id!');
        };

        var btns = $('.button');
        //console.log(btns.length);
        var len = btns.length;
        for (var i = 0; i < len; i = i + 1) {
            var btn = $(btns[i]);
            btn.text('hide');
            //console.log(btn.text());
        };
        
        selectedElement.on('click', toggleElements);

        function toggleElements(ev) {
            if ($(ev.target).hasClass('button')) {
                var $target = $(ev.target);
                var $nextElement = $target;

                while ($nextElement) {
                    if ($nextElement.hasClass('content')) {
                        break;
                    }
                    $nextElement = $nextElement.next();
                }

                if ($nextElement.css('display') === 'none') {
                    $target.text('hide');
                    $nextElement.css('display', '');
                } else {
                    $target.text('show');
                    $nextElement.css('display', 'none');
                }
            }
        }
    }
}

module.exports = solve;
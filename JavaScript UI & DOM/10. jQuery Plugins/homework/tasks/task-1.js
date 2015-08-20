function solve() {
    return function(selector) {
    	//console.log($(selector).val())
        var selectedItem = $(selector).css('display', 'none');
        //.removeAttr('id')
        
        var parent = selectedItem.parent();
        var children = selectedItem.children();
        var len = children.length;

        var divCurrent = $('<div />').addClass('current').attr('data-value', '').text($(children[0]).text());

        var divContainer = $('<div />').addClass('options-container').css('position', 'absolute').css('display', 'none');

         var childDiv = $('<div />')
                .addClass('dropdown-item');



        for (var i = 0; i < len; i = i + 1) {
            var childDiv = $('<div />')
                .addClass('dropdown-item')
                .attr('data-value', $(children[i]).attr('value'))
                .attr('data-index', i)
                .text($(children[i]).text());

            divContainer.append(childDiv);
        };

        var newDiv = $('<div />').addClass('dropdown-list').append(selectedItem).append(divCurrent).append(divContainer);

        parent.append(newDiv);

        divCurrent.on('click', toggleOptionsVisibility)

        function toggleOptionsVisibility(ev) {
            var target = $(ev.target);
            var options = target.next();
            if (options.css('display') === 'none') {
                options.css('display', '');
            } else {
                options.css('display', 'none');
            }
        }

        divContainer.on('click', chooseOption)

        function chooseOption(ev) {
            if ($(ev.target).hasClass('dropdown-item')) {
                var target = $(ev.target);
                divCurrent.text(target.text());
                selectedItem.val(target.attr('data-value'));
                //console.log(selectedItem.val());
                target.parent().css('display', 'none');
            }
        }

    }
}

module.exports = solve;
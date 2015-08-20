function solve() {
    $.fn.datepicker = function () {
        var MONTH_NAMES = ["January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"];
        var WEEK_DAY_NAMES = ['Su', 'Mo', 'Tu', 'We', 'Th', 'Fr', 'Sa'];
        var weekLength = WEEK_DAY_NAMES.length;
        var rows = 6;

        Date.prototype.getMonthName = function () {
            return MONTH_NAMES[this.getMonth()];
        };

        Date.prototype.getDayName = function () {
            return WEEK_DAY_NAMES[this.getDay()];
        };
		
        // you are welcome :)
        var date = new Date();
        console.log(date.getDayName());
        console.log(date.getMonthName());

        var inputBox = $('#date');
        var parent = inputBox.parent();
        var wrapper = $('<div />').addClass('datepicker-wrapper');


        var calendarContent = wrapper.clone().addClass('datepicker-content');
        var currentMonth = calendarContent.clone().addClass('controls').addClass('current-month');
        var calendar = $('<table />').addClass('calendar');
        var currentDate = calendarContent.clone().addClass('current-date');



        var currentDayString = new Date().getDay();
        var currentMonthString = new Date().getMonthName();
        var currentYearString = new Date().getFullYear();
        currentDate.text(currentDayString + ' ' + currentMonthString + ' ' + currentYearString);
        console.log(currentMonthString);

        
        var firstRowCalendar = $('<tr/>').addClass('calendar');
        var weekDay = $('<th />').addClass('calendar').addClass('th');
        var monthDay = $('<td />').addClass('calendar').addClass('td');

        // for (var i = 0; i < weekLength; i++) {
        //     var dayOfWeek = weekDay.clone().text(WEEK_DAY_NAMES[i]);
        //     firstRowCalendar.append(dayOfWeek);
        //     calendar.append(firstRowCalendar);            
        // }
        
        
        // for (var r = 0; r < rows; r = r + 1) {
        //     var row = rowCalendar.clone();
        //     calendar.append(row);
        // }


        currentMonth.text(currentMonthString);

        calendarContent.append(currentDate)
            .append(currentMonth)
            .append(calendar)
            .append(currentDate);

        wrapper.append(inputBox);
        wrapper.append(calendarContent);
        parent.append(wrapper);


        $('#date').on('click', function () {
            console.log('testing');
            calendarContent.addClass('datepicker-content-visible');
        });
    };
};

solve();
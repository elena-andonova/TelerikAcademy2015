function solve() {
    return function (selector) {
        var template = '<div class="event-calendar">'+
                '<h2 class="header">Appointments for <span class="month">{{this.month}}</span> <span class="year">{{this.year}}</span></h2>'+
                '{{#each days}}'+
                '<div class="col-date">'+
                    '<div class="date">{{this.day}}</div>'+             
                    '<div class="events">'+
                    '{{#each events}}'+
                        '{{#if title}}'+
                        '<div class="event {{this.importance}}" title="duration: {{this.duration}}">'+
                            '<div class="title">{{this.title}}</div>'+
                            '<span class="time">at: {{this.time}}</span>'+
                        '</div>'+
                        '{{else}}'+
                        '<div class="event {{this.importance}}">'+
                            '<div class="title">Free slot</div>'+
                        '</div>'+
                        '{{/if}}'+
                    '{{/each}}'+
                    '</div>+'
                '</div>'+
                '{{/each}}';		
        document.getElementById(selector).innerHTML = template;
    };
}

module.exports = solve;
function solve() {
    return function (selector) {
        var template = '<div class="events-calendar">' +
            '<h2 class="header">' +
            'Appointments for ' +
            '<span class="month">' + '{{month}}'
            + '</span>'
            + ' <span class="year">' +
            ' {{year}}' + '</span>' +
            ' </h2>' +

            '{{#each days}}' +

            '<div class="col-date">' +
            
                '<div class="date">' + '{{day}}' + '</div>' 
                    + '<div class="events">' +
                    + '{{#each events}}' +
                        '<div class="event {{importance}}"' + '{{#with comment}} title="{{comment}}"{{/with}}>'
                        + '{{#with title}} ' 
                            + '<div class="title">' + '{{title}}' + '</div>' +
                        '{{else}}' + '<div class="title">' + 'Free slot' + '</div>' +
                        '{{/with}}

                        {{#with time}}' + '<span class="time">' + 'at: {{time}}' + '</span>' +
                        '{{/with}}' 
                        + ' </div>' 
                    + '{{/each}}' +
                    '</div>'  


            + '</div>' +
            


            + '{{/each}}'





             +'</div>';
        //console.log(this.days);
        document.getElementById(selector).innerHTML = template;
    };
}

module.exports = solve;

//var template = '<h2 class="header">' +
//    'Appointments for' +
//    '<span class="month">' + '{{data.month}}'
//    + '</span>'
//    + ' <span class="year"\>' +
//    '{{data.year}}' + '</span>' +
//    ' </h2>' + '{{#each data.days}}' +
//    ' <div class="col-date">' +
//    ' <div class="date">' + '{{this.day}}' +
//    '</div>' + ' <div class="events">' +
//    + '{{#each this.events}}' +
//    '<div class="event {{this.importance}}">'
//    + '{{#if title}} ' + '<div class="title">' +
//    '{{title}}' + '</div>' +
//    '{{else}}' + '<div class="title">' +
//    'Free slot' + '</div>' +
//    '{{/if}}{{#if time}}' + ' <span class="time">' +
//    'at: {{time}}' + '</span>' +
//    '{{/if}}' + ' </div>' + '{{/each}}' +
//    '</div>' + ' </div>' +
//    '{{/each}}';


//var template = '<h2 class="header">' +
//    'Appointments for' + '<span class="month">' + '{{data.month}}' + '</span>' +
//    ' <span class="year">' + '{{data.year}}' + ' </span>' +
//    '</h2>' +
//    '{{#each data.days}}' +
//    '<div class="col-date">' +
//    '<div class="date"> ' + '{{this.day}}' + '</div>' +
//    '<div class="events">' +
//    '{{#each this.events}}' +
//    '<div class="event {{this.importance}}">' +
//    '{{#if title}}' +
//    '<div class="title">' + '{{title}}' + '</div>' +
//    '{{else}}' +
//    '<div class="title">' + 'Free slot' + '</div>' +
//    '{{/if}}' +
//    '{{#if time}}' +
//    ' <span class="time">' + 'at: {{time}}' + '</span>' +
//    '{{/if}}' +
//    '</div>' +
//    ' {{/each}}' +
//    ' </div>' +
//    '</div>' +
//    '{{/each}}';
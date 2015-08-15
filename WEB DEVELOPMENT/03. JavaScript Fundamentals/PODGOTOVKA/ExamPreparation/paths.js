/**
 * Created by john on 6/10/15.
 */
function Solve(params) {
    var line = params[0].split(" ");
    var R = line[0];
    var C = line[1];
    var directions = [];
    var lastPosition = [2];
    var x = 0, y = 0;
    var numbers = 0;
    directions = params.slice(1);

    for(var i = 0, len = directions.length; i < len; i += 1) {
        directions[i] = directions[i].split(" ");
    }

    while(true) {
        if(x >= 0 && x < R && y >= 0 && y < C) {
            if(directions[x][y] !== 'out') {
                numbers += Math.pow(2, x) + y;
                lastPosition[0] = x;
                lastPosition[1] = y;
                //directions[x][y] = 'out';

                switch (directions[x][y]) {
                    case 'dr': x++; y++; break;
                    case 'ur': x--; y++; break;
                    case 'ul': x--; y--; break;
                    case 'dl': x++; y--; break;
                }
                directions[lastPosition[0]][lastPosition[1]] = 'out';
            } else {
                console.log('failed at (' + x + ', ' + y + ')');
                break;
            }


        } else {
            console.log('successed with ' + numbers);
            break;
        }
    }

    //console.log(directions);
}
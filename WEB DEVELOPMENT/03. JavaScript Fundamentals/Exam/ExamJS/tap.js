/**
 * Created by john on 6/11/15.
 */
function solve(params) {
    var rows = parseInt(params[0]),
        cols = parseInt(params[1]),
        tests = parseInt(params[rows + 2]), i, move, x1, x2,y1,y2, ans = 'yes';
    //console.log(params);
    for (i = 0; i < tests; i++) {
        ans = 'yes';
        move = params[rows + 3 + i];
        // Your solution here
        x1 = rows - parseInt(move[1]);
        x2 = rows - parseInt(move[4]);
        y1 = move.charCodeAt(0) - 97;
        y2 = move.charCodeAt(3) - 97;
        //console.log(x1);
        /*console.log(x2);
        console.log(y1);
        console.log(y2);*/
        if(x1 + '' + y1 === x2 + '' + y2) {
            ans = 'no';
        }
        if(params[2 + x1][y1] === '-' || params[2 + x2][y2] !== '-') {
            ans = 'no';
        }
        else if(params[2 + x1][y1] === 'R') {
            if(x1 !== x2 || y1 !== y2) {
                ans = 'no';
            } else {
                if(x1 < x2 ) {
                    while(x1 >= 0 && x1 < rows) {
                        x1 += 1;

                        if (params[2 + x1][y1] === '-') {
                            ans = 'no';
                            break;
                        }
                        if(x1 === x2 && y1 === y2) {

                            break;
                        }
                    }
                } else if(x1 > x2 ) {
                    while(x1 >= 0 && x1 < rows) {
                        x1 -= 1;

                        if (params[2 + x1][y1] === '-') {
                            ans = 'no';
                            break;
                        }
                        if(x1 === x2 && y1 === y2) {

                            break;
                        }
                    }
                } else if(y1 > y2 ) {
                    while(y1 >= 0 && y1 < cols) {
                        y1 -= 1;

                        if (params[2 + x1][y1] === '-') {
                            ans = 'no';
                            break;
                        }
                        if(x1 === x2 && y1 === y2) {

                            break;
                        }
                    }
                } else if(y1 < y2 ) {
                    while(y1 >= 0 && y1 < cols) {
                        y2 -= 1;

                        if (params[2 + x1][y2] === '-') {
                            ans = 'no';
                            break;
                        }
                        if(x1 === x2 && y1 === y2) {

                            break;
                        }
                    }
                }
            }
        }
        else if(params[2 + x1][y1] === 'B') {
            console.log(x1,x2,y1,y2);
            if((x1 === x2 || y1 === y2) || !(Diagonal(x1,x2,y1,y2))) {
                ans = 'no';
            }
            else {
                if(!(Diagonal(x1,x2,y1,y2))) {
                    ans = 'no';
                }
            }

        }else if(params[2 + x1][y1] === 'Q') {
            if((x1 !== x2 && y1 != y2) && ((x1 === x2 || y1 === y2)) && !((Diagonal(x1,x2,y1,y2))) ) {
                ans = 'no';
            } else {

            }
        }

        console.log(ans); // or console.log('no');
    }

    function Diagonal(a1,a2,b1,b2) {
        var minX = Math.min(a1,a2);
        var maxX = Math.max(a1,a2);
        var grr = false;
        if(a1 < a2 && b1 < b2) {
            while(a1 >= 0 && a1 < rows) {
                a1 += 1;
                b1 -= 1;
                if (params[2 + a1][b1] === '-') {
                    break;
                }
                if(a1 === a2 && b1 === b2) {
                    grr = true;
                    break;
                }
            }
        } else if(a1 < a2 && b1 > b2) {
            while(a1 >= 0 && a1 < rows) {
                a1 += 1;
                b1 -= 1;
                if (params[2 + a1][b1] === '-') {
                    break;
                }
                if(a1 === a2 && b1 === b2) {
                    grr = true;
                    break;
                }
            }
        }else if(a1 > a2 && b1 < b2) {
            while(a2 >= 0 && a2 < rows) {
                a2 += 1;
                b2 -= 1;
                if (params[2 + a2][b2] === '-') {
                    break;
                }
                if(a2 === a1 && b1 === b2) {
                    grr = true;
                    break;
                }
            }
        } else if(a1 > a2 && b1 > b2) {
            while(a2 >= 0 && a2 < rows) {
                a2 += 1;
                b2 += 1;
                if (params[2 + a2][b2] === '-') {
                    break;
                }
                if(a2 === a1 && b1 === b2) {
                    grr = true;
                    break;
                }
            }
        }

        return grr;

    }
}
/*solve(['5',
    '5',
    'Q---Q',
    '-----',
    '-B---',
    '--R--',
    'Q---Q',
    '10',
    'a1 a1',
    'a1 d4',
    'e1 b4',
    'a5 d2',
    'e5 b2',
    'b3 d5',
    'b3 a2',
    'b3 d1',
    'b3 a4',
    'c2 c5'
]);*/
solve(['3',
    '4',
    '--R-',
    'B--B',
    'Q--Q',
    '12',
    'd1 b3',
    'a1 a3',
    'c3 b2',
    'a1 c1',
    'a1 b2',
    'a1 c3',
    'a2 b3',
    'd2 c1',
    'b1 b2',
    'c3 b1',
    'a2 a3',
    'd1 d3'

]);

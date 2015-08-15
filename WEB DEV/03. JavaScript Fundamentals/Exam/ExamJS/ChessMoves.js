/**
 * Created by john on 6/11/15.
 */
function solve(params) {
    var rows = parseInt(params[0]),
        cols = parseInt(params[1]),
        tests = parseInt(params[rows + 2]), i, j, move, coordMatrix = [], first = {}, second = {};

    for(i = 2; i < rows + 2; i += 1) {
        coordMatrix[i] = [];
        coordMatrix[i] = (params[i + 2].split(''));
    }


    for (i = 0; i < tests; i++) {
        move = params[rows + 3 + i];
        // Your solution here
        first = {
            x: rows - parseInt(move[1]),
            y: move.charCodeAt(0) - 97
        };
        second = {
            x: rows - parseInt(move[4]),
            y: move.charCodeAt(3) - 97
        };
        //console.log(move);
        if(first.x === second.x && first.y === second.y) {
            console.log('no');
            continue;
        }
        //console.log(coordMatrix);
        //console.log(rows - first.x);
        //console.log(first.y);
        var aaa = '-';
        /*if(coordMatrix[rows - first.x][first.y - 97] === aaa) {
            console.log('no');
        }*/

        if(first.x === second.x) {
            var minObj = Math.min(first.y, second.y);
            var minCoo = first;
            if(second.y == minObj) {
                 minCoo = second;
            }
            while(minCoo.y <= minObj) {
                if(coordMatrix[first.x][minCoo.y] !== '-') {
                    console.log('no');
                    break;
                }
                minCoo.y += 1;
            }
            console.log('yes');
            continue;
        } else if(first.y === second.y) {
             minObj = Math.min(first.x, second.x);
             minCoo = first;
            if(second.x == minObj) {
                 minCoo = second;
            }
            while(minCoo.x <= minObj) {
                if(coordMatrix[first.y][minCoo.x] !== '-') {
                    console.log('no');
                    break;
                }
                minCoo.x += 1;
            }
            console.log('yes');
            continue;
        }










        //console.log('yes');
        console.log('no');
    }
    /*function FromTo(a,b) {

    }*/
    function IsLine(a,b) {
        if(a[0] === b[0] || a[1] ===b[1]) {
            return true;
        }
    }

    /**//**
     * @return {boolean}
     *//*
    function CheckBounds(a,b) {
        if(a >= 0 && a < b) {
            return true;
        }
        return false;
    }
    *//**
     * @return {boolean}
     *//*
    function Up(a,b) {
        var tempA = a;
        while(CheckBounds(tempA[1],0)) {
            if(tempA[1] === b[1]) {
                return true;
            }
            tempA[1]+=1;
        }

        return false;
    }
    function Down(a,b) {
        var tempA = a;
        while(CheckBounds(tempA[1],rows)) {
            if(tempA[1] === b[1]) {
                return true;
            }
            tempA[1]-=1;
        }

        return false;
    }
    function Left(a,b) {
        var tempA = a;
        while(CheckBounds(tempA[0],0)) {
            if(tempA[0] === b[0]) {
                return true;
            }
            tempA[0]-=1;
        }

        return false;
    }
    function Right(a,b) {
        var tempA = a;
        while(CheckBounds(tempA[0],cols)) {
            if(tempA[0] === b[0]) {
                return true;
            }
            tempA[0]+=1;
        }

        return false;
    }
    function LeftUp(a,b) {
        var tempA = a;
        while(CheckBounds(tempA[0],0) && CheckBounds(tempA[1],0)) {
            if(tempA[0] === b[0] && tempA[1] === b[1]) {
                return true;
            }
            tempA[0]-=1;
            tempA[1]-=1;
        }

        return false;
    }
    function RightUp(a,b) {
        var tempA = a;
        while(CheckBounds(tempA[0],cols) && CheckBounds(tempA[1],0)) {
            if(tempA[0] === b[0] && tempA[1] === b[1]) {
                return true;
            }
            tempA[0]+=1;
            tempA[1]-=1;
        }

        return false;
    }
    function RightDown(a,b) {
        var tempA = a;
        while(CheckBounds(tempA[0],cols) && CheckBounds(tempA[1],rows)) {
            if(tempA[0] === b[0] && tempA[1] === b[1]) {
                return true;
            }
            tempA[0]+=1;
            tempA[1]+=1;
        }

        return false;
    }
    function LeftDown(a,b) {
        var tempA = a;
        while(CheckBounds(tempA[0],0) && CheckBounds(tempA[1],rows)) {
            if(tempA[0] === b[0] && tempA[1] === b[1]) {
                return true;
            }
            tempA[0]-=1;
            tempA[1]+=1;
        }

        return false;
    }*/
}
solve(['5',
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
]);

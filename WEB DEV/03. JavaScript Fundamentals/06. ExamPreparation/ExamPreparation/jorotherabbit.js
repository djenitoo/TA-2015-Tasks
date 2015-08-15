/**
 * Created by john on 6/9/15.
 */
function Solve(params) {
    var firstrow = params[0].split(" ");
    var N = parseInt(firstrow[0]);
    var M = parseInt(firstrow[1]);
    var J = parseInt(firstrow[2]);
    firstrow = params[1].split((' '));
    var R = parseInt(firstrow[0]);
    var C = parseInt(firstrow[1]);
    var jumps = [];
    var escaped = false;
    var repeat = false;
    var field = new Array();
    var boolField = new Array();
    var next = 1;
    var sumOfNumbers = 0;
    var countOfJumps = 0;

    for(var i = 2; i < params.length; i += 1) {
        firstrow = params[i].split((' '));
        jumps.push([parseInt(firstrow[0]),parseInt(firstrow[1])]);
    }
    for(i = 0; i < N; i += 1) {
        field[i] = new Array();
        for(var j = 0; j < M; j += 1) {
            field[i].push(next++);
        }
    }
    // da main
    var index = 0;
    while(true) {
        if(R >= 0 && R < N && C >= 0 && C < M) {
            if(field[R][C] !== -1) {
                countOfJumps += 1;
                sumOfNumbers += field[R][C];
                field[R][C] = -1;
                R = R + jumps[index][0];
                C = C + jumps[index][1];
                index = (index + 1) % J;
            } else {
                console.log('caught' + ' ' + countOfJumps);
                break;
            }
        }
        else {
            escaped = true;
            console.log('escaped' + ' ' + sumOfNumbers);
            break;
        }
    }

    //console.log(jumps);
    //console.log(field);


}
function Solve(params) {
    var firstString = params[0].split(' '),
        N = parseInt(firstString[0]),
        M = parseInt(firstString[1]),
        J = parseInt(firstString[2]),
        secondString = params[1].split(' '),
        R = parseInt(secondString[0]),
        C = parseInt(secondString[1]),
        cellJ,
        index,
        row = [],
        col = [],
        len, output = 0 , rowLen, inside, count = 0, next = 1;
    var jumps = [];


    for (index = 2; index < J + 2; index += 1) {
        cellJ = params[index].split(' ');
        jumps.push([parseInt(cellJ[0]), parseInt(cellJ[1])]);
    }
    // console.log(jumps);
    for (index = 0; index < N; index += 1) {
        for (var j = 1 + (index) * M; j <= M * (index + 1); j += 1) {
            row.push(next++);

        }
        col.push(row);
        rowLen = row.length;
        row = [];
    }


    var colLen = col.length;
    inside = true;
    index = 0;
    while(true){

        //for (index = 0, len = jumps.length ; index < len ; index += 1){

        if (R < N && R >= 0 && C < M && C >= 0) {

            if (col[R][C] !== -1) {
                output += col[R][C];
                count += 1;

                col[R][C] = -1;
                R = R + jumps[index][0];
                C = C + jumps[index][1];
                index = (index + 1) % J;

            } else {
                console.log('caught ' + count);
                inside = false;
                break;
            }

        } else {
            console.log('escaped ' + output);
            inside = false;
            break;
        }
        //}
        //index = (index+1)%jumps.length;
    }


}


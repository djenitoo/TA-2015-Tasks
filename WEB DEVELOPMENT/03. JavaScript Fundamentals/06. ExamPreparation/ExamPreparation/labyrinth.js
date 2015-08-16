/**
 * Created by john on 6/9/15.
 */
function Solve(params) {
    var line = params[0].split(" ");
    var N = parseInt(line[0]);
    var M = parseInt(line[1]);
    line = params[1].split(" ");
    var R = parseInt(line[0]);
    var C = parseInt(line[1]);
    var next = 1;
    var directions = [];
    var field = [];
    var cellCount = 0, numberSum = 0;

    for(var i = 0; i < N; i += 1) {
        field[i] = [];
        directions[i] = [];
        directions[i] = params[i + 2].split("");
        for(var j = 0; j < M; j += 1) {
            field[i].push(next++);
        }
    }

    while(true) {
        if(R >= 0 && R < N && C >= 0 && C < M) {
            if(field[R][C] != -1) {
                cellCount += 1;
                numberSum += field[R][C];
                field[R][C] = -1;
                switch (directions[R][C]) {
                    case 'r':
                        C += 1;
                        break;
                    case 'l':
                        C -= 1;
                        break;
                    case 'u':
                        R -= 1;
                        break;
                    case 'd':
                        R += 1;
                        break;
                }
            } else {
                console.log('lost ' + cellCount);
                break;
            }
        } else {
            console.log('out ' + numberSum);
            break;
        }
    }
    //console.log(directions);
    //console.log(field);

}

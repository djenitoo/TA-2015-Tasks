/**
 * Created by john on 6/8/15.
 */
function solve(params) {
    var s = parseInt(params[0]);
    var count = 0;
    var x = Math.floor(s / 4), y = Math.floor(s / 10), z = Math.floor(s / 3);
    var tempSum = 0, i, j, q, upper, middle, down;

    //console.log(x + " " + y + " " + z);
    for(i = 0; i <= x; i += 1) {
        upper = i * 4;
        tempSum = upper;
        //console.log(tempSum);
        if(tempSum === s) {
            count += 1;
            continue;
        }
        if (tempSum > s) {
            //continue;
        }
        else {
            for(j = 0; j <= y; j += 1) {
                middle = upper + (j * 10);
                tempSum = middle;
                //console.log(tempSum);

                if(tempSum === s) {
                    count = count + 1;
                    break;
                }
                if (tempSum > s) {
                    break;
                }

                for(q = 0; q <= z; q += 1) {
                    down = middle + (q * 3);
                    tempSum = down;
                    //console.log(tempSum);
                    if(tempSum === s) {
                        count += 1;
                        break;
                    }
                    if (tempSum > s) {
                        tempSum = middle;
                        break;
                    }

                }
            }
        }



    }

    console.log(count);
}
/**
 * Created by john on 6/9/15.
 */
function solve(params) {
    var s = params[0], c1 = params[1], c2 = params[2], c3 = params[3];
    var answer = 0;
    var tempMax = 1;
    //console.log((s / c1) + 1);
    //console.log((s / c2) + 1);
    //console.log((s / c3) + 1);
    for(var i = 0; i <= (s / c1) + 1; i += 1) {
        for(var j = 0; j <= (s / c2) + 1; j += 1) {
            for(var q = 0; q <= (s / c3) + 1; q += 1) {
                var temp = (i*c1) + (j*c2) + (q * c3);
                if( temp > tempMax && temp <= s) {
                    tempMax = temp;
                }
            }
        }
    }
    answer = tempMax;
    // Your solution here
    console.log(answer);
}

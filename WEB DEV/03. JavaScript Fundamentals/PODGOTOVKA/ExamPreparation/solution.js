/**
 * Created by john on 6/8/15.
 */
function Solve(params) {
    var N = parseInt(params[0]), i = 1, answer = 1;


    for(;i<N;i+=1) {
        if(parseInt(params[i]) > parseInt(params[i+1])) {
            answer += 1;
        }
    }

    if(N === 0) {
        answer = 0;
    }
    //var answer = countSeq;



    return answer;
}

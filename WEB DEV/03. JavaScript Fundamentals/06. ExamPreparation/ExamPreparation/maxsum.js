/**
 * Created by john on 6/8/15.
 */
function Solve(params) {
    var N = parseInt(params[0]), i = 0, j = 0, arr=[], maxSum, currSum;

    for(i = 1 ; i<params.length; i+=1) {
        arr.push(parseInt(params[i]));
    }

    for(i = 0; i< arr.length; i+=1) {
        currSum = arr[i];
        if(typeof maxSum === 'undefined' ) {
            maxSum = currSum;
        }
        else {
            if(maxSum < currSum) {
                maxSum = currSum;
            }
        }
        for(j = i + 1; j < arr.length; j += 1) {
            currSum += arr[j];

            if(currSum > maxSum) {
                maxSum = currSum;
            }
        }
    }

    return maxSum;

}

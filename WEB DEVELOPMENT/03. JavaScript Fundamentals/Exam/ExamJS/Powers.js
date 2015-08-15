/**
 * Created by john on 6/11/15.
 */
function solve(params) {
    var nk = params[0].split(' ').map(Number),
        s = params[1].split(' ').map(Number),
        result = 0, i, len, tempSeq = [];

    /**
     * @return {number}
     */
    function SumSeq(arg) {
        var tempResult = 0;
        for(i = 0, len = arg.length; i < len; i += 1) {
            tempResult += arg[i];
        }
        return tempResult;
    }

    /**
     * @return {number}
     */
    function IsOdd(numb) {
        if(numb % 2 === 1) {
            return 'odd';
        } else {
            return 'even';
        }
    }
    while(nk[1] > 0) {
        tempSeq = s.slice(0);

        for(i = 0; i < nk[0]; i+= 1) {
            if (s[i] + "" === '0') {
                tempSeq[i] = Math.abs(s[(nk[0] + (i - 1)) % nk[0]] - s[(i + 1) % nk[0]]);
            } else if (s[i] + '' === '1') {
                tempSeq[i] = Math.abs(s[(nk[0] + (i - 1)) % nk[0]] + s[(i + 1) % nk[0]]);
            } else if (IsOdd(s[i]) === 'odd') {
                tempSeq[i] = Math.min(s[(nk[0] + (i - 1)) % nk[0]], s[(i + 1) % nk[0]]);
            } else if (IsOdd(s[i]) === 'even') {
                tempSeq[i] = Math.max(s[(nk[0] + (i - 1)) % nk[0]], s[(i + 1) % nk[0]]);
            }
        }
        s = tempSeq.slice(0);
        nk[1] -= 1;
    }

    result = SumSeq(s);
    //console.log(s);
    console.log(result);
}

/**
 * Created by john on 6/10/15.
 */
function Solve(params) {
    var firstString = params[0].split(' ');
    var N = parseInt(firstString[0]),
        M = parseInt(firstString[1]);
    var index,
        col = [], sum = 0, jumps = 0, q;

    for (index = 0; index < N; index += 1) {
        col[index] = [];
        dachislo = Math.pow(2,index);

        for ( q = 0; q < M; q += 1) {
            col[index].push(dachislo);
            dachislo--;
        }
    }


    var R = N - 1;
    var C = M - 1;

    while (true) {
        if (R < 0 || R >= N || C < 0 || C >= M) {
            console.log('Go go Horsy! Collected ' + sum + ' weeds');
            break;
        }
        if (col[R][C] === 'stepped') {
            console.log('Sadly the horse is doomed in ' + jumps + ' jumps');
            break;
        }

        sum += col[R][C];
        jumps += 1;
        col[R][C] = 'stepped';


        switch (params[R + 1][C]) {
            case '1':
                R -= 2; C += 1; break;
            case '2':
                R -= 1; C += 2; break;
            case '3':
                R += 1; C += 2; break;
            case '4':
                R += 2; C += 1; break;
            case '5':
                R += 2; C -= 1; break;
            case '6':
                R += 1; C -= 2; break;
            case '7':
                R -= 1; C -= 2; break;
            case '8':
                R -= 2; C -= 1; break;
        }
    }

}


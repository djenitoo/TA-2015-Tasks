/*Exercise 1
* Write a script that prints all the numbers from 1 to N.
* */
function ExerciseOne() {
    var number = document.getElementById('Exercise-1').value;
    if(number <= 0) console.log("Number should be bigger than 0!");
    else {
        for(var i=1;i<=number;i++){
            console.log(i);
        }
    }
}
/*Exercise 2
 Write a script that prints all the numbers from 1 to N,
 that are not divisible by 3 and 7 at the same time
* */
function ExerciseTwo() {
    var number = document.getElementById('Exercise-2').value;
    if(number <= 0) console.log("Number should be bigger than 0!");
    else {
        for(var i=1;i<=number;i++){
            if((i%3 === 0) && (i%7 === 0)) {
                console.log(i);
            }
        }
    }
}

/*Exercise 3
    Write a script that finds the max and min number from a sequence of numbers.
* */
function ExerciseThree() {
    var numbers = [10043, 435, 12, 1222, 543, 1245345235, 2, 1225, -1453453, -124, 3502934, 5445, -34234, 123, -54352];

    var min = numbers[0];
    var max = numbers[0];

    for (var i = 0; i <= numbers.length; i++) {
        if (numbers[i] < min) min = numbers[i];
        if (numbers[i] > max) max = numbers[i];
    }
    if (min === max) console.log("There is no min max in this sequence!");
    else console.log('Min=' + min + " " + "Max=" + max);
}

/*Exercise 4
* Write a script that finds the lexicographically
* smallest and largest property in document, window and navigator objects.
* */

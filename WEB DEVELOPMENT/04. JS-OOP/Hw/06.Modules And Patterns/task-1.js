
function solve() {
    function validateTitle(title){
        if(typeof(title) !== 'string'){
            throw new Error('string ye!');
        }
        if(/^\s+|\s$/.test(title)){
            throw new Error();
        }
        return true;
    }
    function validateNames(name){


        if(name[0] !==  name[0].toUpperCase()){
            throw new Error();
        }
        if(name.length > 1){
            name2 = name.slice(1);
            if(/[A-Z]+/.test(name2) ){
                throw new Error();
            }
        }

        return name;
    }
    function validatePres(presentations){
        if(!presentations.length){
            throw new Error('curec');
        }
        if(presentations.some(
                function(item){
                    return (/^\s+|\s{2}|\s$/.test(item) || !(item.length));
                }
            )){
            throw new Error('vtori curec');
        }
        var finalPresentations = [];
        for(var ind in presentations){
            var tempPres = {
                title: presentations[ind],
                homework:{
                    homeworkID: ( finalPresentations.length) ?   finalPresentations.length+=1 : 1,
                    studentIDs: []
                }

            };
            finalPresentations.push(tempPres);
        }
        return finalPresentations;
    }
    function validIDs(arr, id){
        if(isNaN(id)){
            throw new Error();
        }

        if(id < 1 || id > arr.length){
            throw new Error();
        }
        if((id|0) !== id){
            throw new Error();
        }
    }
    function validateExamResults(array, students){
        for(var index = 0; index<array.length;index++){
            if(isNaN(array[index].score) || (array[index].score) == 'undefined'){
                throw new Error('CUREC');
            }
            if(!(Object.prototype.hasOwnProperty.call(array[index], 'score'))){
                throw new Error('6ti curec');
            }
            validIDs(array, array[index].StudentID);
            if(array[index].StudentID < 1 || array[index].StudentID > students.length){
                throw new Error();
            }
            var idsForCheck = array.splice(index,1);
            if( idsForCheck.some(function(curEl){
                    if(array[index].StudentID === curEl.StudentID){
                        return true;
                    }
                    return false;
                }) ){
                throw new Error();
            }

            students[(array[index].StudentID)].score = array[index].score;
        }
        return students;

    }
    var Course = {
        init: function(title, presentations) {
            this.title = title;
            this.presentations = validatePres(presentations);
            this.students = [];

            return this;
        },
        get title(){
            return this._title;
        },
        set title(value){
            validateTitle(value);
            this._title = value;
        },
        addStudent: function(name) {
            var names = name.split(' ');
			var
                firstname = names[0],
                lastname = names[1];
				var
                tempStudent = {
                    firstname: validateNames(firstname),
                    lastname: validateNames(lastname),
                    id: this.students.length + 1,
                    score: 0
                };
            if(names.length != 2){
                throw new Error('treti curec');
            }

            this.students.push(tempStudent);
            return tempStudent.id;
        },
        getAllStudents: function() {
			//console.log(this.students.slice());
            return this.students.slice();

        },
        submitHomework: function(studentID, homeworkID) {
            validIDs(this.students, studentID);
            validIDs(this.presentations, homeworkID);
            this.presentations[homeworkID-1].homework.studentIDs.push(studentID);
            return this;
        },
        pushExamResults: function(results) {

            if(!(Array.isArray(results))){
                throw new Error('peti curec');
            }
            this.students = validateExamResults(results, this.students);

            return this;
        },
        getTopStudents: function() {
        }
    };

    return Course;
}


module.exports = solve;

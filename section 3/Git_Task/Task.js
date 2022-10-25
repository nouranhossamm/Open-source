// Task: Work on Your Own
// You're asked to implement a website that: -
// 1- Takes the name of the user in a prompt
// 2- Returns it in a reversed order in an alert.

// This task will be submitted in a Google Form, but this time you will be asked to hand over the public
// GitHub repository that you created that contains the code for this task.

// Please, make sure to do the following: -
// 1) Create the repository from your own repository
// 2) Make the repository contains at least 2 commits


var name = prompt('Plz, enter your name: ');
var size = name.length;
var reversedName = ''

for( let i = size-1 ; i >= 0 ; i-- ){
    reversedName+= name[i];
}

alert(reversedName);


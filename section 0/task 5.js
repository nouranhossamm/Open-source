/*
Create a web page that do the following: -
1) Asks the user for a number (N) in a dialog
2) Asks the user for others numbers N times in a dialog
3) Outputs the N numbers in another dialog

Example:
IN> 3
IN> 1
IN> 2
IN> 3
OUT> 6
*/

// with for loop

var t = parseInt( prompt("Plz, enter the number of numbers: ") )
var sum = 0
for ( let i = t ; i > 0 ; i-- ){
    sum += parseInt( prompt() )
}

console.log( sum )

// with while loop

var t = parseInt(prompt("Plz, enter the number of numbers: "));
var sum = 0;
while (t--) {
  sum += parseInt(prompt());
}

console.log(sum);

// with do-while loop

var t = parseInt(prompt("Plz, enter the number of numbers: "));
t--;
var sum = 0;
do {
  sum += parseInt(prompt());
}while (t--)

console.log(sum);
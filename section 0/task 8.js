/*
Create a web page that do the following: -
1) Asks the user for a string in a dialog
2) Outputs the sum of the string characters' ranks in the alphabtical order in another dialog

Example:
IN> abc
OUT> 6

Explanation:
a = 1, b = 2, c = 3
*/

var str = prompt("Plz, enter the letters: ")
var sum = 0
for ( let i = 0; i < str.length ; i++ ){
    sum += str[i].charCodeAt() - 96
}

console.log( sum )
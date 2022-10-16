/*
Create a web page that do the following: -
1) Asks the user for a number (C) in a dialog
2) Outputs the corresponding value of this number in fahrenheit in another dialog

Example:
IN> 40
OUT> 104
*/

var c = parseFloat( prompt() )
var f = ( c * 1.8 ) +32

console.log( f )
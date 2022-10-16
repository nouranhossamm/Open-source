/*
Create a web page that do the following: -
1) Asks the user for a string in a dialog
2) Outputs the upper case of this string in another dialog

Example:
IN> ibrahim
OUT> IBRAHIM
*/

// with toUpperCase() method

var name = prompt("Plz, enter your name: ")
name = name.toUpperCase()

console.log( name )


// with ASCII Code

var name = prompt("Plz, enter your name: ")
var newName = ""
for ( let i = 0; i < name.length ; i ++ ){
    var Char = name[i].charCodeAt() -32
    newName += String.fromCharCode( Char )
}

console.log( newName )

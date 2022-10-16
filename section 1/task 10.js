/*
Create a web page that do the following: -
1) Asks the user for the length of an array in a dialog
2) Asks the user for each value in the array in a dialog
2) Outputs the last even number in the array in another dialog

Example:
IN> 3
IN> 1
IN> 2
IN> 3
OUT> 2
*/

var arr = []
var lastEven = 0
var size = parseInt(prompt('enter the size of the array: '))
for( let i = 0 ; i < size ; i++ ){
    arr.push(parseInt(prompt('enter the num: ')))
}

for( let i = size-1 ; i >= 0 ; i-- ){
        if( arr[i] % 2 == 0 ){
            lastEven = arr[i]
            break
        }
}

console.log(lastEven)
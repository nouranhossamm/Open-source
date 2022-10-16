/*
Create a web page that do the following: -
1) Asks the user for the length of an array in a dialog
2) Asks the user for each value in the array in a dialog
2) Outputs the most frequent number and the number of frequency in another dialog

Example:
IN> 5
IN> 1
IN> 2
IN> 3
IN> 4
IN> 2
OUT> 2 with frequency of 2
*/

var arr = []
var freq = []
var size = parseInt(prompt('enter the size of the array: '))
var max_freq = 0

for( let i = 0 ; i < size ; i++ ){
    arr.push(parseInt(prompt('enter the num: ')))
}

for( let i = 1 ; i <= size ; i++ ){
    freq [i] = 0
}

for( let i = 0 ; i < size ; i++ ){
    freq [ arr[i] ]++ 
}

for( let i = 0 ; i <= size ; i++ ){
    if (freq[i] >= max_freq){
        max_freq = freq[i]
        num = i
    }
}

console.log(num + " with frequency " + max_freq)

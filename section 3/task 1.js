var arr = []
var size = parseInt(prompt('enter the size of the array: '))
var sum = 0
var count = 0

for ( let i = 0 ; i < size ; i++ ){
    arr[i] = parseInt(prompt('enter the num: '))
    if ( arr[i] < 0 ){
        count++
        sum+= arr[i]
    }   
} 

var avg = sum / count

console.log("the average = " + avg )
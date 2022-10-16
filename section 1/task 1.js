/*var str = prompt('enter the string: ')
var freq = 0
for( let i = 0 ; i < str.length ; i++ ){
    if ( str[i] == 'a' || str[i] == 'A')
        freq++
}

console.log(freq)
*/

/**
 * var str = prompt('enter the string: ')

for( let i = str.length -1 ; i >= 0  ; i-- ){
    if ( str[i] == 'a' || str[i] == 'A'){
        console.log(i)
        break
    }
        
}
 */

/*
var str = prompt('enter the string: ')
var newStr = ''

for( let i = 0 ; i < str.length ; i++ ){
    if ( str[i] != 'a' && str[i] != 'A'){
        newStr += str[i]
    }       
}


console.log(newStr)
*/

/*
var arr = []
var max = -Infinity
var size = parseInt(prompt('enter the size of the array: '))
for( let i = 0 ; i < size ; i++ ){
    arr.push(parseInt(prompt('enter the num: ')))
}

for( let i = 0 ; i < size ; i++ ){
        if( max < arr[i] )
        max = arr[i]
}

// for( let i = 0 ; i < size ; i++ ){
//     console.log(arr[i])
// }
console.log(max)
*/

/*
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
*/

var arr = []
var freq = []
var size = parseInt(prompt('enter the size of the array: '))

for( let i = 0 ; i < size ; i++ ){
    arr.push(parseInt(prompt('enter the num: ')))
}

for( let i = 1 ; i <= size ; i++ ){
    freq [i] = 0
}

for( let i = 0 ; i < size ; i++ ){
    freq [ arr[i] ]++ 
}

for( let i = 1 ; i <= size ; i++ ){
    if ( freq [i] != 0)
        console.log( i + ": " + freq [i]) 
}
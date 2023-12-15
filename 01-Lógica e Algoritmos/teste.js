



// const vetor = [1, 2, 7, 8];
// for (let n of vetor) {
//     let num = n;
//     let char = '-';    

//     for (let l = 1; l <= num; l++) { // linha

//         let linha = '';

//         for (let c = 1; c <= num; c++) { //coluna

//             // lanche, seleciona o char 
//             char = c-l+1
//             if(c-l < 0){
//                 char=Math.abs(c-l)+1
//             }

//             //verifica final da linha e coluna
//             if (c === num || l === num) {
//                 //char = num;
//             }
//             if (c === num && l === num) {
//                 linha += ` ${char}\n`;

//             } else if (c === num) {
//                 linha += ` ${char}`;

//             } else {
//                 linha += ` ${char}  `;

//             }
//         }
//         console.log(linha);

//     }
// }












// const vetor = [1, 2, 7, 8];
// for (let n of vetor) {
//     let num = n;
//     let char = '1';
//     let contador = 0;
//     let diagonal = n

//     for (let l = 1; l <= num; l++) { // linha

//         let linha = '';

//         for (let c = 1; c <= num; c++) { //coluna

//             // lanche, seleciona o char 
//             if (c > contador && c < diagonal) {
//                 char = l
//             } else if (c <= contador && c <= diagonal) {
//                 char = c
//             } else if (c <= contador && c >= diagonal) {
//                 char = diagonal
//             } else {                
//                 char = n+1-c
//             }
//             if (c === num) {
//                 contador++
//                 diagonal--
//             }

//             //verifica final da linha e coluna
//             if (c === num || l === num) {
//                 //char = num;
//             }
//             if (c === num && l === num) {
//                 linha += ` ${char}\n`;

//             } else if (c === num) {
//                 linha += ` ${char}`;

//             } else {
//                 linha += ` ${char}  `;

//             }
//         }
//         console.log(linha);

//     }
// }




var input = require('fs').readFileSync('/dev/stdin', 'utf8');
var lines = input.split('\n');

while(true){
    var N =parseInt(lines.shift());
    
    if(N === 0){
        break;
    }
    var matriz = [];
    for(var i =0; i< N;i++){
        matriz.push([]);
        for(var j = 0; j < N; j++){
            matriz[i].push(Math.abs(i - j) + 1);
        }
    }
    for(var i = 0; i < N; i++){
      var row = '';
        for(var j =0; j <N; j++){
         row += matriz[i][j].toString().padStart(3, ' ');
         if(j < N -1){
             row += ' ';
         }
    }
    console.log(row);
  }
  console.log('');
}





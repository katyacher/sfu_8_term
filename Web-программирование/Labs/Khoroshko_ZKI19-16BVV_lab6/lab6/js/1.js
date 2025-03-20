var i, myarr;
myarr = new Array(20);
document.write("Последовательность чисел: ")
for (i = 0; i<myarr.length; i+=1){
  myarr[i] =  Math.floor(Math.random() * (10 - 1)) + 1;
  if (i == myarr.length-1){
    document.write( myarr[i])
  }
  else{
     document.write( myarr[i]+ ", ");
  }
 
}
function sum(arr){
  var s = 0; 
  for(var index = 0; index<arr.length; index+=1){
    s = s+arr[index];
  }
  return s;
}
var summa = sum(myarr);
document.write("<br \/> Сумма чисел = " + summa + "<br \/>");

var i, myarr;
myarr = new Array(10);
document.write("Последовательность чисел: ")
for (i = 0; i<myarr.length; i+=1){
  myarr[i] =  Math.floor(Math.random() * (100 - 1)) + 1;
  if (i == myarr.length-1){
    document.write( myarr[i])
  }
  else{
     document.write( myarr[i]+ ", ");
  }
}
function min(arr){
  var m = myarr[0];
  for (i = 0; i<myarr.length; i+=1){
    if (m>myarr[i+1]){
      m = myarr[i+1]
    }
  }
  return m;
}

var minimum = min(myarr);
document.write("<br \/> Минимальное значение  = " + minimum);

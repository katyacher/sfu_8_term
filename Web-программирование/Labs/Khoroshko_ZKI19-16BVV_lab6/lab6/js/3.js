var i, myarr;
myarr = new Array(20);
document.write("Последовательность чисел: ")
for (i = 0; i<myarr.length; i+=1){
  myarr[i] =  Math.floor(Math.random() * (10));
  if (i == myarr.length-1){
    document.write( myarr[i])
  }
  else{
     document.write( myarr[i]+ ", ");
  }
}
function nullcounter(arr){
  var counter = 0;
  for (i = 0; i<myarr.length; i+=1){
    if (myarr[i] == 0){
      counter+=1;
    }
  }
  return counter;
}

var nulls = nullcounter(myarr);
document.write("<br \/> Колличество нулей = " + nulls + "<br \/>");

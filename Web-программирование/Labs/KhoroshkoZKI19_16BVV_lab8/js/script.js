
console.log("Практическое задание 8");
console.log("Создание объектов:");
var user = {
	name:{
		first: 'Ekaterina',
		last: 'Khoroshko'
	},
	mail: 'katyacher@inbox.ru',
	birthday: new Date("1985 10 18"),
	greating: function(){
		console.log("Hi, I'm "+ this.name.last + " " + this.name.first + "!")
	}
};

user.greating();
console.log(user.mail);
console.log("Birth Day: " + user.birthday);

var user2 = new Object();
user2.name = new Object();
user2.name.first = "Aleksander";
user2.name.last = "Khoroshko";
user2.mail = "alex@gmail.com";
user2.birthday = new Date("1985 7 20");
user2.greating = function(){
		console.log("Hi, I'm "+ this.name.last + " " + this.name.first + "!")
	}

user2.greating();
console.log(user2.mail);
console.log("Birth Day: " + user2.birthday);

console.log("Создание объектов через конструктор:");

function User(name,surname, mail, date){
	this.name = new Object();
	this.name.first = name;
	this.name.last = surname;
	this.mail = mail;
	this.birthday = new Date(date);
	this.greating = function(){
		console.log("Hi, I'm "+ this.name.last + " " + this.name.first + "!")
	};
}

var user3 = new User("Vladimir","Khoroshko","vladimir@gmail.com", "2017 3 16");
user3.greating();
user3.mail = "vk@gmail.com";
console.log(user3.mail);
console.log("Birth Day: " + user3.birthday);

console.log("Расширение встроенного типа Array: поиск среднего арифметического массива чисел.");

var arr = [];
var len = +prompt("Введите длинну массива: ", "");
arr.length = len;

for (let i = 0; i < arr.length; i++) {
  	arr[i] = +prompt("Элемент массива " + i + "\n   Введите число: ", "");
}

console.log(arr);

Array.prototype.average = function(){
	var sum = 0;
	var count = 0;
	this.forEach(function(value, index, array) {
		if (!isNaN(value)){
        	sum += value;
        	count+=1;
    	}
    }); 
	var average = sum/count;
	return average; 
};

console.log(arr.average());

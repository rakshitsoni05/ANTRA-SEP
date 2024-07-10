let salaries = {
    John: 100,
    Ann: 160,
    Pete: 130
};

function sumSalaries(salaries) {
    let sum = 0;
    for (var person in salaries) {
        sum += salaries[person];
    }
    return sum;
}

let totalSalaries = sumSalaries(salaries);
console.log(totalSalaries); 

console.log("-----------------------------------------------------------"); 

let menu = {
    width: 200,
    height: 300,
    title: "My menu"
};

function multiplyNumeric(menu) {
    for (var item in menu) {
        if (typeof menu[item] === 'number') {
            menu[item] *= 2;
        }
    }
}

multiplyNumeric(menu);

console.log(menu);

console.log("-----------------------------------------------------------");

function checkEmailId(str) {

    var atIndex = str.toLowerCase().indexOf('@');
    var dotIndex = str.toLowerCase().lastIndexOf('.');

    return atIndex !== -1 && dotIndex > atIndex + 1 && dotIndex < str.length - 1;
}

console.log(checkEmailId('john.doe@example.com')); 
console.log(checkEmailId('john.doe@')); 
console.log(checkEmailId('john.doe@example')); 

console.log("-----------------------------------------------------------"); 

function truncate(str, maxlength) {
    if (str.length > maxlength) {
        return str.slice(0, maxlength - 3) + '...';
    }
    return str;
}

console.log(truncate("What I'd like to tell on this topic is:", 20)); 
console.log(truncate("Hi everyone!", 20));

console.log("-----------------------------------------------------------"); 

let styles = ["James", "Brennie"];

styles.push("Robert"); 
console.log(styles);

let middleIndex = Math.floor(styles.length / 2);
styles[middleIndex] = "Calvin"; 
console.log(styles); 

let removedValue = styles.shift(); 
console.log(removedValue); 
console.log(styles); 

styles.unshift("Rose", "Regal"); 
console.log(styles); 





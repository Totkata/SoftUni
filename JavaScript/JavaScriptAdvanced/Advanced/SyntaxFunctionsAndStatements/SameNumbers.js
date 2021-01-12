function SameNumbers(number){

    let num = number.toString();
    let sum = parseInt(num[0]);
    let isSame = true;
    let lastElement = num[0];

    for (let i = 1; i < num.length; i++) {
        const element = num[i];
        
        sum += parseInt(element);

        if (lastElement != element) {
            isSame = false;
        }
    }
    
    if (isSame) {
        console.log('true')
        console.log(sum)
    }
    else {
        console.log('false')
        console.log(sum)
    }
}

SameNumbers(2222222)
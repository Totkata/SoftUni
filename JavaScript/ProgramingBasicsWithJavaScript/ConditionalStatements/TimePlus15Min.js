function solve(input) {
    let hour =Number(input.shift());
    let min = Number(input.shift());

    let sum = ((hour * 60) + min + 15);
    let resulthour = sum / 60;
    if (resulthour >= 24)
    {
        resulthour -= 24;
    }
    let resultmin = sum % 60;
    let result = "0"
    if (resultmin < 10) {
         result += resultmin.toString();
    }
    else {
        result = resultmin.toString();
    }

    console.log(`${Math.floor(resulthour)}:${result}`);
}
solve([
    12,
    49    
]);
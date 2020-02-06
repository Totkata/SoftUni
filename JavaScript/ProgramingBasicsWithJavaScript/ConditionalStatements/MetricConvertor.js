function solve(input) {
    let numberToConvert = Number(input.shift());

    let type = input.shift();
    let typeToConvert = input.shift();

    let converted = 0;
    if (type == "m")
    {
        if (typeToConvert == "mm")
        {
            converted = numberToConvert * 1000;
            console.log(converted.toFixed(3));
        }
        else if (typeToConvert == "cm")
        {
            converted = numberToConvert * 100;
            console.log(converted.toFixed(3));
        }
    }
    else if (type == "mm")
    {
        if (typeToConvert == "m")
        {
            converted = numberToConvert / 1000;
            console.log(converted.toFixed(3));
        }
        else if (typeToConvert == "cm")
        {
            converted = numberToConvert / 10;
            console.log(converted.toFixed(3));
        }
    }
    else if (type == "cm")
    {
        if (typeToConvert == "mm")
        {
            converted = numberToConvert * 10;
            console.log(converted.toFixed(3));
        }
        else if (typeToConvert == "m")
        {
            converted = numberToConvert / 100;
            console.log(converted.toFixed(3));
        }
    }
}
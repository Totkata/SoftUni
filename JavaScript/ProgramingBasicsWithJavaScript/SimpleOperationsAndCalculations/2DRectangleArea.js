function calculation(input) {

    var num1 = Number(input.shift());
    var num2 = Number(input.shift());
    var num3 = Number(input.shift());
    var num4 = Number(input.shift());

    var coordinatOne = Math.abs(num1 - num3);
    var coordinatTwo = Math.abs(num2 - num4);

    var area = coordinatOne * coordinatTwo;
    var perimeter = 2 * (coordinatTwo + coordinatOne);

    console.log(area.toFixed(2));
    console.log(perimeter.toFixed(2));
}
calculation(["60",
    "20",
    "10",
    "50"
]);
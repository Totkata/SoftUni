function radsToDegree(input) {

    let num = Number(input);
    let degreeConvert = num * 180 / Math.PI;
    let roundedResult = Math.round(degreeConvert);

    console.log(roundedResult);
}
radsToDegree([
    "3.1416"
]);
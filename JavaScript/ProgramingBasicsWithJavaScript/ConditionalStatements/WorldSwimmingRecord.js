function solve(input) {
    let recordSeconds =Number(input.shift());
    let metersToSwim = Number(input.shift());
    let secondsForMeter = Number(input.shift());

    let  floor = metersToSwim / 15;
    let formated = Math.floor(floor);
    let timeIvanGetsSwoled = formated * 12.5;

    let ivansTime = metersToSwim * secondsForMeter + timeIvanGetsSwoled;

    if (recordSeconds > ivansTime)
    {
        console.log(`Yes, he succeeded! The new world record is ${ivansTime.toFixed(2)} seconds.`);
    }
    else
    {
        let secondsIvanNeed = ivansTime - recordSeconds;
        console.log(`No, he failed! He was ${secondsIvanNeed.toFixed(2)} seconds slower.`);
    }
}
solve([
    55555.67,
3017,
5.03
])
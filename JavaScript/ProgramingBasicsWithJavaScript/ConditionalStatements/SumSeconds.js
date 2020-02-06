function solve(input) {
    let firstTime = Number(input.shift());
            let secondTime = Number(input.shift());
            let thirdTime = Number(input.shift());

            let timeSum = firstTime + secondTime + thirdTime;

            let minutes = Math.floor(timeSum / 60);
            let seconds = timeSum % 60;

            if (seconds < 10)
            {
                console.log(`${minutes}:0${seconds}`);
            }
            else
            {
                console.log(`${minutes}:${seconds}`);
            }
}
solve([
    35,
45,
44
]);
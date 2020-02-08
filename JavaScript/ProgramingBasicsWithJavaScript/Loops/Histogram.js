function solve(input) {
    let n = Number(input.shift());
    let UpTo199 = 0;
    let UpTo300 = 0;
    let UpTo599 = 0;
    let UpTo799 = 0;
    let UpTo800 = 0;
    for (let i = 0; i < n; i++)
    {
        let number = Number(input.shift());

        if (number >= 1 && number < 200)
        {
            UpTo199++;
        }
        else if (number >= 200 && number < 400)
        {
            UpTo300++;
        }
        else if (number >= 400 && number < 600)
        {
            UpTo599++;
        }
        else if (number >= 600 && number < 800)
        {
            UpTo799++;
        }
        else
        {
            UpTo800++;
        }
    }

    let output = (UpTo199 / n) * 100;
    let output2 = (UpTo300 / n) * 100;
    let output3 = (UpTo599 / n) * 100;
    let output4 = (UpTo799 / n) * 100;
    let output5 = (UpTo800 / n) * 100;

    console.log(`${output.toFixed(2)}%`);
    console.log(`${output2.toFixed(2)}%`);
    console.log(`${output3.toFixed(2)}%`);
    console.log(`${output4.toFixed(2)}%`);
    console.log(`${output5.toFixed(2)}%`);
}
solve([
    3,
1,
2,
999
]);
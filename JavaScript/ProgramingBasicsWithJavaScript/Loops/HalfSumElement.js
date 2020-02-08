function solve(input) {
    let n = Number(input.shift())
    let bigest = Number.MIN_VALUE;
    let sum = 0;

    for (let i = 0; i < n; i++)
    {
        let num = Number(input.shift())
        if (num > bigest)
        {
            bigest = num;
        }
        sum += num;
    }
    if (sum - bigest == bigest)
    {
        console.log("Yes");
        console.log(`Sum = ${sum - bigest}`);
    }
    else
    {
        let diff = Math.abs(bigest - (sum - bigest));
        console.log("No");
        console.log(`Diff = ${diff}`);
    }
}
solve([
    3,
1,
1,
10
]);
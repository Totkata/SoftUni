function solve(input) {
    let n = Number(input.shift());
    let p1 = 0;
    let p2 = 0;
    let p3 = 0;

    for (let i = 1; i <= n; i++)
    {
        let num = Number(input.shift());
        if (num % 4 == 0)
        {
            p3++;
        }
        if (num % 3 == 0)
        {
            p2++;
        }
        if (num % 2 == 0)
        {
            p1++;
        }
    }
    let p1P = p1 / n * 100;
    let p2P = p2 / n * 100;
    let p3P = p3 / n * 100;

    console.log(`${p1P.toFixed(2)}%`);
    console.log(`${p2P.toFixed(2)}%`);
    console.log(`${p3P.toFixed(2)}%`);
}
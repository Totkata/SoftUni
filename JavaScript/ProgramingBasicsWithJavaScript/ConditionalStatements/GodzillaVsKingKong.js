function solve(input) {
    let buget = Number(input.shift())
    let statists = Number(input.shift())
    let statistClothPrice = Number(input.shift())

    let discount = 0;
    let decors = buget * 0.1;

    if (statists > 150)
    {
        discount = (statistClothPrice * statists) * 0.1;
    }

    let totalClothPrice = (statistClothPrice * statists) - discount;
    let total = totalClothPrice + decors;

    if (total > buget)
    {
        let moneyNeeded = total - buget;
        console.log("Not enough money!");
        console.log(`Wingard needs ${moneyNeeded.toFixed(2)} leva more.`);
    }
    else
    {
        let moneyLeft = buget - total;
        console.log("Action!");
        console.log(`Wingard starts filming with ${moneyLeft.toFixed(2)} leva left.`);
    }
}
solve([
    9587.88,
222,
55.68
]);
function solve(input) {
    let income = Number(input.shift());
    let grades = Number(input.shift());
    let minimumIncome = Number(input.shift());

    let floor = minimumIncome * 0.35;
    let socialScolarship = Math.floor(floor);
    let floor2 = grades * 25;
    let scolarship = Math.floor(floor2);


    if (grades >= 5.5)
    {
        if (scolarship >= socialScolarship || income > minimumIncome)
        {
            console.log(`You get a scholarship for excellent results ${scolarship} BGN`);
        }
        else
        {
            console.log(`You get a scholarship for excellent results ${scolarship} BGN`);
        }
    }
    else if (income < minimumIncome && grades > 4.5)
    {
        console.log(`You get a Social scholarship ${socialScolarship} BGN`);
    }
    else
    {
        console.log("You cannot get a scholarship!");
    }
}
solve([
    480.00,
4.60,
450.00
])
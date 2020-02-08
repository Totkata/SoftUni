function solve(input) {
    let tabCount = Number(input.shift());

    let salary = Number(input.shift());
    for (let i = 0; i < tabCount; i++)
    {
        let tab = input.shift();

        if (tab == "Facebook")
        {
            salary -= 150;
        }
        else if (tab == "Instagram")
        {
            salary -= 100;
        }
        else if (tab == "Reddit")
        {
            salary -= 50;
        }
        if (salary <= 0)
        {
            console.log("You have lost your salary.");
            return;
        }
    }
    console.log(salary);
}
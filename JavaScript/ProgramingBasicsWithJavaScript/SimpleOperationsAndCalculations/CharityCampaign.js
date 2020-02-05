function solution(input) {
   var dayCount = Number(input.shift());
   var bakerCount = Number(input.shift());
   var cakeCount = Number(input.shift());
   var gofretsCount = Number(input.shift());
   var pancakesCount = Number(input.shift());

   var cakePrice = 45;
   var gofretsPrice = 5.80;
   var pancakesPrice = 3.20;
   var cakeTotal = cakePrice * cakeCount;
   var gofretsTotal = gofretsPrice * gofretsCount;
   var pancakesTotal = pancakesPrice * pancakesCount;
   var totalForADay = (cakeTotal + gofretsTotal + pancakesTotal) * bakerCount;
   var totalSum = totalForADay * dayCount;
   var expenses = totalSum / 8;
   var profit = totalSum - expenses;

   console.log(profit.toFixed(2));
}
solution(["20",
"8",
"14",
"30",
"16"]);
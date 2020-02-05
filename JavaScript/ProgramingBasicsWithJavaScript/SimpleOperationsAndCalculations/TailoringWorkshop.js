function solution(input) {
    var quantityOfTheOrder = Number(input.shift());
    var lenghtOfTheTable = Number(input.shift());
    var widthOfTheTable = Number(input.shift());

    var quadsSide = lenghtOfTheTable / 2;

    var tableClothPrice = 7;
    var quadsClothPriceUSD = 9;

    var USDtoBGN = 1.85;

    var tableArea = (lenghtOfTheTable + 2 * 0.30) * (widthOfTheTable + 2 * 0.30);

     var quadsArea = quadsSide * quadsSide;

    var priceForTableclothsUSD = (tableArea * quantityOfTheOrder) * tableClothPrice; 
    var priceForQuadsUSD = (quadsArea * quantityOfTheOrder) * quadsClothPriceUSD;

    var totalPrice = priceForTableclothsUSD + priceForQuadsUSD;
    var totalPriceBGN = totalPrice * USDtoBGN;

    console.log(totalPrice.toFixed(2) + " USD");
    console.log(totalPriceBGN.toFixed(2) + " BGN");
}
solution(["5",
    "1.00",
    "0.50"]);
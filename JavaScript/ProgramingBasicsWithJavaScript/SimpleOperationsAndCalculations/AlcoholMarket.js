function solution (input) {
var whiskeyCost = Number(input.shift());
var beerQuantity = Number(input.shift());
var wineQuantity = Number(input.shift());
var rakiqQuantity = Number(input.shift());
var whiskeyQuantity = Number(input.shift());

var rakiqCost = whiskeyCost / 2;
var wineCost = rakiqCost * 0.6;
var beerCost = rakiqCost * 0.2;

var totalWhiskey = whiskeyCost * whiskeyQuantity;
var totalBeer = beerCost * beerQuantity;
var totalWine = wineCost * wineQuantity;
var totalRakiq = rakiqCost * rakiqQuantity;

var totalPrice = totalWhiskey + totalBeer + totalWine + totalRakiq;

console.log(totalPrice.toFixed(2))
}
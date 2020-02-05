function solution(input) {
    var roomsLenght = Number(input.shift());
    var roomsWidht = Number(input.shift());
    var wardrobeSide = Number(input.shift());
    var convertToSantimeters = 100;

    var roomsArea = (roomsLenght*convertToSantimeters) * (roomsWidht * convertToSantimeters);
    var converteedWardrobeSide = wardrobeSide * convertToSantimeters;
    var wardrobeArea = (converteedWardrobeSide * converteedWardrobeSide);
    var benchArea = roomsArea / 10;

    var areaLeft = roomsArea - (wardrobeArea + benchArea);
    var dancePlace = 40 + 7000;
    var dancers = areaLeft / dancePlace;

    console.log(Math.floor(dancers));
}
solution(["50",
    "25",
    "2"]);
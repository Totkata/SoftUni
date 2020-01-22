using System;

namespace DanceHall
{
    class Program
    {
        static void Main(string[] args)
        {
            double roomsLenght = double.Parse(Console.ReadLine());
            double roomsWidht = double.Parse(Console.ReadLine());

            double wardrobeSide = double.Parse(Console.ReadLine());

            int convertToSantimeters = 100;

            double roomsArea = (roomsLenght * convertToSantimeters) * (roomsWidht * convertToSantimeters);
            double converteedWardrobeSide = wardrobeSide * convertToSantimeters;
            double wardrobeArea = (converteedWardrobeSide * converteedWardrobeSide);
            double benchArea = roomsArea / 10;

            double areaLeft = roomsArea - (wardrobeArea + benchArea);

            int dancePlace = 40 + 7000;

            double dancers = areaLeft / dancePlace;

            Console.WriteLine(Math.Floor(dancers));
        }
    }
}

using System;

namespace SeparateTextWithMarkers
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullName = "SENAI Informática";
            // This variable holds all the separated parts from the original string variable 'fullName'
            var nameParts = fullName.Split(' ');
            foreach (var namePart in nameParts)
            {
                Console.WriteLine(namePart);
            }
        }
    }
}

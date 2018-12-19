using System;

namespace SeparateTextWithMarkers
{
    class Program
    {
        static void Main(string[] args)
        {
            var csvContent = "Fruit Name,Price\nOrange,3\nApple,2\nPineapple,4\n";
            // Separating lines
            var lines = csvContent.Split('\n', StringSplitOptions.RemoveEmptyEntries);
            //
            for(int row = 0; row < lines.Length; row++)
            {
                // Separating data inside each line
                var items = lines[row].Split(',');
                foreach (var item in items)
                {
                    Console.Write("{0,16}", item);
                }
                Console.WriteLine();
            }
        }
    }
}

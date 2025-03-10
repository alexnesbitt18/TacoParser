﻿namespace LoggingKata
{
    /// <summary>
    /// Parses a POI file to locate all the Taco Bells
    /// </summary>
    public class TacoParser
    {
        readonly ILog logger = new TacoLogger();
        
        public ITrackable Parse(string line)
        {
            logger.LogInfo("Begin parsing");

            // Take your line and use line.Split(',') to split it up into an array of strings, separated by the char ',' --Done
            var cells = line.Split(',');

            // If your array.Length is less than 3, something went wrong --Done
            if (cells.Length < 3)
            {
                // Log that and return null --Done

                logger.LogWarning("Less than 3 items, incomplete dataset.");

                // Do not fail if one record parsing fails, return null --Done
                return null; // TODO Implement
            }

            // grab the latitude from your array at index 0 --Done
            var latitude = double.Parse(cells[0]);
            // grab the longitude from your array at index 1 --Done
            var longitude = double.Parse(cells[1]);
            // grab the name from your array at index 2 --Done
            var name = cells[2];

            // You'll need to create a TacoBell class
            // that conforms to ITrackable -- Done

            // Then, you'll need an instance of the TacoBell class
            // With the name and point set correctly --Done

            var tacoBell = new TacoBell();
            var point = new Point();
            point.Latitude = latitude;
            point.Longitude = longitude;

            tacoBell.Name = name;
            tacoBell.Location = point;

            // Then, return the instance of your TacoBell class
            // Since it conforms to ITrackable

            return tacoBell;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggingKata
{
    
    public class TacoBell : ITrackable
    {
        public TacoBell() 
        {

        }
        public TacoBell(double latitude, double longitude, string name)
        {
            Point tacoBellLocation = new Point()
            {
                Latitude = latitude,
                Longitude = longitude,
            };
            Name = name;
            Location = tacoBellLocation;
        }
        public string Name { get; set; }
        public Point Location { get; set; }
    }


}

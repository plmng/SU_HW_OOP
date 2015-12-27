namespace Problem1.GalacticGPS
{
    using System;

    public struct Location
    {
        private double _latitude;
        private double _longitude;
        private Planet planet;

        public Location(double latitude, double longitude, Planet planet): this()
        {
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.Planet = planet;
        }
       
        public double Latitude
        {
            get { return this._latitude; }
            set
            {
                if (value < -90 || value > 90)
                {
                    throw new ArgumentOutOfRangeException("Latitude", "Latitude is in the range [-90..90]");
                }
                this._latitude = value;
            }
        }

        public double Longitude
        {
            get { return this._longitude; }
            set
            {
                if (value < -180 || value > 180)
                {
                    throw new ArgumentOutOfRangeException("Longitude", "Longitude is in the range [-180..180]");
                }
                this._longitude = value;
            }
        }

        public Planet Planet { get; set; }

        public override string ToString()
        {
            var str = string.Format("{0}, {1} - {2}", this.Latitude, this.Longitude, this.Planet);
            return str;
        }
    }
}

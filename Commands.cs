namespace Lunatic
{
    internal enum DecSign
    {
        Plus,
        Minus
    }

    //
    internal class AstronomicalPosition
    {
        // 1 increment in mount position = 1/12 of an arcsecond 
        private readonly double step_resolution = 1.078781893;

        public int RA { get; private set; }

        public int DEC { get; private set; }

        public string RaText
        {
            get
            {
                return string.Format("{0}:{1}:{2}", RaHours, RaMinutes, RaSeconds);

            }
        }

        public string DecText
        {
            get
            {
                return string.Format("{0}:{1}:{2}", DecDegrees, DecMinutes, DecSeconds);

            }
        }

        public int RaHours { get; private set; }

        public int RaMinutes { get; private set; }

        public int RaSeconds { get; private set; }

        public int TotalRaSeconds { get; private set; }

        public int TotalDecSeconds { get; private set; }

        public DecSign Sign { get; private set; }

        public int DecDegrees { get; private set; }

        public int DecMinutes { get; private set; }

        public double DecSeconds { get; private set; }

        public AstronomicalPosition(int ra, int dec)
        {
            RA = ra;
            DEC = dec;

            SetCoordinates();
        }

        public AstronomicalPosition WithOffset(int ra_offset, int dec_offset)
        {
            return new AstronomicalPosition(this.RA + ra_offset, this.DEC + dec_offset);
        }

        public AstronomicalPosition Clone()
        {
            return new AstronomicalPosition(this.RA, this.DEC);
        }

        private void SetCoordinates()
        {
            // 1/12 of an arcsecond
            TotalRaSeconds =(int)( RA / 12 / 15 / step_resolution);
            TotalDecSeconds = (int)(DEC / 12 / step_resolution);

            RaHours = (int)(TotalRaSeconds / 60 * 60);
            RaMinutes = (int)(TotalRaSeconds % 60 * 60) / 60;
            RaSeconds = TotalRaSeconds % 60;

            DecDegrees = (int)TotalDecSeconds / 60 * 60;
            DecMinutes = (int)(TotalDecSeconds % 60 * 60) / 60;
            DecSeconds = TotalDecSeconds % 60;
        }
    }
}

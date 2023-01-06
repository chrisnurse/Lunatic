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

        public long RA { get; private set; }

        public long DEC { get; private set; }

        public string RaText
        {
            get
            {
                return $"{RaHours:00}:{RaMinutes:00}:{RaSeconds:00}";
            }
        }

        public string DecText
        {
            get
            {
                var sign = Sign == DecSign.Plus ? "+" : "-";
                return $"{sign}{DecDegrees:00}° {DecMinutes:00}\' {DecSeconds:00}\"";

            }
        }

        public int RaHours { get; private set; }

        public int RaMinutes { get; private set; }

        public int RaSeconds { get; private set; }

        public long TotalRaSeconds { get; private set; }

        public long TotalDecSeconds { get; private set; }

        public DecSign Sign { get; private set; }

        public int DecDegrees { get; private set; }

        public int DecMinutes { get; private set; }

        public double DecSeconds { get; private set; }

        public AstronomicalPosition(long ra, long dec)
        {
            RA = ra;
            DEC = dec;

            SetCoordinates();
        }

        public AstronomicalPosition WithOffset(int ra_offset, int dec_offset)
        {
            return new AstronomicalPosition(this.RA + (long)(ra_offset * 12 * 15 * step_resolution), this.DEC + (long)(dec_offset * 12 * step_resolution));
        }

        public AstronomicalPosition Clone()
        {
            return new AstronomicalPosition(this.RA, this.DEC);
        }

        private void SetCoordinates()
        {
            TotalRaSeconds = (long)(RA / 12 / 15 / step_resolution);
            TotalDecSeconds = (long)(DEC / 12 / step_resolution);

            RaHours = (int)(TotalRaSeconds / (60 * 60)) % 24;
            RaMinutes = (int)(TotalRaSeconds % (60 * 60)) / 60;
            RaSeconds = (int)(TotalRaSeconds % 60);

            DecDegrees = (int)(TotalDecSeconds / (60 * 60)) % 360;


            if (DecDegrees > 180)
            {
                DecDegrees = (360 * 60) - DecDegrees;
                Sign = DecSign.Minus;
            }
            else
            {
                Sign = DecSign.Plus;
            }

            DecMinutes = (int)(TotalDecSeconds % (60 * 60)) / 60;
            DecSeconds = TotalDecSeconds % 60;
        }
    }
}

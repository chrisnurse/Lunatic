using System.Text;

namespace Lunatic
{
    internal abstract class CommandBase
    {
        public CommandBase() { }
        public abstract string GetCommand();
    }

    internal enum DecSign { 
        Plus,
        Minus
    }

    internal class SetPositionCommand : CommandBase {
        double RaHours { get; set; }
        
        double RaMinutes { get; set; }
        
        DecSign Sign { get; set; } 
        
        double DecDegrees { get; set; }

        double DecMinutes { get; set; }
        
        public SetPositionCommand(double RaHours, double RaMinutes, DecSign sign, double DecDegrees, double DecMinutes) {
            this.RaHours=RaHours; 
            this.RaMinutes=RaMinutes;
            
            this.Sign = sign;
            this.DecDegrees=DecDegrees; 
            this.DecMinutes=DecMinutes;
        }

        public override string GetCommand()
        {
            StringBuilder sb = new StringBuilder();

            var ra = (uint)(((RaHours * 60.0 + RaMinutes) * 15.0) * 3.0 * 1.011358);
            
            uint dec = 0;
            if (Sign == DecSign.Plus) {
                dec = (uint)((DecDegrees * 60 + DecMinutes) * 3 * 1.011358);
            }
            else {
                dec = (uint)(((360 * 60) - (DecDegrees * 60 + DecMinutes)) * 3 * 1.011358);
            }

            var ra_hi = ra / 256;
            var ra_lo = ra % 256;

            var dec_hi = dec / 256;
            var dec_lo = dec % 256;

            sb.Append(string.Format("R{0:X2}{1:X2},{2:X2}{3:X2}", ra_hi, ra_lo, dec_hi, dec_lo));

            return sb.ToString();
        }
    }
}

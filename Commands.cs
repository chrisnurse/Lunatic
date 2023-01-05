using System.Security.Policy;
using System.Text;

namespace Lunatic
{
    internal abstract class CommandBase
    {
        public CommandBase() { }
        public abstract string GetCommand();
    }

    internal enum DecSign
    {
        Plus,
        Minus
    }
    internal class AstronomicalPosition
    {
        public double RaHours { get; set; }

        public double RaMinutes { get; set; }

        public DecSign Sign { get; set; }

        public double DecDegrees { get; set; }

        public double DecMinutes { get; set; }
    }


}

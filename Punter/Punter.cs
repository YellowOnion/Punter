using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punter
{
    public enum PunterEnum
    {
        Joe,
        Bob,
        Alice
    }
    public abstract class Punter
    {
        public int wallet = 50;
        public int betAmount;
        public Greyhound betHound;
        public string name;
    }

    public static class PunterFactory
    {
        public static Punter ManufacturePunter(PunterEnum name)
        {
            switch (name)
            {
                case PunterEnum.Joe:
                    return new Joe();
                case PunterEnum.Bob:
                    return new Bob();
                case PunterEnum.Alice:
                    return new Alice();
            }

            return null;
        }
    }

    class Joe : Punter
    {
        public Joe()
        {
            name = "Joe Sieve";
        }
    }

    class Bob : Punter
    {
        public Bob()
        {
            name = "Bob \"Bobbie\" Bobson" ;
        }
    }

    class Alice : Punter
    {
        public Alice()
        {
            name = "Alice Inoderlun";
        }
    }
}

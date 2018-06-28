using Project4BettingRace.Business;

namespace Project4BettingRace
{
    class MadButcher : Punter
    {
        public MadButcher()
        {
            PunterName = "Mad Butcher";
            Pig = "";
            Cash = 50;
            Broke = false;
        }
    }
}
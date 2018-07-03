using Project4BettingRace.Business;

namespace Project4BettingRace
{
    class MrsPiggy : Punter
    {
        public MrsPiggy()
        {
            // set up values for punter
            PunterName = "Mrs Piggy";
            Pig = "";
            Cash = 50;
            Broke = false;
        }
    }
}
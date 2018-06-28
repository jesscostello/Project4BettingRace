using Project4BettingRace.Business;

namespace Project4BettingRace
{
    class MrsPiggy : Punter
    {
        public MrsPiggy()
        {
            PunterName = "Mrs Piggy";
            Pig = "";
            Cash = 50;
            Broke = false;
        }
    }
}
using Project4BettingRace.Business;

namespace Project4BettingRace
{
    class MrsPiggy : Punter, IBettingDetails
    {
        public MrsPiggy()
        {
            PunterName = "Mrs Piggy";
            Pig = "";
            Cash = 0;
            Broke = false;
        }
        public int Won { get; set; }
        public int Loss { get; set; }

        public int TotalBets()
        {
            return Won + Loss;
        }
    }
}
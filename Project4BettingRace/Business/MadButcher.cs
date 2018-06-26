using Project4BettingRace.Business;

namespace Project4BettingRace
{
    class MadButcher : Punter, IBettingDetails
    {
        public MadButcher()
        {
            PunterName = "Mad Butcher";
            Pig = "";
            Cash = 50;
        }
        public int Won { get; set; }
        public int Loss { get; set; }

        public int TotalBets()
        {
            return Won + Loss;
        }
    }
}
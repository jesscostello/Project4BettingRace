using Project4BettingRace.Business;

namespace Project4BettingRace
{
    class FarmerBrown : Punter, IBettingDetails
    {
        public FarmerBrown()
        {
            PunterName = "Farmer Brown";
            Pig = "";
            Cash = 30;
        }
        public int Won { get; set; }
        public int Loss { get; set; }

        public int TotalBets()
        {
            return Won + Loss;
        }
    }
}
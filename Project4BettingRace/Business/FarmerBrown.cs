using Project4BettingRace.Business;

namespace Project4BettingRace
{
    class FarmerBrown : Punter
    {
        public FarmerBrown()
        {
            // set up values for punter
            PunterName = "Farmer Brown";
            Pig = "";
            Cash = 50;
            Broke = false;
        }
    }
}
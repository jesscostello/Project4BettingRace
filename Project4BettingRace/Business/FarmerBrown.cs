using Project4BettingRace.Business;

namespace Project4BettingRace
{
    class FarmerBrown : Punter
    {
        public FarmerBrown()
        {
            PunterName = "Farmer Brown";
            Pig = "";
            Cash = 50;
            Broke = false;
        }
    }
}
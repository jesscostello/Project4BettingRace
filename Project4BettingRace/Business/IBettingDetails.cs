using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4BettingRace.Business
{
    interface IBettingDetails
    {
        int Won { get; set; }
        int Loss { get; set; }
        int TotalBets();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project4BettingRace
{
    class Pig
    {
        public string Name { get; set; }
        public int Length { get; set; }
        public PictureBox myPB { get; set; }

        // Direction which pig will travel towards
        public string Direction { get; set; }
    }
}

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
        //public int Length { get; set; }
        public PictureBox myPB { get; set; }
        // Side of the screen pig starts on
        public string StartingLocation { get; set; }
        public int StartingPosition { get; set; }
        public int FinishLine { get; set; }
        public bool Winner { get; set; }
        public Random myrnd { get; set; } = new Random();

        public void Run()
        {
            if (StartingLocation == "Top")
            {
                myPB.Top += myrnd.Next(0, 7);
            }
            if (StartingLocation == "Right")
            {
                myPB.Left -= myrnd.Next(0, 7);
            }
            if (StartingLocation == "Bottom")
            {
                myPB.Top -= myrnd.Next(0, 7);
            }
            if (StartingLocation == "Left")
            {
                myPB.Left += myrnd.Next(0, 7);
            } 
        }
    }
}

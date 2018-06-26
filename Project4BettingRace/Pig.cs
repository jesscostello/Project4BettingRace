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
        public string StartingLocation { get; set; }
        public int StartingPosition { get; set; }
        public int FinishLine { get; set; }
        public bool Winner { get; set; }
        public Random myrnd { get; set; } = new Random();

        public void Run()
        {
            //bool endRace = false;

            //while (endRace != true)
            //{
                //Application.DoEvents();
                if (StartingLocation == "Top")
                {
                    //while (Winner != true)
                    //{
                        //Application.DoEvents();
                        myPB.Top += myrnd.Next(1, 5);
                        //if ((myPB.Top + 89) > FinishLine)
                        //{
                        //    Winner = true;
                        //    //endRace = true;
                        //}
                    //}
                }
                else if (StartingLocation == "Right")
                {
                    //while (Winner != true)
                    //{
                        //Application.DoEvents();
                        myPB.Left -= myrnd.Next(1, 5);
                        //if ((myPB.Left) < FinishLine)
                        //{
                        //    Winner = true;
                        //    //endRace = true;
                        //}
                    //}
                }
                else if (StartingLocation == "Bottom")
                {
                    //while (Winner != true)
                    //{
                        //Application.DoEvents();
                        myPB.Top -= myrnd.Next(1, 5);
                        //if (myPB.Top < FinishLine)
                        //{
                        //    Winner = true;
                        //    //endRace = true;
                        //}
                    //}
                }
                else if (StartingLocation == "Left")
                {
                    //while (Winner != true)
                    //{
                        //Application.DoEvents();
                        myPB.Left += myrnd.Next(1, 5);
                        //if ((myPB.Left + 89) > FinishLine)
                        //{
                        //    Winner = true;
                        //    //endRace = true;
                        //}
                    //}
                } 
            //}
        }
    }
}

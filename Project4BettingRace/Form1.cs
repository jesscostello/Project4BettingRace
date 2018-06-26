using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project4BettingRace
{
    public partial class Form1 : Form
    {
        // Instantiate an array of pigs
        Pig[] myPig = new Pig[4];

        public Form1()
        {
            InitializeComponent();

            // Give the pigs starting variables
            myPig[0] = new Pig { Name = "Bacon", Length = 0, myPB = pb1, StartingLocation = "Top", StartingPosition = 1, FinishLine = 248 };
            myPig[0].myPB.BackgroundImage = Resource1.pig3;
            myPig[1] = new Pig { Name = "Pork", Length = 0, myPB = pb2, StartingLocation = "Right", StartingPosition = 492, FinishLine = 332 };
            myPig[1].myPB.BackgroundImage = Resource1.pig1;
            myPig[2] = new Pig { Name = "Ham", Length = 0, myPB = pb3, StartingLocation = "Bottom", StartingPosition = 493, FinishLine = 337 };
            myPig[2].myPB.BackgroundImage = Resource1.pig4;
            myPig[3] = new Pig { Name = "Ribs", Length = 0, myPB = pb4, StartingLocation = "Left", StartingPosition = 91, FinishLine = 243 };
            myPig[3].myPB.BackgroundImage = Resource1.pig2;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            bool endRace = false;
            while (endRace != true)
            {

                for (int i = 0; i < 4; i++)
                {
                    Application.DoEvents();
                    myPig[i].Run();

                    if (myPig[i].StartingLocation == "Top")
                    {
                        if ((myPig[i].myPB.Top + 89) > myPig[i].FinishLine)
                        {
                            myPig[i].Winner = true;
                            endRace = true;
                        }
                    }
                    else if (myPig[i].StartingLocation == "Right")
                    {
                        if ((myPig[i].myPB.Left) < myPig[i].FinishLine)
                        {
                            myPig[i].Winner = true;
                            endRace = true;
                        }
                    }
                    else if (myPig[i].StartingLocation == "Bottom")
                    {
                        if (myPig[i].myPB.Top < myPig[i].FinishLine)
                        {
                            myPig[i].Winner = true;
                            endRace = true;
                        }
                    }
                    else if (myPig[i].StartingLocation == "Left")
                    {
                        if ((myPig[i].myPB.Left + 89) > myPig[i].FinishLine)
                        {
                            myPig[i].Winner = true;
                            endRace = true;
                        }
                    }
                }
            }

            for (int i = 0; i < 4; i++)
            {
                if (myPig[i].Winner == true)
                {
                    myPig[i].myPB.BackgroundImage = Resource1.first;
                } 
            }
        }
    }
}

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
            myPig[0] = new Pig { Name = "Bacon", Length = 0, myPB = pb1, Direction = "Bottom" };
            myPig[0].myPB.BackgroundImage = Resource1.pig3;
            myPig[1] = new Pig { Name = "Pork", Length = 0, myPB = pb2, Direction = "Left" };
            myPig[1].myPB.BackgroundImage = Resource1.pig1;
            myPig[2] = new Pig { Name = "Ham", Length = 0, myPB = pb3, Direction = "Top" };
            myPig[2].myPB.BackgroundImage = Resource1.pig4;
            myPig[3] = new Pig { Name = "Ribs", Length = 0, myPB = pb4, Direction = "Right" };
            myPig[3].myPB.BackgroundImage = Resource1.pig2;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            var myrnd = new Random();
            bool endRace = false;
            while (endRace != true)
            {
                for (int i = 0; i < 4; i++)
                {
                    //myPig[i].Direction = SetPigsDirection(i);
                    
                }
                
            }
        }

        //private string SetPigsDirection(int Id)
        //{
        //    switch (Id)
        //    {
        //        case 0:
        //            return "Bottom";
        //        case 1:
        //            return "Left";
        //        case 2:
        //            return "Top";
        //        case 3:
        //            return "Right";
        //        default:
        //            return null;
        //    }
        //}
    }
}

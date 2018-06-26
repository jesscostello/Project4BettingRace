using Project4BettingRace.Business;
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
    public partial class FormBets : Form
    {
        Punter[] myPunter = new Punter[3];

        public FormBets()
        {
            InitializeComponent();

            SetUpPunters();
            SetMaxUDValues();
        }

        private void SetUpPunters()
        {
            for (int i = 0; i < 3; i++)
            {
                myPunter[i] = Factory.GetAPunter(i);
            }
        }

        public void SetMaxUDValues()
        {
            udMB.Maximum = (decimal)myPunter[0].Cash;
            udFB.Maximum = (decimal)myPunter[1].Cash;
            udMP.Maximum = (decimal)myPunter[2].Cash;
            udMB.Value = (decimal)myPunter[0].Cash;
            udFB.Value = (decimal)myPunter[1].Cash;
            udMP.Value = (decimal)myPunter[2].Cash;
        }
    }
}

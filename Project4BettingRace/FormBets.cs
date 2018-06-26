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
        Punter selectedPunter;
        string selectedPig;

        public FormBets()
        {
            InitializeComponent();

            SetUpPunters();
        }

        private void SetUpPunters()
        {
            for (int i = 0; i < 3; i++)
            {
                myPunter[i] = Factory.GetAPunter(i);
            }
        }

        private void cbxPunter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selection = cbxPunter.SelectedItem.ToString();
            int Id = SetComboBoxValue(selection);
            
            selectedPunter = myPunter[Id];

            SetMaxUDValues();
        }

        public void SetMaxUDValues()
        {
            udBet.Maximum = (decimal)selectedPunter.Cash;
            udBet.Value = (decimal)selectedPunter.Cash;

            lblCashLeft.Text = "I have $" + selectedPunter.Cash + " left to bet with.";
        }

        private int SetComboBoxValue(string selection)
        {
            switch (selection)
            {
                case "Mad Butcher":
                    return 0;
                case "Farmer Brown":
                    return 1;
                case "Mrs Piggy":
                    return 2;
                default: return 9;
            }
        }

        private void radButton_CheckedChanged(object sender, EventArgs e)
        {
            if (radBacon.Checked)
            {
                selectedPig = "Bacon";
            }
            if (radHam.Checked)
            {
                selectedPig = "Ham";
            }
            if (radPork.Checked)
            {
                selectedPig = "Pork";
            }
            if (radRibs.Checked)
            {
                selectedPig = "Ribs";
            }
        }
    }
}

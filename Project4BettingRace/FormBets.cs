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
        public int Id { get; set; }
        string selectedPig;

        public FormBets()
        {
            InitializeComponent();

            SetUpPunters();
            ShowBrokePlayers();
            LoadComboBox();
        }

        private void SetUpPunters()
        {
            for (int i = 0; i < 3; i++)
            {
                myPunter[i] = Factory.GetAPunter(i);
            }
        }

        private void LoadComboBox()
        {
            for (int i = 0; i < 3; i++)
            {
                if (myPunter[i].Broke != true)
                {
                    cbxPunter.Items.Add(myPunter[i].PunterName);
                }
                
            }
        }

        private void ShowBrokePlayers()
        {
            for (int i = 0; i < 3; i++)
            {
                if (myPunter[i].Cash <= 0)
                {
                    myPunter[i].Broke = true;
                    lblBroke.Text += "\n" + myPunter[i].PunterName + " is broke and can no longer bet.";
                }
            }
        }

        private void cbxPunter_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Id = cbxPunter.SelectedIndex;
            string selection = cbxPunter.SelectedItem.ToString();
            // set ID manually because indexes change once punters are removed from the combobox
            Id = SetComboBoxValue(selection);

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
            btnConfirm.Enabled = true;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            selectedPunter.Bet = (float)udBet.Value;
            selectedPunter.Pig = selectedPig;

            lblBet1.Text += "\n" + selectedPunter.PunterName + " is placing a $" + selectedPunter.Bet + " bet on " + selectedPunter.Pig;
            lblCashLeft.Text = string.Empty;
            udBet.Value = 0;
            btnConfirm.Enabled = false;
            cbxPunter.Items.Remove(cbxPunter.SelectedItem);
            // uncheck the selected radio button
            if (radBacon.Checked)
            {
                radBacon.Checked = false;
            }
            else if (radHam.Checked)
            {
                radHam.Checked = false;
            }
            else if (radPork.Checked)
            {
                radPork.Checked = false;
            }
            else if (radRibs.Checked)
            {
                radRibs.Checked = false;
            }

            if (cbxPunter.Items.Count == 0)
            {
                cbxPunter.Enabled = false;
                btnAllBets.Enabled = true;
            }
        }

        private void btnAllBets_Click(object sender, EventArgs e)
        {

        }
    }
}

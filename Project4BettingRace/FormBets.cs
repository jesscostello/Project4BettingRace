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
        Pig[] myPig = new Pig[4];
        Punter[] myPunter = new Punter[3];
        Punter selectedPunter;
        public int Id { get; set; }
        public string selectedPig { get; set; }
        public string winner { get; set; }


        public FormBets()
        {
            InitializeComponent();

            SetUpPigs();
            SetUpPunters();
            ShowBrokePlayers();
            LoadComboBox();
        }

        private void SetUpPigs()
        {
            // Give the pigs starting variables
            myPig[0] = new Pig { Name = "Bacon", myPB = pb1, StartingLocation = "Top", StartingPosition = 1, FinishLine = 248 };

            myPig[1] = new Pig { Name = "Pork", myPB = pb2, StartingLocation = "Right", StartingPosition = 877, FinishLine = 717 };

            myPig[2] = new Pig { Name = "Ham", myPB = pb3, StartingLocation = "Bottom", StartingPosition = 493, FinishLine = 337 };

            myPig[3] = new Pig { Name = "Ribs", myPB = pb4, StartingLocation = "Left", StartingPosition = 387, FinishLine = 628 };

            SetPigPictures();
        }

        private void SetPigPictures()
        {
            myPig[0].myPB.BackgroundImage = Resource1.pig3;
            myPig[1].myPB.BackgroundImage = Resource1.pig1;
            myPig[2].myPB.BackgroundImage = Resource1.pig4;
            myPig[3].myPB.BackgroundImage = Resource1.pig2;
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
            lblBroke.Text = string.Empty;
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
                            break;
                        }
                    }
                    else if (myPig[i].StartingLocation == "Right")
                    {
                        if ((myPig[i].myPB.Left) < myPig[i].FinishLine)
                        {
                            myPig[i].Winner = true;
                            endRace = true;
                            break;
                        }
                    }
                    else if (myPig[i].StartingLocation == "Bottom")
                    {
                        if (myPig[i].myPB.Top < myPig[i].FinishLine)
                        {
                            myPig[i].Winner = true;
                            endRace = true;
                            break;
                        }
                    }
                    else if (myPig[i].StartingLocation == "Left")
                    {
                        if ((myPig[i].myPB.Left + 89) > myPig[i].FinishLine)
                        {
                            myPig[i].Winner = true;
                            endRace = true;
                            break;
                        }
                    }
                }
            }

            for (int i = 0; i < 4; i++)
            {
                if (myPig[i].Winner == true)
                {
                    myPig[i].myPB.BackgroundImage = Resource1.first;
                    winner = myPig[i].Name;
                    EndOfRace();
                }
            }
        }

        private void EndOfRace()
        {
            string results = winner + " won the race.";
            
            for (int i = 0; i < 3; i++)
            {
                if (myPunter[i].Cash >= 1)
                {
                    if (myPunter[i].Pig == winner)
                    {
                        // add om the amount that they bet
                        myPunter[i].Cash += myPunter[i].Bet;
                        results += "\n" + myPunter[i].PunterName + " won their bet and now has $" + myPunter[i].Cash;
                    }
                    else
                    {
                        // take away the amount that they bet and lost
                        myPunter[i].Cash -= myPunter[i].Bet;
                        if (myPunter[i].Cash <= 0)
                        {
                            results += "\n" + myPunter[i].PunterName + " lost their bet so is now BUSTED and can no longer make any more bets";
                            myPunter[i].Broke = true;
                        }
                        else
                        {
                            results += "\n" + myPunter[i].PunterName + " lost their bet and now has $" + myPunter[i].Cash;
                        }
                    }
                }
                
            }
            MessageBox.Show(results);
            LoadComboBox();
            if (cbxPunter.Items.Count == 0)
            {
                MessageBox.Show("Uh oh! Everyone lost their money, game over! \n\nStart again");
                for (int i = 0; i < 3; i++)
                {
                    myPunter[i].Cash = 50;
                }
            }
            RefreshForm();
            
        }

        private void RefreshForm()
        {
            cbxPunter.Enabled = true;
            lblBroke.Text = string.Empty;
            ShowBrokePlayers();
            lblCashLeft.Text = string.Empty;
            udBet.Value = 0;
            lblBet1.Text = string.Empty;
            myPig[0].myPB.Top = myPig[0].StartingPosition;
            myPig[1].myPB.Left = myPig[1].StartingPosition;
            myPig[2].myPB.Top = myPig[2].StartingPosition;
            myPig[3].myPB.Left = myPig[3].StartingPosition;
            SetUpPigs();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardsAgainstSoftwareDevelopment
{
    public partial class CASD : Form
    {
        public CASD()
        {
            InitializeComponent();
        }

        public void ResetButtons()
        {
            card1.Visible = true;
            card2.Visible = true;
            card3.Visible = true;
            card4.Visible = true;
            card5.Visible = true;
            card6.Visible = true;

            card1.Enabled = true;
            card2.Enabled = true;
            card3.Enabled = true;
            card4.Enabled = true;
            card5.Enabled = true;
            card6.Enabled = true;
        }

        private void card1_Click(object sender, EventArgs e)
        {
            sentence.Text += card1.Text;
            card1.Enabled = false;
            card2.Visible = false;
            card3.Visible = false;
            card4.Visible = false;
            card5.Visible = false;
            card6.Visible = false;
        }

        private void card2_Click(object sender, EventArgs e)
        {
            sentence.Text += card2.Text;
            card1.Visible = false;
            card2.Enabled = false;
            card3.Visible = false;
            card4.Visible = false;
            card5.Visible = false;
            card6.Visible = false;
        }

        private void card3_Click(object sender, EventArgs e)
        {
            sentence.Text += card3.Text;
            card1.Visible = false;
            card2.Visible = false;
            card3.Enabled = false;
            card4.Visible = false;
            card5.Visible = false;
            card6.Visible = false;
        }

        private void card4_Click(object sender, EventArgs e)
        {
            sentence.Text += card4.Text;
            card1.Visible = false;
            card2.Visible = false;
            card3.Visible = false;
            card4.Enabled = false;
            card5.Visible = false;
            card6.Visible = false;
        }

        private void card5_Click(object sender, EventArgs e)
        {
            sentence.Text += card5.Text;
            card1.Visible = false;
            card2.Visible = false;
            card3.Visible = false;
            card4.Visible = false;
            card5.Enabled = false;
            card6.Visible = false;
        }

        private void card6_Click(object sender, EventArgs e)
        {
            sentence.Text += card6.Text;
            card1.Visible = false;
            card2.Visible = false;
            card3.Visible = false;
            card4.Visible = false;
            card5.Visible = false;
            card6.Enabled = false;
        }

        private void sentence_Click(object sender, EventArgs e)
        {
            var randomList = new List<string> { };

            int amount = randomList.Count;

            randomList.Add("My program is not working! ");
            randomList.Add("What am I supposed to do with this error? ");

            sentence.Text = "My program is not working! ";
        }
    }
}

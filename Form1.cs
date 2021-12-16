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

        private void card1_Click(object sender, EventArgs e)
        {
            sentence.Text += card1.Text;
        }

        private void card2_Click(object sender, EventArgs e)
        {
            sentence.Text += card2.Text;
        }

        private void card3_Click(object sender, EventArgs e)
        {
            sentence.Text += card3.Text;
        }

        private void card4_Click(object sender, EventArgs e)
        {
            sentence.Text += card4.Text;
        }

        private void card5_Click(object sender, EventArgs e)
        {
            sentence.Text += card5.Text;
        }

        private void card6_Click(object sender, EventArgs e)
        {
            sentence.Text += card6.Text;
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

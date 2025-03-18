using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceRoller
{
    public partial class CrapsTableForm : Form
    {
        private CrapsRoller CrapsRoller;
        public CrapsTableForm()
        {
            InitializeComponent();
            CrapsRoller = new CrapsRoller();
        }

        private void RollButton_Click(object sender, EventArgs e)
        {
            ResultsLabel.Text = CrapsRoller.RollDice().ToString(); 
        }
    }
}

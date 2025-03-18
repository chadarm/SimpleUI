namespace DiceRoller
{
    public partial class DiceRollerForm : Form
    {
        private DiceRoller DiceRoller;
        
        public DiceRollerForm()
        {
            InitializeComponent();
            int numberOfRolls = (int)NumberOfDiceUpDown.Value;
            int maxDieValue = (int)MaxDiceValueUpDown.Value;
            DiceRoller = new DiceRoller(maxDieValue,numberOfRolls);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResultsLabel.Text = DiceRoller.RollDice().ToString();
        }

        private void MaxDiceValueUpDown_ValueChanged(object sender, EventArgs e)
        {
            DiceRoller.MaxDieValue = (int)(sender as NumericUpDown).Value;
        }

        private void NumberOfDiceUpDown_ValueChanged(object sender, EventArgs e)
        {
            DiceRoller.NumberOfRolls = (int)(sender as NumericUpDown).Value;
        }
    }
}

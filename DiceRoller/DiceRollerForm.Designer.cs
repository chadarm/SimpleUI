namespace DiceRoller
{
    partial class DiceRollerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            NumberOfDiceUpDown = new NumericUpDown();
            MaxDiceValueUpDown = new NumericUpDown();
            RollButton = new Button();
            groupBox1 = new GroupBox();
            label3 = new Label();
            ResultsLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)NumberOfDiceUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MaxDiceValueUpDown).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 47);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 0;
            label1.Text = "Number of Dice";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 98);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 1;
            label2.Text = "Max Dice Value";
            // 
            // NumberOfDiceUpDown
            // 
            NumberOfDiceUpDown.Location = new Point(157, 20);
            NumberOfDiceUpDown.Name = "NumberOfDiceUpDown";
            NumberOfDiceUpDown.Size = new Size(62, 23);
            NumberOfDiceUpDown.TabIndex = 2;
            NumberOfDiceUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            NumberOfDiceUpDown.ValueChanged += NumberOfDiceUpDown_ValueChanged;
            // 
            // MaxDiceValueUpDown
            // 
            MaxDiceValueUpDown.Location = new Point(157, 71);
            MaxDiceValueUpDown.Name = "MaxDiceValueUpDown";
            MaxDiceValueUpDown.Size = new Size(62, 23);
            MaxDiceValueUpDown.TabIndex = 3;
            MaxDiceValueUpDown.Value = new decimal(new int[] { 6, 0, 0, 0 });
            MaxDiceValueUpDown.ValueChanged += MaxDiceValueUpDown_ValueChanged;
            // 
            // RollButton
            // 
            RollButton.Location = new Point(96, 146);
            RollButton.Name = "RollButton";
            RollButton.Size = new Size(75, 23);
            RollButton.TabIndex = 4;
            RollButton.Text = "Roll!";
            RollButton.UseVisualStyleBackColor = true;
            RollButton.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(NumberOfDiceUpDown);
            groupBox1.Controls.Add(MaxDiceValueUpDown);
            groupBox1.Location = new Point(26, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(236, 153);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(63, 207);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 6;
            label3.Text = "You Rolled:";
            // 
            // ResultsLabel
            // 
            ResultsLabel.AutoSize = true;
            ResultsLabel.Location = new Point(133, 207);
            ResultsLabel.Name = "ResultsLabel";
            ResultsLabel.Size = new Size(0, 15);
            ResultsLabel.TabIndex = 7;
            // 
            // DiceRollerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(289, 264);
            Controls.Add(ResultsLabel);
            Controls.Add(label3);
            Controls.Add(RollButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "DiceRollerForm";
            Text = "Dice Roller";
            ((System.ComponentModel.ISupportInitialize)NumberOfDiceUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)MaxDiceValueUpDown).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private NumericUpDown NumberOfDiceUpDown;
        private NumericUpDown MaxDiceValueUpDown;
        private Button RollButton;
        private GroupBox groupBox1;
        private Label label3;
        private Label ResultsLabel;
    }
}

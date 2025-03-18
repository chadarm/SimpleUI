namespace DiceRoller
{
    partial class CrapsTableForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrapsTableForm));
            CrapsTable = new Panel();
            RollButton = new Button();
            label1 = new Label();
            ResultsLabel = new Label();
            SuspendLayout();
            // 
            // CrapsTable
            // 
            CrapsTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CrapsTable.BackgroundImage = (Image)resources.GetObject("CrapsTable.BackgroundImage");
            CrapsTable.BackgroundImageLayout = ImageLayout.Stretch;
            CrapsTable.Location = new Point(48, 12);
            CrapsTable.Name = "CrapsTable";
            CrapsTable.Size = new Size(791, 399);
            CrapsTable.TabIndex = 0;
            // 
            // RollButton
            // 
            RollButton.Anchor = AnchorStyles.Bottom;
            RollButton.Location = new Point(282, 427);
            RollButton.Name = "RollButton";
            RollButton.Size = new Size(75, 23);
            RollButton.TabIndex = 1;
            RollButton.Text = "Roll!";
            RollButton.UseVisualStyleBackColor = true;
            RollButton.Click += RollButton_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Location = new Point(429, 431);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 2;
            label1.Text = "Result: ";
            // 
            // ResultsLabel
            // 
            ResultsLabel.Anchor = AnchorStyles.Bottom;
            ResultsLabel.AutoSize = true;
            ResultsLabel.Location = new Point(480, 431);
            ResultsLabel.Name = "ResultsLabel";
            ResultsLabel.Size = new Size(31, 15);
            ResultsLabel.TabIndex = 3;
            ResultsLabel.Text = "0000";
            // 
            // CrapsTableForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(919, 556);
            Controls.Add(ResultsLabel);
            Controls.Add(label1);
            Controls.Add(RollButton);
            Controls.Add(CrapsTable);
            Name = "CrapsTableForm";
            Text = "CrapsTableForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel CrapsTable;
        private Button RollButton;
        private Label label1;
        private Label ResultsLabel;
    }
}
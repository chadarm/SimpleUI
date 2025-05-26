namespace AmortizationCalculator
{
    partial class CalculatorForm
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
            label3 = new Label();
            label4 = new Label();
            LoanAmtTextBox = new TextBox();
            InterestRateTextBox = new TextBox();
            PaymentFreqTextBox = new TextBox();
            NumPaymentsTextBox = new TextBox();
            button1 = new Button();
            PaymentGrid = new DataGridView();
            panel1 = new Panel();
            PaymentIndexColumn = new DataGridViewTextBoxColumn();
            TotalPaidColumn = new DataGridViewTextBoxColumn();
            PrincipalAmtPaid = new DataGridViewTextBoxColumn();
            InterestPaidColumn = new DataGridViewTextBoxColumn();
            RemaningBalanceColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)PaymentGrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(81, 61);
            label1.Name = "label1";
            label1.Size = new Size(129, 25);
            label1.TabIndex = 0;
            label1.Text = "Loan Amount:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(81, 111);
            label2.Name = "label2";
            label2.Size = new Size(180, 25);
            label2.TabIndex = 1;
            label2.Text = "Payment Frequency:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Nirmala UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(416, 61);
            label3.Name = "label3";
            label3.Size = new Size(121, 25);
            label3.TabIndex = 2;
            label3.Text = "Interest Rate:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Nirmala UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(416, 111);
            label4.Name = "label4";
            label4.Size = new Size(134, 25);
            label4.TabIndex = 3;
            label4.Text = "# of Payments:";
            // 
            // LoanAmtTextBox
            // 
            LoanAmtTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            LoanAmtTextBox.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LoanAmtTextBox.Location = new Point(251, 61);
            LoanAmtTextBox.Name = "LoanAmtTextBox";
            LoanAmtTextBox.Size = new Size(143, 29);
            LoanAmtTextBox.TabIndex = 4;
            // 
            // InterestRateTextBox
            // 
            InterestRateTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            InterestRateTextBox.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            InterestRateTextBox.Location = new Point(554, 61);
            InterestRateTextBox.Name = "InterestRateTextBox";
            InterestRateTextBox.Size = new Size(111, 29);
            InterestRateTextBox.TabIndex = 5;
            // 
            // PaymentFreqTextBox
            // 
            PaymentFreqTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PaymentFreqTextBox.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PaymentFreqTextBox.Location = new Point(283, 111);
            PaymentFreqTextBox.Name = "PaymentFreqTextBox";
            PaymentFreqTextBox.Size = new Size(111, 29);
            PaymentFreqTextBox.TabIndex = 6;
            // 
            // NumPaymentsTextBox
            // 
            NumPaymentsTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            NumPaymentsTextBox.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NumPaymentsTextBox.Location = new Point(554, 111);
            NumPaymentsTextBox.Name = "NumPaymentsTextBox";
            NumPaymentsTextBox.Size = new Size(111, 29);
            NumPaymentsTextBox.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(353, 203);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // PaymentGrid
            // 
            PaymentGrid.AllowUserToAddRows = false;
            PaymentGrid.AllowUserToDeleteRows = false;
            PaymentGrid.AllowUserToOrderColumns = true;
            PaymentGrid.AllowUserToResizeRows = false;
            PaymentGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            PaymentGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PaymentGrid.Columns.AddRange(new DataGridViewColumn[] { PaymentIndexColumn, TotalPaidColumn, PrincipalAmtPaid, InterestPaidColumn, RemaningBalanceColumn });
            PaymentGrid.Dock = DockStyle.Bottom;
            PaymentGrid.Location = new Point(0, 231);
            PaymentGrid.Margin = new Padding(8);
            PaymentGrid.Name = "PaymentGrid";
            PaymentGrid.ReadOnly = true;
            PaymentGrid.Size = new Size(766, 259);
            PaymentGrid.TabIndex = 9;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(766, 197);
            panel1.TabIndex = 10;
            // 
            // PaymentIndexColumn
            // 
            PaymentIndexColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            PaymentIndexColumn.HeaderText = "Payment #";
            PaymentIndexColumn.Name = "PaymentIndexColumn";
            PaymentIndexColumn.ReadOnly = true;
            PaymentIndexColumn.Width = 89;
            // 
            // TotalPaidColumn
            // 
            TotalPaidColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TotalPaidColumn.HeaderText = "Total Payment";
            TotalPaidColumn.Name = "TotalPaidColumn";
            TotalPaidColumn.ReadOnly = true;
            // 
            // PrincipalAmtPaid
            // 
            PrincipalAmtPaid.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PrincipalAmtPaid.HeaderText = "Principal Payment";
            PrincipalAmtPaid.Name = "PrincipalAmtPaid";
            PrincipalAmtPaid.ReadOnly = true;
            // 
            // InterestPaidColumn
            // 
            InterestPaidColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            InterestPaidColumn.HeaderText = "Interest Payment";
            InterestPaidColumn.Name = "InterestPaidColumn";
            InterestPaidColumn.ReadOnly = true;
            // 
            // RemaningBalanceColumn
            // 
            RemaningBalanceColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            RemaningBalanceColumn.HeaderText = "RemainingBalance";
            RemaningBalanceColumn.Name = "RemaningBalanceColumn";
            RemaningBalanceColumn.ReadOnly = true;
            // 
            // CalculatorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(766, 490);
            Controls.Add(PaymentGrid);
            Controls.Add(button1);
            Controls.Add(NumPaymentsTextBox);
            Controls.Add(PaymentFreqTextBox);
            Controls.Add(InterestRateTextBox);
            Controls.Add(LoanAmtTextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "CalculatorForm";
            Text = "Amortization Calculator";
            ((System.ComponentModel.ISupportInitialize)PaymentGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox LoanAmtTextBox;
        private TextBox InterestRateTextBox;
        private TextBox PaymentFreqTextBox;
        private TextBox NumPaymentsTextBox;
        private Button button1;
        private DataGridView PaymentGrid;
        private Panel panel1;
        private DataGridViewTextBoxColumn PaymentIndexColumn;
        private DataGridViewTextBoxColumn TotalPaidColumn;
        private DataGridViewTextBoxColumn PrincipalAmtPaid;
        private DataGridViewTextBoxColumn InterestPaidColumn;
        private DataGridViewTextBoxColumn RemaningBalanceColumn;
    }
}

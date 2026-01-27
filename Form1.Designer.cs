namespace SimpleSCCalculator
{
    partial class Form1
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
            numberOfPlayersLbl = new Label();
            entryCostLbl = new Label();
            MainTlp = new TableLayoutPanel();
            everybodyGetsLbl = new Label();
            totalPointsLbl = new Label();
            totalStoreCreditLbl = new Label();
            storeCreditReservedLbl = new Label();
            playerPointsLbl = new Label();
            numberOfPlayersNum = new NumericUpDown();
            entryCostNum = new NumericUpDown();
            everybodyGetsNum = new NumericUpDown();
            totalPointsNum = new NumericUpDown();
            totalStoreCreditTbx = new RichTextBox();
            storeCreditReservedTbx = new RichTextBox();
            playerPointsNum = new NumericUpDown();
            MainTlp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numberOfPlayersNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)entryCostNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)everybodyGetsNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)totalPointsNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playerPointsNum).BeginInit();
            SuspendLayout();
            // 
            // numberOfPlayersLbl
            // 
            numberOfPlayersLbl.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            numberOfPlayersLbl.AutoSize = true;
            numberOfPlayersLbl.Location = new Point(21, 0);
            numberOfPlayersLbl.Name = "numberOfPlayersLbl";
            numberOfPlayersLbl.Size = new Size(178, 28);
            numberOfPlayersLbl.TabIndex = 0;
            numberOfPlayersLbl.Text = "Number of players:";
            // 
            // entryCostLbl
            // 
            entryCostLbl.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            entryCostLbl.AutoSize = true;
            entryCostLbl.Location = new Point(97, 40);
            entryCostLbl.Name = "entryCostLbl";
            entryCostLbl.Size = new Size(102, 28);
            entryCostLbl.TabIndex = 1;
            entryCostLbl.Text = "Entry cost:";
            // 
            // MainTlp
            // 
            MainTlp.ColumnCount = 2;
            MainTlp.ColumnStyles.Add(new ColumnStyle());
            MainTlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            MainTlp.Controls.Add(playerPointsNum, 1, 6);
            MainTlp.Controls.Add(storeCreditReservedTbx, 1, 5);
            MainTlp.Controls.Add(totalPointsNum, 1, 3);
            MainTlp.Controls.Add(everybodyGetsNum, 1, 2);
            MainTlp.Controls.Add(numberOfPlayersLbl, 0, 0);
            MainTlp.Controls.Add(entryCostLbl, 0, 1);
            MainTlp.Controls.Add(everybodyGetsLbl, 0, 2);
            MainTlp.Controls.Add(totalPointsLbl, 0, 3);
            MainTlp.Controls.Add(totalStoreCreditLbl, 0, 4);
            MainTlp.Controls.Add(storeCreditReservedLbl, 0, 5);
            MainTlp.Controls.Add(playerPointsLbl, 0, 6);
            MainTlp.Controls.Add(numberOfPlayersNum, 1, 0);
            MainTlp.Controls.Add(entryCostNum, 1, 1);
            MainTlp.Controls.Add(totalStoreCreditTbx, 1, 4);
            MainTlp.Location = new Point(-1, 1);
            MainTlp.Name = "MainTlp";
            MainTlp.RowCount = 7;
            MainTlp.RowStyles.Add(new RowStyle());
            MainTlp.RowStyles.Add(new RowStyle());
            MainTlp.RowStyles.Add(new RowStyle());
            MainTlp.RowStyles.Add(new RowStyle());
            MainTlp.RowStyles.Add(new RowStyle());
            MainTlp.RowStyles.Add(new RowStyle());
            MainTlp.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            MainTlp.Size = new Size(1028, 691);
            MainTlp.TabIndex = 2;
            // 
            // everybodyGetsLbl
            // 
            everybodyGetsLbl.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            everybodyGetsLbl.AutoSize = true;
            everybodyGetsLbl.Location = new Point(48, 80);
            everybodyGetsLbl.Name = "everybodyGetsLbl";
            everybodyGetsLbl.Size = new Size(151, 28);
            everybodyGetsLbl.TabIndex = 2;
            everybodyGetsLbl.Text = "Everybody gets:";
            // 
            // totalPointsLbl
            // 
            totalPointsLbl.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            totalPointsLbl.AutoSize = true;
            totalPointsLbl.Location = new Point(81, 120);
            totalPointsLbl.Name = "totalPointsLbl";
            totalPointsLbl.Size = new Size(118, 28);
            totalPointsLbl.TabIndex = 3;
            totalPointsLbl.Text = "Total points:";
            // 
            // totalStoreCreditLbl
            // 
            totalStoreCreditLbl.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            totalStoreCreditLbl.AutoSize = true;
            totalStoreCreditLbl.Location = new Point(37, 160);
            totalStoreCreditLbl.Name = "totalStoreCreditLbl";
            totalStoreCreditLbl.Size = new Size(162, 28);
            totalStoreCreditLbl.TabIndex = 4;
            totalStoreCreditLbl.Text = "Total store credit:";
            // 
            // storeCreditReservedLbl
            // 
            storeCreditReservedLbl.AutoSize = true;
            storeCreditReservedLbl.Location = new Point(3, 200);
            storeCreditReservedLbl.Name = "storeCreditReservedLbl";
            storeCreditReservedLbl.Size = new Size(196, 28);
            storeCreditReservedLbl.TabIndex = 5;
            storeCreditReservedLbl.Text = "Store credit reserved:";
            // 
            // playerPointsLbl
            // 
            playerPointsLbl.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            playerPointsLbl.AutoSize = true;
            playerPointsLbl.Location = new Point(70, 240);
            playerPointsLbl.Name = "playerPointsLbl";
            playerPointsLbl.Size = new Size(129, 28);
            playerPointsLbl.TabIndex = 6;
            playerPointsLbl.Text = "Player points:";
            // 
            // numberOfPlayersNum
            // 
            numberOfPlayersNum.Location = new Point(205, 3);
            numberOfPlayersNum.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            numberOfPlayersNum.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            numberOfPlayersNum.Name = "numberOfPlayersNum";
            numberOfPlayersNum.Size = new Size(68, 34);
            numberOfPlayersNum.TabIndex = 7;
            numberOfPlayersNum.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // entryCostNum
            // 
            entryCostNum.Location = new Point(205, 43);
            entryCostNum.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
            entryCostNum.Name = "entryCostNum";
            entryCostNum.Size = new Size(68, 34);
            entryCostNum.TabIndex = 8;
            entryCostNum.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // everybodyGetsNum
            // 
            everybodyGetsNum.Location = new Point(205, 83);
            everybodyGetsNum.Name = "everybodyGetsNum";
            everybodyGetsNum.Size = new Size(68, 34);
            everybodyGetsNum.TabIndex = 9;
            everybodyGetsNum.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // totalPointsNum
            // 
            totalPointsNum.Location = new Point(205, 123);
            totalPointsNum.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            totalPointsNum.Name = "totalPointsNum";
            totalPointsNum.Size = new Size(68, 34);
            totalPointsNum.TabIndex = 10;
            // 
            // totalStoreCreditTbx
            // 
            totalStoreCreditTbx.BackColor = SystemColors.InactiveCaption;
            totalStoreCreditTbx.Enabled = false;
            totalStoreCreditTbx.Location = new Point(205, 163);
            totalStoreCreditTbx.Name = "totalStoreCreditTbx";
            totalStoreCreditTbx.Size = new Size(68, 34);
            totalStoreCreditTbx.TabIndex = 11;
            totalStoreCreditTbx.Text = "20";
            // 
            // storeCreditReservedTbx
            // 
            storeCreditReservedTbx.BackColor = SystemColors.InactiveCaption;
            storeCreditReservedTbx.Enabled = false;
            storeCreditReservedTbx.Location = new Point(205, 203);
            storeCreditReservedTbx.Name = "storeCreditReservedTbx";
            storeCreditReservedTbx.Size = new Size(68, 34);
            storeCreditReservedTbx.TabIndex = 12;
            storeCreditReservedTbx.Text = "10";
            // 
            // playerPointsNum
            // 
            playerPointsNum.Location = new Point(205, 243);
            playerPointsNum.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            playerPointsNum.Name = "playerPointsNum";
            playerPointsNum.Size = new Size(68, 34);
            playerPointsNum.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(1028, 701);
            Controls.Add(MainTlp);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Simplified Store Credit Calculator";
            MainTlp.ResumeLayout(false);
            MainTlp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numberOfPlayersNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)entryCostNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)everybodyGetsNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)totalPointsNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)playerPointsNum).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label numberOfPlayersLbl;
        private Label entryCostLbl;
        private TableLayoutPanel MainTlp;
        private Label everybodyGetsLbl;
        private Label totalPointsLbl;
        private Label totalStoreCreditLbl;
        private Label storeCreditReservedLbl;
        private Label playerPointsLbl;
        private NumericUpDown numberOfPlayersNum;
        private NumericUpDown totalPointsNum;
        private NumericUpDown everybodyGetsNum;
        private NumericUpDown entryCostNum;
        private RichTextBox totalStoreCreditTbx;
        private NumericUpDown playerPointsNum;
        private RichTextBox storeCreditReservedTbx;
    }
}

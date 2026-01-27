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
            storeCreditReservedTbx = new RichTextBox();
            totalPointsNum = new NumericUpDown();
            everybodyGetsNum = new NumericUpDown();
            everybodyGetsLbl = new Label();
            totalPointsLbl = new Label();
            totalStoreCreditLbl = new Label();
            storeCreditReservedLbl = new Label();
            numberOfPlayersNum = new NumericUpDown();
            entryCostNum = new NumericUpDown();
            totalStoreCreditTbx = new RichTextBox();
            tournamentSettingsLbl = new Label();
            storeCreditPerPointLbl = new Label();
            storeCreditPerPointTbx = new RichTextBox();
            playerPointsLbl = new Label();
            playerPointsNum = new NumericUpDown();
            playerSettingsLbl = new Label();
            storeCreditReceivedLbl = new Label();
            storeCreditReceivedTbx = new RichTextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            addToListBtn = new Button();
            clearListBtn = new Button();
            prizingLbx = new ListBox();
            MainTlp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)totalPointsNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)everybodyGetsNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numberOfPlayersNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)entryCostNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playerPointsNum).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // numberOfPlayersLbl
            // 
            numberOfPlayersLbl.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            numberOfPlayersLbl.AutoSize = true;
            numberOfPlayersLbl.Location = new Point(31, 38);
            numberOfPlayersLbl.Name = "numberOfPlayersLbl";
            numberOfPlayersLbl.Size = new Size(178, 28);
            numberOfPlayersLbl.TabIndex = 0;
            numberOfPlayersLbl.Text = "Number of players:";
            // 
            // entryCostLbl
            // 
            entryCostLbl.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            entryCostLbl.AutoSize = true;
            entryCostLbl.Location = new Point(107, 81);
            entryCostLbl.Name = "entryCostLbl";
            entryCostLbl.Size = new Size(102, 28);
            entryCostLbl.TabIndex = 1;
            entryCostLbl.Text = "Entry cost:";
            // 
            // MainTlp
            // 
            MainTlp.CellBorderStyle = TableLayoutPanelCellBorderStyle.OutsetPartial;
            MainTlp.ColumnCount = 2;
            MainTlp.ColumnStyles.Add(new ColumnStyle());
            MainTlp.ColumnStyles.Add(new ColumnStyle());
            MainTlp.Controls.Add(storeCreditReservedTbx, 1, 6);
            MainTlp.Controls.Add(totalPointsNum, 1, 4);
            MainTlp.Controls.Add(everybodyGetsNum, 1, 3);
            MainTlp.Controls.Add(numberOfPlayersLbl, 0, 1);
            MainTlp.Controls.Add(entryCostLbl, 0, 2);
            MainTlp.Controls.Add(everybodyGetsLbl, 0, 3);
            MainTlp.Controls.Add(totalPointsLbl, 0, 4);
            MainTlp.Controls.Add(totalStoreCreditLbl, 0, 5);
            MainTlp.Controls.Add(storeCreditReservedLbl, 0, 6);
            MainTlp.Controls.Add(numberOfPlayersNum, 1, 1);
            MainTlp.Controls.Add(entryCostNum, 1, 2);
            MainTlp.Controls.Add(totalStoreCreditTbx, 1, 5);
            MainTlp.Controls.Add(tournamentSettingsLbl, 0, 0);
            MainTlp.Controls.Add(storeCreditPerPointLbl, 0, 7);
            MainTlp.Controls.Add(storeCreditPerPointTbx, 1, 7);
            MainTlp.Location = new Point(12, 12);
            MainTlp.Name = "MainTlp";
            MainTlp.RowCount = 8;
            MainTlp.RowStyles.Add(new RowStyle());
            MainTlp.RowStyles.Add(new RowStyle());
            MainTlp.RowStyles.Add(new RowStyle());
            MainTlp.RowStyles.Add(new RowStyle());
            MainTlp.RowStyles.Add(new RowStyle());
            MainTlp.RowStyles.Add(new RowStyle());
            MainTlp.RowStyles.Add(new RowStyle());
            MainTlp.RowStyles.Add(new RowStyle());
            MainTlp.Size = new Size(338, 338);
            MainTlp.TabIndex = 2;
            // 
            // storeCreditReservedTbx
            // 
            storeCreditReservedTbx.BackColor = SystemColors.InactiveCaption;
            storeCreditReservedTbx.BorderStyle = BorderStyle.FixedSingle;
            storeCreditReservedTbx.Enabled = false;
            storeCreditReservedTbx.Location = new Point(218, 256);
            storeCreditReservedTbx.Name = "storeCreditReservedTbx";
            storeCreditReservedTbx.Size = new Size(68, 34);
            storeCreditReservedTbx.TabIndex = 12;
            storeCreditReservedTbx.Text = "";
            // 
            // totalPointsNum
            // 
            totalPointsNum.Location = new Point(218, 170);
            totalPointsNum.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            totalPointsNum.Name = "totalPointsNum";
            totalPointsNum.Size = new Size(68, 34);
            totalPointsNum.TabIndex = 10;
            totalPointsNum.Value = new decimal(new int[] { 3, 0, 0, 0 });
            totalPointsNum.ValueChanged += totalPointsNum_ValueChanged;
            // 
            // everybodyGetsNum
            // 
            everybodyGetsNum.Location = new Point(218, 127);
            everybodyGetsNum.Name = "everybodyGetsNum";
            everybodyGetsNum.Size = new Size(68, 34);
            everybodyGetsNum.TabIndex = 9;
            everybodyGetsNum.Value = new decimal(new int[] { 5, 0, 0, 0 });
            everybodyGetsNum.ValueChanged += everybodyGetsNum_ValueChanged;
            // 
            // everybodyGetsLbl
            // 
            everybodyGetsLbl.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            everybodyGetsLbl.AutoSize = true;
            everybodyGetsLbl.Location = new Point(58, 124);
            everybodyGetsLbl.Name = "everybodyGetsLbl";
            everybodyGetsLbl.Size = new Size(151, 28);
            everybodyGetsLbl.TabIndex = 2;
            everybodyGetsLbl.Text = "Everybody gets:";
            // 
            // totalPointsLbl
            // 
            totalPointsLbl.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            totalPointsLbl.AutoSize = true;
            totalPointsLbl.Location = new Point(91, 167);
            totalPointsLbl.Name = "totalPointsLbl";
            totalPointsLbl.Size = new Size(118, 28);
            totalPointsLbl.TabIndex = 3;
            totalPointsLbl.Text = "Total points:";
            // 
            // totalStoreCreditLbl
            // 
            totalStoreCreditLbl.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            totalStoreCreditLbl.AutoSize = true;
            totalStoreCreditLbl.Location = new Point(47, 210);
            totalStoreCreditLbl.Name = "totalStoreCreditLbl";
            totalStoreCreditLbl.Size = new Size(162, 28);
            totalStoreCreditLbl.TabIndex = 4;
            totalStoreCreditLbl.Text = "Total store credit:";
            // 
            // storeCreditReservedLbl
            // 
            storeCreditReservedLbl.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            storeCreditReservedLbl.AutoSize = true;
            storeCreditReservedLbl.Location = new Point(13, 253);
            storeCreditReservedLbl.Name = "storeCreditReservedLbl";
            storeCreditReservedLbl.Size = new Size(196, 28);
            storeCreditReservedLbl.TabIndex = 5;
            storeCreditReservedLbl.Text = "Store credit reserved:";
            // 
            // numberOfPlayersNum
            // 
            numberOfPlayersNum.Location = new Point(218, 41);
            numberOfPlayersNum.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            numberOfPlayersNum.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            numberOfPlayersNum.Name = "numberOfPlayersNum";
            numberOfPlayersNum.Size = new Size(68, 34);
            numberOfPlayersNum.TabIndex = 7;
            numberOfPlayersNum.Value = new decimal(new int[] { 2, 0, 0, 0 });
            numberOfPlayersNum.ValueChanged += numberOfPlayersNum_ValueChanged;
            // 
            // entryCostNum
            // 
            entryCostNum.Location = new Point(218, 84);
            entryCostNum.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
            entryCostNum.Name = "entryCostNum";
            entryCostNum.Size = new Size(68, 34);
            entryCostNum.TabIndex = 8;
            entryCostNum.Value = new decimal(new int[] { 10, 0, 0, 0 });
            entryCostNum.ValueChanged += entryCostNum_ValueChanged;
            // 
            // totalStoreCreditTbx
            // 
            totalStoreCreditTbx.BackColor = SystemColors.InactiveCaption;
            totalStoreCreditTbx.BorderStyle = BorderStyle.FixedSingle;
            totalStoreCreditTbx.Enabled = false;
            totalStoreCreditTbx.Location = new Point(218, 213);
            totalStoreCreditTbx.Name = "totalStoreCreditTbx";
            totalStoreCreditTbx.Size = new Size(68, 34);
            totalStoreCreditTbx.TabIndex = 11;
            totalStoreCreditTbx.Text = "";
            // 
            // tournamentSettingsLbl
            // 
            tournamentSettingsLbl.AutoSize = true;
            MainTlp.SetColumnSpan(tournamentSettingsLbl, 2);
            tournamentSettingsLbl.Font = new Font("Lucida Sans", 16.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            tournamentSettingsLbl.Location = new Point(6, 3);
            tournamentSettingsLbl.Name = "tournamentSettingsLbl";
            tournamentSettingsLbl.Size = new Size(329, 32);
            tournamentSettingsLbl.TabIndex = 14;
            tournamentSettingsLbl.Text = "Tournament Settings";
            tournamentSettingsLbl.TextAlign = ContentAlignment.TopCenter;
            // 
            // storeCreditPerPointLbl
            // 
            storeCreditPerPointLbl.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            storeCreditPerPointLbl.AutoSize = true;
            storeCreditPerPointLbl.Location = new Point(6, 296);
            storeCreditPerPointLbl.Name = "storeCreditPerPointLbl";
            storeCreditPerPointLbl.Size = new Size(203, 28);
            storeCreditPerPointLbl.TabIndex = 16;
            storeCreditPerPointLbl.Text = "Store credit per point:";
            // 
            // storeCreditPerPointTbx
            // 
            storeCreditPerPointTbx.BackColor = SystemColors.InactiveCaption;
            storeCreditPerPointTbx.BorderStyle = BorderStyle.FixedSingle;
            storeCreditPerPointTbx.Enabled = false;
            storeCreditPerPointTbx.Location = new Point(218, 299);
            storeCreditPerPointTbx.Name = "storeCreditPerPointTbx";
            storeCreditPerPointTbx.Size = new Size(68, 34);
            storeCreditPerPointTbx.TabIndex = 17;
            storeCreditPerPointTbx.Text = "";
            // 
            // playerPointsLbl
            // 
            playerPointsLbl.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            playerPointsLbl.AutoSize = true;
            playerPointsLbl.Location = new Point(72, 38);
            playerPointsLbl.Name = "playerPointsLbl";
            playerPointsLbl.Size = new Size(129, 28);
            playerPointsLbl.TabIndex = 6;
            playerPointsLbl.Text = "Player points:";
            // 
            // playerPointsNum
            // 
            playerPointsNum.Location = new Point(210, 41);
            playerPointsNum.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            playerPointsNum.Name = "playerPointsNum";
            playerPointsNum.Size = new Size(68, 34);
            playerPointsNum.TabIndex = 13;
            playerPointsNum.ValueChanged += playerPointsNum_ValueChanged;
            // 
            // playerSettingsLbl
            // 
            playerSettingsLbl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            playerSettingsLbl.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(playerSettingsLbl, 2);
            playerSettingsLbl.Font = new Font("Lucida Sans", 16.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            playerSettingsLbl.Location = new Point(6, 3);
            playerSettingsLbl.Name = "playerSettingsLbl";
            playerSettingsLbl.Size = new Size(276, 32);
            playerSettingsLbl.TabIndex = 15;
            playerSettingsLbl.Text = "Player Settings";
            playerSettingsLbl.TextAlign = ContentAlignment.TopCenter;
            // 
            // storeCreditReceivedLbl
            // 
            storeCreditReceivedLbl.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            storeCreditReceivedLbl.AutoSize = true;
            storeCreditReceivedLbl.Location = new Point(6, 81);
            storeCreditReceivedLbl.Name = "storeCreditReceivedLbl";
            storeCreditReceivedLbl.Size = new Size(195, 28);
            storeCreditReceivedLbl.TabIndex = 18;
            storeCreditReceivedLbl.Text = "Store credit received:";
            // 
            // storeCreditReceivedTbx
            // 
            storeCreditReceivedTbx.BackColor = Color.Lime;
            storeCreditReceivedTbx.BorderStyle = BorderStyle.FixedSingle;
            storeCreditReceivedTbx.Enabled = false;
            storeCreditReceivedTbx.Location = new Point(210, 84);
            storeCreditReceivedTbx.Name = "storeCreditReceivedTbx";
            storeCreditReceivedTbx.Size = new Size(68, 34);
            storeCreditReceivedTbx.TabIndex = 19;
            storeCreditReceivedTbx.Text = "";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.OutsetPartial;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(storeCreditReceivedTbx, 1, 2);
            tableLayoutPanel1.Controls.Add(playerPointsLbl, 0, 1);
            tableLayoutPanel1.Controls.Add(playerPointsNum, 1, 1);
            tableLayoutPanel1.Controls.Add(storeCreditReceivedLbl, 0, 2);
            tableLayoutPanel1.Controls.Add(playerSettingsLbl, 0, 0);
            tableLayoutPanel1.Location = new Point(356, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(288, 125);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // addToListBtn
            // 
            addToListBtn.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addToListBtn.Location = new Point(356, 143);
            addToListBtn.Name = "addToListBtn";
            addToListBtn.Size = new Size(94, 37);
            addToListBtn.TabIndex = 4;
            addToListBtn.Text = "Add to list";
            addToListBtn.UseVisualStyleBackColor = true;
            addToListBtn.Click += addToListBtn_Click;
            // 
            // clearListBtn
            // 
            clearListBtn.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clearListBtn.Location = new Point(550, 143);
            clearListBtn.Name = "clearListBtn";
            clearListBtn.Size = new Size(94, 37);
            clearListBtn.TabIndex = 5;
            clearListBtn.Text = "Clear list";
            clearListBtn.UseVisualStyleBackColor = true;
            clearListBtn.Click += clearListBtn_Click;
            // 
            // prizingLbx
            // 
            prizingLbx.FormattingEnabled = true;
            prizingLbx.Location = new Point(356, 186);
            prizingLbx.Name = "prizingLbx";
            prizingLbx.Size = new Size(290, 172);
            prizingLbx.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(658, 362);
            Controls.Add(prizingLbx);
            Controls.Add(clearListBtn);
            Controls.Add(addToListBtn);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(MainTlp);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            MaximizeBox = false;
            MaximumSize = new Size(676, 409);
            MinimumSize = new Size(676, 409);
            Name = "Form1";
            Text = "Simplified Store Credit Calculator";
            MainTlp.ResumeLayout(false);
            MainTlp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)totalPointsNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)everybodyGetsNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)numberOfPlayersNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)entryCostNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)playerPointsNum).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
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
        private Label tournamentSettingsLbl;
        private Label playerSettingsLbl;
        private Label storeCreditPerPointLbl;
        private RichTextBox storeCreditPerPointTbx;
        private RichTextBox storeCreditReceivedTbx;
        private Label storeCreditReceivedLbl;
        private TableLayoutPanel tableLayoutPanel1;
        private Button addToListBtn;
        private Button clearListBtn;
        private ListBox prizingLbx;
    }
}

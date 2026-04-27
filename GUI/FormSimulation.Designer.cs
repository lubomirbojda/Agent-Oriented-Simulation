namespace GUI
{
    partial class FormSimulation
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
            tabControl1 = new TabControl();
            tabPageSimulation = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            dataGridView1 = new DataGridView();
            label7 = new Label();
            tabPageAnimation = new TabPage();
            trackBar1 = new TrackBar();
            MaxSpeedCheckBox = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            trackBar2 = new TrackBar();
            label3 = new Label();
            numericUpDown1 = new NumericUpDown();
            checkBoxSeed = new CheckBox();
            numericUpDown2 = new NumericUpDown();
            label4 = new Label();
            label5 = new Label();
            numericUpDown3 = new NumericUpDown();
            numericUpDown4 = new NumericUpDown();
            label6 = new Label();
            numericUpDown5 = new NumericUpDown();
            StartSimButton = new Button();
            PauseSimButton = new Button();
            tabControl1.SuspendLayout();
            tabPageSimulation.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown5).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPageSimulation);
            tabControl1.Controls.Add(tabPageAnimation);
            tabControl1.Location = new Point(1, 126);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1015, 562);
            tabControl1.TabIndex = 0;
            // 
            // tabPageSimulation
            // 
            tabPageSimulation.Controls.Add(tableLayoutPanel1);
            tabPageSimulation.Location = new Point(4, 24);
            tabPageSimulation.Name = "tabPageSimulation";
            tabPageSimulation.Padding = new Padding(3);
            tabPageSimulation.Size = new Size(1007, 534);
            tabPageSimulation.TabIndex = 0;
            tabPageSimulation.Text = "Simulácia";
            tabPageSimulation.UseVisualStyleBackColor = true;
            tabPageSimulation.Click += tabPage1_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1001, 528);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(dataGridView1, 0, 1);
            tableLayoutPanel2.Controls.Add(label7, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 8.148149F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 91.85185F));
            tableLayoutPanel2.Size = new Size(494, 258);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 24);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(488, 231);
            dataGridView1.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Fill;
            label7.Location = new Point(3, 0);
            label7.Name = "label7";
            label7.Size = new Size(488, 21);
            label7.TabIndex = 1;
            label7.Text = "label7";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabPageAnimation
            // 
            tabPageAnimation.Location = new Point(4, 24);
            tabPageAnimation.Name = "tabPageAnimation";
            tabPageAnimation.Padding = new Padding(3);
            tabPageAnimation.Size = new Size(936, 559);
            tabPageAnimation.TabIndex = 1;
            tabPageAnimation.Text = "Animácia";
            tabPageAnimation.UseVisualStyleBackColor = true;
            tabPageAnimation.Click += tabPage2_Click;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(274, 43);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(146, 45);
            trackBar1.TabIndex = 3;
            // 
            // MaxSpeedCheckBox
            // 
            MaxSpeedCheckBox.AutoSize = true;
            MaxSpeedCheckBox.Location = new Point(12, 47);
            MaxSpeedCheckBox.Name = "MaxSpeedCheckBox";
            MaxSpeedCheckBox.Size = new Size(130, 19);
            MaxSpeedCheckBox.TabIndex = 4;
            MaxSpeedCheckBox.Text = "Maximálna rýchlosť";
            MaxSpeedCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 79);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 5;
            label1.Text = "Sim. čas:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(71, 75);
            label2.Name = "label2";
            label2.Size = new Size(36, 19);
            label2.TabIndex = 6;
            label2.Text = "0.00";
            // 
            // trackBar2
            // 
            trackBar2.Location = new Point(274, 83);
            trackBar2.Name = "trackBar2";
            trackBar2.Size = new Size(146, 45);
            trackBar2.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(249, 13);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 8;
            label3.Text = "Replikácie:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(318, 8);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(102, 23);
            numericUpDown1.TabIndex = 9;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // checkBoxSeed
            // 
            checkBoxSeed.AutoSize = true;
            checkBoxSeed.Location = new Point(455, 9);
            checkBoxSeed.Name = "checkBoxSeed";
            checkBoxSeed.Size = new Size(94, 19);
            checkBoxSeed.TabIndex = 10;
            checkBoxSeed.Text = "Vlastný seed:";
            checkBoxSeed.UseVisualStyleBackColor = true;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Enabled = false;
            numericUpDown2.Location = new Point(555, 8);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(83, 23);
            numericUpDown2.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(491, 73);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 12;
            label4.Text = "Sestričky:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(498, 104);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 13;
            label5.Text = "Doktori:";
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(553, 71);
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(54, 23);
            numericUpDown3.TabIndex = 14;
            // 
            // numericUpDown4
            // 
            numericUpDown4.Location = new Point(553, 102);
            numericUpDown4.Name = "numericUpDown4";
            numericUpDown4.Size = new Size(54, 23);
            numericUpDown4.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(466, 43);
            label6.Name = "label6";
            label6.Size = new Size(86, 15);
            label6.TabIndex = 16;
            label6.Text = "Zahrievanie(h):";
            // 
            // numericUpDown5
            // 
            numericUpDown5.Location = new Point(555, 39);
            numericUpDown5.Name = "numericUpDown5";
            numericUpDown5.Size = new Size(52, 23);
            numericUpDown5.TabIndex = 17;
            // 
            // StartSimButton
            // 
            StartSimButton.BackColor = Color.FromArgb(0, 192, 0);
            StartSimButton.Location = new Point(12, 12);
            StartSimButton.Name = "StartSimButton";
            StartSimButton.Size = new Size(75, 23);
            StartSimButton.TabIndex = 18;
            StartSimButton.Text = "Spustiť";
            StartSimButton.UseVisualStyleBackColor = false;
            // 
            // PauseSimButton
            // 
            PauseSimButton.Location = new Point(93, 12);
            PauseSimButton.Name = "PauseSimButton";
            PauseSimButton.Size = new Size(75, 23);
            PauseSimButton.TabIndex = 19;
            PauseSimButton.Text = "Pozastaviť";
            PauseSimButton.UseVisualStyleBackColor = true;
            // 
            // FormSimulation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1016, 689);
            Controls.Add(PauseSimButton);
            Controls.Add(StartSimButton);
            Controls.Add(numericUpDown5);
            Controls.Add(label6);
            Controls.Add(numericUpDown4);
            Controls.Add(numericUpDown3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(numericUpDown2);
            Controls.Add(checkBoxSeed);
            Controls.Add(numericUpDown1);
            Controls.Add(label3);
            Controls.Add(trackBar2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(MaxSpeedCheckBox);
            Controls.Add(trackBar1);
            Controls.Add(tabControl1);
            Name = "FormSimulation";
            Text = "gr";
            tabControl1.ResumeLayout(false);
            tabPageSimulation.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPageSimulation;
        private TabPage tabPageAnimation;
        private Button button1;
        private Button button2;
        private TrackBar trackBar1;
        private CheckBox MaxSpeedCheckBox;
        private Label label1;
        private Label label2;
        private TrackBar trackBar2;
        private Label label3;
        private NumericUpDown numericUpDown1;
        private CheckBox checkBoxSeed;
        private NumericUpDown numericUpDown2;
        private Label label4;
        private Label label5;
        private NumericUpDown numericUpDown3;
        private NumericUpDown numericUpDown4;
        private Label label6;
        private NumericUpDown numericUpDown5;
        private Button StartSimButton;
        private Button PauseSimButton;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private DataGridView dataGridView1;
        private Label label7;
    }
}

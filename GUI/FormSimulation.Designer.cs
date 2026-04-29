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
            tabControlMain = new TabControl();
            tabPageSimulation = new TabPage();
            tabControlSimulation = new TabControl();
            tabPagePatients = new TabPage();
            dataGridViewPatients = new DataGridView();
            ColumnId_Patient = new DataGridViewTextBoxColumn();
            ColumnAmbulance_patient = new DataGridViewTextBoxColumn();
            ColumnWaitingForEntrance_Patient = new DataGridViewTextBoxColumn();
            ColumnEntranceComplete_patient = new DataGridViewTextBoxColumn();
            ColumnPriority_patient = new DataGridViewTextBoxColumn();
            ColumnWaitingForMedical_patient = new DataGridViewTextBoxColumn();
            ColumnAssignedNurse_patinet = new DataGridViewTextBoxColumn();
            ColumnAssignedDoctor_patient = new DataGridViewTextBoxColumn();
            ColumnAssignedAmbulance_patinet = new DataGridViewTextBoxColumn();
            tabPageDoctors = new TabPage();
            dataGridViewDoctors = new DataGridView();
            ColumnID_doctors = new DataGridViewTextBoxColumn();
            ColumnBusy_docotr = new DataGridViewTextBoxColumn();
            ColumnActualAmbulance_Doctor = new DataGridViewTextBoxColumn();
            tabPageNurses = new TabPage();
            dataGridViewNurses = new DataGridView();
            ColumnId_nurse = new DataGridViewTextBoxColumn();
            ColumnIsbusy_nurse = new DataGridViewTextBoxColumn();
            ColumnAmbul_nurse = new DataGridViewTextBoxColumn();
            tabPageAmbulationsA = new TabPage();
            dataGridViewAmbA = new DataGridView();
            Columnid_amb_a = new DataGridViewTextBoxColumn();
            ColumnIsbusy_amb_a = new DataGridViewTextBoxColumn();
            ColumnAssPatient_amb_a = new DataGridViewTextBoxColumn();
            ColumnNurse_amb_a = new DataGridViewTextBoxColumn();
            ColumnDoc_amb_a = new DataGridViewTextBoxColumn();
            tabPageAmbulationsB = new TabPage();
            dataGridViewAmbB = new DataGridView();
            ColumnId_amb_b = new DataGridViewTextBoxColumn();
            ColumnBusy_amb_b = new DataGridViewTextBoxColumn();
            ColumnPatient_amb_b = new DataGridViewTextBoxColumn();
            ColumnNurse_amb_b = new DataGridViewTextBoxColumn();
            ColumnDoc_amb_b = new DataGridViewTextBoxColumn();
            tabPageAnimation = new TabPage();
            trackBarPauseTime = new TrackBar();
            MaxSpeedCheckBox = new CheckBox();
            label1 = new Label();
            labelSimTime = new Label();
            trackBarIntervalTime = new TrackBar();
            label3 = new Label();
            numericUpDownReplications = new NumericUpDown();
            checkBoxSeed = new CheckBox();
            numericUpDown2 = new NumericUpDown();
            label4 = new Label();
            label5 = new Label();
            numericUpDown3 = new NumericUpDown();
            numericUpDown4 = new NumericUpDown();
            label6 = new Label();
            numericUpDown5 = new NumericUpDown();
            buttonStartSim = new Button();
            buttonPauseSim = new Button();
            label7 = new Label();
            label8 = new Label();
            label2 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            labelActualReplication = new Label();
            buttonCreateAnimator = new Button();
            buttonDeleteAnimator = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            tabControlMain.SuspendLayout();
            tabPageSimulation.SuspendLayout();
            tabControlSimulation.SuspendLayout();
            tabPagePatients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPatients).BeginInit();
            tabPageDoctors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDoctors).BeginInit();
            tabPageNurses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNurses).BeginInit();
            tabPageAmbulationsA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAmbA).BeginInit();
            tabPageAmbulationsB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAmbB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarPauseTime).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarIntervalTime).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownReplications).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown5).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlMain
            // 
            tabControlMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControlMain.Controls.Add(tabPageSimulation);
            tabControlMain.Controls.Add(tabPageAnimation);
            tabControlMain.Location = new Point(1, 141);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(1151, 547);
            tabControlMain.TabIndex = 0;
            // 
            // tabPageSimulation
            // 
            tabPageSimulation.Controls.Add(tabControlSimulation);
            tabPageSimulation.Location = new Point(4, 24);
            tabPageSimulation.Name = "tabPageSimulation";
            tabPageSimulation.Padding = new Padding(3);
            tabPageSimulation.Size = new Size(1143, 519);
            tabPageSimulation.TabIndex = 0;
            tabPageSimulation.Text = "Simulácia";
            tabPageSimulation.UseVisualStyleBackColor = true;
            // 
            // tabControlSimulation
            // 
            tabControlSimulation.Controls.Add(tabPagePatients);
            tabControlSimulation.Controls.Add(tabPageDoctors);
            tabControlSimulation.Controls.Add(tabPageNurses);
            tabControlSimulation.Controls.Add(tabPageAmbulationsA);
            tabControlSimulation.Controls.Add(tabPageAmbulationsB);
            tabControlSimulation.Dock = DockStyle.Fill;
            tabControlSimulation.Location = new Point(3, 3);
            tabControlSimulation.Name = "tabControlSimulation";
            tabControlSimulation.SelectedIndex = 0;
            tabControlSimulation.Size = new Size(1137, 513);
            tabControlSimulation.TabIndex = 0;
            // 
            // tabPagePatients
            // 
            tabPagePatients.Controls.Add(dataGridViewPatients);
            tabPagePatients.Location = new Point(4, 24);
            tabPagePatients.Name = "tabPagePatients";
            tabPagePatients.Padding = new Padding(3);
            tabPagePatients.Size = new Size(1129, 485);
            tabPagePatients.TabIndex = 0;
            tabPagePatients.Text = "Pacienti";
            tabPagePatients.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPatients
            // 
            dataGridViewPatients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPatients.Columns.AddRange(new DataGridViewColumn[] { ColumnId_Patient, ColumnAmbulance_patient, ColumnWaitingForEntrance_Patient, ColumnEntranceComplete_patient, ColumnPriority_patient, ColumnWaitingForMedical_patient, ColumnAssignedNurse_patinet, ColumnAssignedDoctor_patient, ColumnAssignedAmbulance_patinet });
            dataGridViewPatients.Dock = DockStyle.Fill;
            dataGridViewPatients.Location = new Point(3, 3);
            dataGridViewPatients.Name = "dataGridViewPatients";
            dataGridViewPatients.Size = new Size(1123, 479);
            dataGridViewPatients.TabIndex = 0;
            // 
            // ColumnId_Patient
            // 
            ColumnId_Patient.HeaderText = "Id";
            ColumnId_Patient.Name = "ColumnId_Patient";
            // 
            // ColumnAmbulance_patient
            // 
            ColumnAmbulance_patient.HeaderText = "Prišiel sanitkou?";
            ColumnAmbulance_patient.Name = "ColumnAmbulance_patient";
            // 
            // ColumnWaitingForEntrance_Patient
            // 
            ColumnWaitingForEntrance_Patient.HeaderText = "Čakanie na vsetupné vyšetrenie";
            ColumnWaitingForEntrance_Patient.Name = "ColumnWaitingForEntrance_Patient";
            // 
            // ColumnEntranceComplete_patient
            // 
            ColumnEntranceComplete_patient.HeaderText = "Vstupné vyšetrenie hotové";
            ColumnEntranceComplete_patient.Name = "ColumnEntranceComplete_patient";
            // 
            // ColumnPriority_patient
            // 
            ColumnPriority_patient.HeaderText = "Priorita";
            ColumnPriority_patient.Name = "ColumnPriority_patient";
            // 
            // ColumnWaitingForMedical_patient
            // 
            ColumnWaitingForMedical_patient.HeaderText = "Čakanie na lekárske ošetrenie";
            ColumnWaitingForMedical_patient.Name = "ColumnWaitingForMedical_patient";
            // 
            // ColumnAssignedNurse_patinet
            // 
            ColumnAssignedNurse_patinet.HeaderText = "Aktuálne priradená seestrička";
            ColumnAssignedNurse_patinet.Name = "ColumnAssignedNurse_patinet";
            // 
            // ColumnAssignedDoctor_patient
            // 
            ColumnAssignedDoctor_patient.HeaderText = "Aktuálne priradený doktor";
            ColumnAssignedDoctor_patient.Name = "ColumnAssignedDoctor_patient";
            // 
            // ColumnAssignedAmbulance_patinet
            // 
            ColumnAssignedAmbulance_patinet.HeaderText = "Aktuálne priradená ambulancia";
            ColumnAssignedAmbulance_patinet.Name = "ColumnAssignedAmbulance_patinet";
            // 
            // tabPageDoctors
            // 
            tabPageDoctors.Controls.Add(dataGridViewDoctors);
            tabPageDoctors.Location = new Point(4, 24);
            tabPageDoctors.Name = "tabPageDoctors";
            tabPageDoctors.Padding = new Padding(3);
            tabPageDoctors.Size = new Size(1071, 485);
            tabPageDoctors.TabIndex = 1;
            tabPageDoctors.Text = "Doktori";
            tabPageDoctors.UseVisualStyleBackColor = true;
            // 
            // dataGridViewDoctors
            // 
            dataGridViewDoctors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDoctors.Columns.AddRange(new DataGridViewColumn[] { ColumnID_doctors, ColumnBusy_docotr, ColumnActualAmbulance_Doctor });
            dataGridViewDoctors.Dock = DockStyle.Fill;
            dataGridViewDoctors.Location = new Point(3, 3);
            dataGridViewDoctors.Name = "dataGridViewDoctors";
            dataGridViewDoctors.Size = new Size(1065, 479);
            dataGridViewDoctors.TabIndex = 0;
            // 
            // ColumnID_doctors
            // 
            ColumnID_doctors.HeaderText = "Id";
            ColumnID_doctors.Name = "ColumnID_doctors";
            // 
            // ColumnBusy_docotr
            // 
            ColumnBusy_docotr.HeaderText = "Je zaneprázdnený?";
            ColumnBusy_docotr.Name = "ColumnBusy_docotr";
            // 
            // ColumnActualAmbulance_Doctor
            // 
            ColumnActualAmbulance_Doctor.HeaderText = "Aktuálne priradená ambulancia";
            ColumnActualAmbulance_Doctor.Name = "ColumnActualAmbulance_Doctor";
            // 
            // tabPageNurses
            // 
            tabPageNurses.Controls.Add(dataGridViewNurses);
            tabPageNurses.Location = new Point(4, 24);
            tabPageNurses.Name = "tabPageNurses";
            tabPageNurses.Padding = new Padding(3);
            tabPageNurses.Size = new Size(1071, 485);
            tabPageNurses.TabIndex = 2;
            tabPageNurses.Text = "Sestričky";
            tabPageNurses.UseVisualStyleBackColor = true;
            // 
            // dataGridViewNurses
            // 
            dataGridViewNurses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewNurses.Columns.AddRange(new DataGridViewColumn[] { ColumnId_nurse, ColumnIsbusy_nurse, ColumnAmbul_nurse });
            dataGridViewNurses.Dock = DockStyle.Fill;
            dataGridViewNurses.Location = new Point(3, 3);
            dataGridViewNurses.Name = "dataGridViewNurses";
            dataGridViewNurses.Size = new Size(1065, 479);
            dataGridViewNurses.TabIndex = 0;
            // 
            // ColumnId_nurse
            // 
            ColumnId_nurse.HeaderText = "Id";
            ColumnId_nurse.Name = "ColumnId_nurse";
            // 
            // ColumnIsbusy_nurse
            // 
            ColumnIsbusy_nurse.HeaderText = "Je zaneprázdnená?";
            ColumnIsbusy_nurse.Name = "ColumnIsbusy_nurse";
            // 
            // ColumnAmbul_nurse
            // 
            ColumnAmbul_nurse.HeaderText = "Aktuálne priradená ambulancia";
            ColumnAmbul_nurse.Name = "ColumnAmbul_nurse";
            // 
            // tabPageAmbulationsA
            // 
            tabPageAmbulationsA.Controls.Add(dataGridViewAmbA);
            tabPageAmbulationsA.Location = new Point(4, 24);
            tabPageAmbulationsA.Name = "tabPageAmbulationsA";
            tabPageAmbulationsA.Padding = new Padding(3);
            tabPageAmbulationsA.Size = new Size(1071, 485);
            tabPageAmbulationsA.TabIndex = 3;
            tabPageAmbulationsA.Text = "Ambulancie A";
            tabPageAmbulationsA.UseVisualStyleBackColor = true;
            // 
            // dataGridViewAmbA
            // 
            dataGridViewAmbA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAmbA.Columns.AddRange(new DataGridViewColumn[] { Columnid_amb_a, ColumnIsbusy_amb_a, ColumnAssPatient_amb_a, ColumnNurse_amb_a, ColumnDoc_amb_a });
            dataGridViewAmbA.Dock = DockStyle.Fill;
            dataGridViewAmbA.Location = new Point(3, 3);
            dataGridViewAmbA.Name = "dataGridViewAmbA";
            dataGridViewAmbA.Size = new Size(1065, 479);
            dataGridViewAmbA.TabIndex = 0;
            // 
            // Columnid_amb_a
            // 
            Columnid_amb_a.HeaderText = "Id";
            Columnid_amb_a.Name = "Columnid_amb_a";
            // 
            // ColumnIsbusy_amb_a
            // 
            ColumnIsbusy_amb_a.HeaderText = "Je obsadená?";
            ColumnIsbusy_amb_a.Name = "ColumnIsbusy_amb_a";
            // 
            // ColumnAssPatient_amb_a
            // 
            ColumnAssPatient_amb_a.HeaderText = "Pacient";
            ColumnAssPatient_amb_a.Name = "ColumnAssPatient_amb_a";
            // 
            // ColumnNurse_amb_a
            // 
            ColumnNurse_amb_a.HeaderText = "Sestrička";
            ColumnNurse_amb_a.Name = "ColumnNurse_amb_a";
            // 
            // ColumnDoc_amb_a
            // 
            ColumnDoc_amb_a.HeaderText = "Doktor";
            ColumnDoc_amb_a.Name = "ColumnDoc_amb_a";
            // 
            // tabPageAmbulationsB
            // 
            tabPageAmbulationsB.Controls.Add(dataGridViewAmbB);
            tabPageAmbulationsB.Location = new Point(4, 24);
            tabPageAmbulationsB.Name = "tabPageAmbulationsB";
            tabPageAmbulationsB.Padding = new Padding(3);
            tabPageAmbulationsB.Size = new Size(1071, 485);
            tabPageAmbulationsB.TabIndex = 4;
            tabPageAmbulationsB.Text = "Ambulancie B";
            tabPageAmbulationsB.UseVisualStyleBackColor = true;
            // 
            // dataGridViewAmbB
            // 
            dataGridViewAmbB.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAmbB.Columns.AddRange(new DataGridViewColumn[] { ColumnId_amb_b, ColumnBusy_amb_b, ColumnPatient_amb_b, ColumnNurse_amb_b, ColumnDoc_amb_b });
            dataGridViewAmbB.Dock = DockStyle.Fill;
            dataGridViewAmbB.Location = new Point(3, 3);
            dataGridViewAmbB.Name = "dataGridViewAmbB";
            dataGridViewAmbB.Size = new Size(1065, 479);
            dataGridViewAmbB.TabIndex = 0;
            // 
            // ColumnId_amb_b
            // 
            ColumnId_amb_b.HeaderText = "Id";
            ColumnId_amb_b.Name = "ColumnId_amb_b";
            // 
            // ColumnBusy_amb_b
            // 
            ColumnBusy_amb_b.HeaderText = "Je obsadená?";
            ColumnBusy_amb_b.Name = "ColumnBusy_amb_b";
            // 
            // ColumnPatient_amb_b
            // 
            ColumnPatient_amb_b.HeaderText = "Pacient";
            ColumnPatient_amb_b.Name = "ColumnPatient_amb_b";
            // 
            // ColumnNurse_amb_b
            // 
            ColumnNurse_amb_b.HeaderText = "Sestrička";
            ColumnNurse_amb_b.Name = "ColumnNurse_amb_b";
            // 
            // ColumnDoc_amb_b
            // 
            ColumnDoc_amb_b.HeaderText = "Doktor";
            ColumnDoc_amb_b.Name = "ColumnDoc_amb_b";
            // 
            // tabPageAnimation
            // 
            tabPageAnimation.Location = new Point(4, 24);
            tabPageAnimation.Name = "tabPageAnimation";
            tabPageAnimation.Padding = new Padding(3);
            tabPageAnimation.Size = new Size(1085, 519);
            tabPageAnimation.TabIndex = 1;
            tabPageAnimation.Text = "Animácia";
            tabPageAnimation.UseVisualStyleBackColor = true;
            // 
            // trackBarPauseTime
            // 
            trackBarPauseTime.Location = new Point(91, 26);
            trackBarPauseTime.Minimum = 1;
            trackBarPauseTime.Name = "trackBarPauseTime";
            trackBarPauseTime.Size = new Size(146, 45);
            trackBarPauseTime.TabIndex = 3;
            trackBarPauseTime.Value = 1;
            trackBarPauseTime.ValueChanged += trackBarChange;
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
            MaxSpeedCheckBox.CheckedChanged += MaxSpeedCheckBox_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 72);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 5;
            label1.Text = "Sim. čas:";
            // 
            // labelSimTime
            // 
            labelSimTime.AutoSize = true;
            labelSimTime.Font = new Font("Segoe UI", 10F);
            labelSimTime.ForeColor = Color.Red;
            labelSimTime.Location = new Point(71, 69);
            labelSimTime.Name = "labelSimTime";
            labelSimTime.Size = new Size(36, 19);
            labelSimTime.TabIndex = 6;
            labelSimTime.Text = "0.00";
            // 
            // trackBarIntervalTime
            // 
            trackBarIntervalTime.Location = new Point(91, 71);
            trackBarIntervalTime.Maximum = 100;
            trackBarIntervalTime.Minimum = 1;
            trackBarIntervalTime.Name = "trackBarIntervalTime";
            trackBarIntervalTime.Size = new Size(146, 45);
            trackBarIntervalTime.TabIndex = 7;
            trackBarIntervalTime.Value = 1;
            trackBarIntervalTime.ValueChanged += trackBarChange;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 22);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 8;
            label3.Text = "Replikácie:";
            // 
            // numericUpDownReplications
            // 
            numericUpDownReplications.Location = new Point(111, 18);
            numericUpDownReplications.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numericUpDownReplications.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownReplications.Name = "numericUpDownReplications";
            numericUpDownReplications.Size = new Size(100, 23);
            numericUpDownReplications.TabIndex = 9;
            numericUpDownReplications.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // checkBoxSeed
            // 
            checkBoxSeed.AutoSize = true;
            checkBoxSeed.Location = new Point(28, 58);
            checkBoxSeed.Name = "checkBoxSeed";
            checkBoxSeed.Size = new Size(94, 19);
            checkBoxSeed.TabIndex = 10;
            checkBoxSeed.Text = "Vlastný seed:";
            checkBoxSeed.UseVisualStyleBackColor = true;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Enabled = false;
            numericUpDown2.Location = new Point(128, 57);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(83, 23);
            numericUpDown2.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(217, 43);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 12;
            label4.Text = "Sestričky:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(224, 74);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 13;
            label5.Text = "Doktori:";
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(279, 41);
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(54, 23);
            numericUpDown3.TabIndex = 14;
            numericUpDown3.Value = new decimal(new int[] { 12, 0, 0, 0 });
            // 
            // numericUpDown4
            // 
            numericUpDown4.Location = new Point(279, 72);
            numericUpDown4.Name = "numericUpDown4";
            numericUpDown4.Size = new Size(54, 23);
            numericUpDown4.TabIndex = 15;
            numericUpDown4.Value = new decimal(new int[] { 8, 0, 0, 0 });
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(36, 91);
            label6.Name = "label6";
            label6.Size = new Size(86, 15);
            label6.TabIndex = 16;
            label6.Text = "Zahrievanie(h):";
            // 
            // numericUpDown5
            // 
            numericUpDown5.Location = new Point(128, 91);
            numericUpDown5.Name = "numericUpDown5";
            numericUpDown5.Size = new Size(83, 23);
            numericUpDown5.TabIndex = 17;
            // 
            // buttonStartSim
            // 
            buttonStartSim.BackColor = Color.FromArgb(0, 192, 0);
            buttonStartSim.Location = new Point(12, 12);
            buttonStartSim.Name = "buttonStartSim";
            buttonStartSim.Size = new Size(75, 23);
            buttonStartSim.TabIndex = 18;
            buttonStartSim.Text = "Spustiť";
            buttonStartSim.UseVisualStyleBackColor = false;
            buttonStartSim.Click += buttonStartSim_Click;
            // 
            // buttonPauseSim
            // 
            buttonPauseSim.Location = new Point(93, 12);
            buttonPauseSim.Name = "buttonPauseSim";
            buttonPauseSim.Size = new Size(75, 23);
            buttonPauseSim.TabIndex = 19;
            buttonPauseSim.Text = "Pozastaviť";
            buttonPauseSim.UseVisualStyleBackColor = true;
            buttonPauseSim.Click += buttonPauseSim_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(11, 34);
            label7.Name = "label7";
            label7.Size = new Size(82, 15);
            label7.TabIndex = 20;
            label7.Text = "Trvanie pauzy:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(36, 80);
            label8.Name = "label8";
            label8.Size = new Size(49, 15);
            label8.TabIndex = 21;
            label8.Text = "Interval:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(94, 53);
            label2.Name = "label2";
            label2.Size = new Size(13, 15);
            label2.TabIndex = 22;
            label2.Text = "1";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(94, 98);
            label9.Name = "label9";
            label9.Size = new Size(13, 15);
            label9.TabIndex = 23;
            label9.Text = "1";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(212, 53);
            label10.Name = "label10";
            label10.Size = new Size(19, 15);
            label10.TabIndex = 24;
            label10.Text = "10";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(212, 98);
            label11.Name = "label11";
            label11.Size = new Size(25, 15);
            label11.TabIndex = 25;
            label11.Text = "100";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(15, 94);
            label12.Name = "label12";
            label12.Size = new Size(75, 15);
            label12.TabIndex = 26;
            label12.Text = "Replikácia č.:";
            // 
            // labelActualReplication
            // 
            labelActualReplication.AutoSize = true;
            labelActualReplication.Font = new Font("Segoe UI", 10F);
            labelActualReplication.Location = new Point(90, 92);
            labelActualReplication.Name = "labelActualReplication";
            labelActualReplication.Size = new Size(17, 19);
            labelActualReplication.TabIndex = 27;
            labelActualReplication.Text = "0";
            // 
            // buttonCreateAnimator
            // 
            buttonCreateAnimator.Location = new Point(23, 29);
            buttonCreateAnimator.Name = "buttonCreateAnimator";
            buttonCreateAnimator.Size = new Size(157, 23);
            buttonCreateAnimator.TabIndex = 28;
            buttonCreateAnimator.Text = "Vytvoriť animátor";
            buttonCreateAnimator.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteAnimator
            // 
            buttonDeleteAnimator.Location = new Point(23, 56);
            buttonDeleteAnimator.Name = "buttonDeleteAnimator";
            buttonDeleteAnimator.Size = new Size(157, 23);
            buttonDeleteAnimator.TabIndex = 29;
            buttonDeleteAnimator.Text = "Vymazať animátor";
            buttonDeleteAnimator.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(trackBarPauseTime);
            groupBox1.Controls.Add(trackBarIntervalTime);
            groupBox1.Controls.Add(label8);
            groupBox1.Location = new Point(298, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(259, 123);
            groupBox1.TabIndex = 31;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ovládanie rýchlosti";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(numericUpDownReplications);
            groupBox2.Controls.Add(checkBoxSeed);
            groupBox2.Controls.Add(numericUpDown2);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(numericUpDown3);
            groupBox2.Controls.Add(numericUpDown4);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(numericUpDown5);
            groupBox2.Location = new Point(563, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(362, 127);
            groupBox2.TabIndex = 32;
            groupBox2.TabStop = false;
            groupBox2.Text = "Nastavenia simulácie";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(buttonCreateAnimator);
            groupBox3.Controls.Add(buttonDeleteAnimator);
            groupBox3.Enabled = false;
            groupBox3.Location = new Point(931, 34);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(200, 100);
            groupBox3.TabIndex = 33;
            groupBox3.TabStop = false;
            groupBox3.Text = "groupBox3";
            // 
            // FormSimulation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1152, 689);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(labelActualReplication);
            Controls.Add(label12);
            Controls.Add(buttonPauseSim);
            Controls.Add(buttonStartSim);
            Controls.Add(labelSimTime);
            Controls.Add(label1);
            Controls.Add(MaxSpeedCheckBox);
            Controls.Add(tabControlMain);
            Name = "FormSimulation";
            Text = "gr";
            tabControlMain.ResumeLayout(false);
            tabPageSimulation.ResumeLayout(false);
            tabControlSimulation.ResumeLayout(false);
            tabPagePatients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewPatients).EndInit();
            tabPageDoctors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewDoctors).EndInit();
            tabPageNurses.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewNurses).EndInit();
            tabPageAmbulationsA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewAmbA).EndInit();
            tabPageAmbulationsB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewAmbB).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarPauseTime).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarIntervalTime).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownReplications).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown5).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControlMain;
        private TabPage tabPageAnimation;
        private Button button1;
        private Button button2;
        private TrackBar trackBarPauseTime;
        private CheckBox MaxSpeedCheckBox;
        private Label label1;
        private Label labelSimTime;
        private TrackBar trackBarIntervalTime;
        private Label label3;
        private NumericUpDown numericUpDownReplications;
        private CheckBox checkBoxSeed;
        private NumericUpDown numericUpDown2;
        private Label label4;
        private Label label5;
        private NumericUpDown numericUpDown3;
        private NumericUpDown numericUpDown4;
        private Label label6;
        private NumericUpDown numericUpDown5;
        private Button buttonStartSim;
        private Button buttonPauseSim;
        private TabPage tabPageSimulation;
        private TabControl tabControlSimulation;
        private TabPage tabPagePatients;
        private TabPage tabPageDoctors;
        private TabPage tabPageNurses;
        private TabPage tabPageAmbulationsA;
        private TabPage tabPageAmbulationsB;
        private Label label7;
        private Label label8;
        private DataGridView dataGridViewDoctors;
        private DataGridView dataGridViewPatients;
        private DataGridViewTextBoxColumn ColumnId_Patient;
        private DataGridViewTextBoxColumn ColumnAmbulance_patient;
        private DataGridViewTextBoxColumn ColumnWaitingForEntrance_Patient;
        private DataGridViewTextBoxColumn ColumnEntranceComplete_patient;
        private DataGridViewTextBoxColumn ColumnPriority_patient;
        private DataGridViewTextBoxColumn ColumnWaitingForMedical_patient;
        private DataGridViewTextBoxColumn ColumnAssignedNurse_patinet;
        private DataGridViewTextBoxColumn ColumnAssignedDoctor_patient;
        private DataGridViewTextBoxColumn ColumnAssignedAmbulance_patinet;
        private Label label2;
        private Label label9;
        private Label label10;
        private Label label11;
        private DataGridViewTextBoxColumn ColumnID_doctors;
        private DataGridViewTextBoxColumn ColumnBusy_docotr;
        private DataGridViewTextBoxColumn ColumnActualAmbulance_Doctor;
        private DataGridView dataGridViewNurses;
        private DataGridViewTextBoxColumn ColumnId_nurse;
        private DataGridViewTextBoxColumn ColumnIsbusy_nurse;
        private DataGridViewTextBoxColumn ColumnAmbul_nurse;
        private DataGridView dataGridViewAmbA;
        private DataGridViewTextBoxColumn Columnid_amb_a;
        private DataGridViewTextBoxColumn ColumnIsbusy_amb_a;
        private DataGridViewTextBoxColumn ColumnAssPatient_amb_a;
        private DataGridViewTextBoxColumn ColumnNurse_amb_a;
        private DataGridViewTextBoxColumn ColumnDoc_amb_a;
        private DataGridView dataGridViewAmbB;
        private DataGridViewTextBoxColumn ColumnId_amb_b;
        private DataGridViewTextBoxColumn ColumnBusy_amb_b;
        private DataGridViewTextBoxColumn ColumnPatient_amb_b;
        private DataGridViewTextBoxColumn ColumnNurse_amb_b;
        private DataGridViewTextBoxColumn ColumnDoc_amb_b;
        private Label label12;
        private Label labelActualReplication;
        private Button buttonCreateAnimator;
        private Button buttonDeleteAnimator;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
    }
}

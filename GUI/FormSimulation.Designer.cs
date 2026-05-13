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
            tabPageStats = new TabPage();
            textBoxUtilAmbBInt = new TextBox();
            textBoxUtilAmbB = new TextBox();
            label31 = new Label();
            textBoxUtilAmbAInt = new TextBox();
            textBoxUtilAmbA = new TextBox();
            label30 = new Label();
            textBoxUtilDoctorsInt = new TextBox();
            textBoxUtilDoctors = new TextBox();
            label29 = new Label();
            textBoxUtilNursesInt = new TextBox();
            textBoxUtilNurses = new TextBox();
            label28 = new Label();
            textBoxWaitMedicalAmbulanceInt = new TextBox();
            textBoxWaitMedicalAmbulance = new TextBox();
            label25 = new Label();
            textBoxWaitMedicalAloneInt = new TextBox();
            textBoxWaitMedicalAlone = new TextBox();
            label26 = new Label();
            textBoxWaitMedicalAllInt = new TextBox();
            textBoxWaitMedicalAll = new TextBox();
            label27 = new Label();
            textBoxEntranceQueueInt = new TextBox();
            textBoxEntranceQueue = new TextBox();
            label24 = new Label();
            textBoxWaitEntranceAmbulanceInt = new TextBox();
            textBoxWaitEntranceAmbulance = new TextBox();
            label23 = new Label();
            textBoxWaitEntranceAloneInt = new TextBox();
            textBoxWaitEntranceAlone = new TextBox();
            label22 = new Label();
            textBoxWaitEntranceAllInt = new TextBox();
            textBoxWaitEntranceAll = new TextBox();
            label21 = new Label();
            textBoxTimeInSystemAmbulanceInt = new TextBox();
            textBoxTimeInSystemAmbulance = new TextBox();
            label20 = new Label();
            textBoxTimeInSystemAloneInt = new TextBox();
            textBoxTimeInSystemAlone = new TextBox();
            label19 = new Label();
            textBoxTimeInSystemAllInt = new TextBox();
            textBoxTimeInSystemAll = new TextBox();
            label18 = new Label();
            textBoxPatientsServedAmbulanceInt = new TextBox();
            textBoxPatientsServedAmbulance = new TextBox();
            label17 = new Label();
            textBoxPatientsServedAloneInt = new TextBox();
            textBoxPatientsServedAlone = new TextBox();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            textBoxPatientsServedAllInt = new TextBox();
            textBoxPatientsServedAll = new TextBox();
            label13 = new Label();
            trackBarPauseTime = new TrackBar();
            MaxSpeedCheckBox = new CheckBox();
            label1 = new Label();
            labelSimTime = new Label();
            trackBarIntervalTime = new TrackBar();
            label3 = new Label();
            numericUpDownReplications = new NumericUpDown();
            label4 = new Label();
            label5 = new Label();
            numericUpDownNurses = new NumericUpDown();
            numericUpDownDoctors = new NumericUpDown();
            label6 = new Label();
            numericUpDownWarpUmHours = new NumericUpDown();
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
            label32 = new Label();
            comboBoxAssign = new ComboBox();
            groupBoxAnimator = new GroupBox();
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
            tabPageStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarPauseTime).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarIntervalTime).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownReplications).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNurses).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDoctors).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownWarpUmHours).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBoxAnimator.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlMain
            // 
            tabControlMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControlMain.Controls.Add(tabPageSimulation);
            tabControlMain.Controls.Add(tabPageAnimation);
            tabControlMain.Controls.Add(tabPageStats);
            tabControlMain.Location = new Point(1, 141);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(1151, 617);
            tabControlMain.TabIndex = 0;
            // 
            // tabPageSimulation
            // 
            tabPageSimulation.Controls.Add(tabControlSimulation);
            tabPageSimulation.Location = new Point(4, 24);
            tabPageSimulation.Name = "tabPageSimulation";
            tabPageSimulation.Padding = new Padding(3);
            tabPageSimulation.Size = new Size(1143, 589);
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
            tabControlSimulation.Size = new Size(1137, 583);
            tabControlSimulation.TabIndex = 0;
            // 
            // tabPagePatients
            // 
            tabPagePatients.Controls.Add(dataGridViewPatients);
            tabPagePatients.Location = new Point(4, 24);
            tabPagePatients.Name = "tabPagePatients";
            tabPagePatients.Padding = new Padding(3);
            tabPagePatients.Size = new Size(1129, 555);
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
            dataGridViewPatients.Size = new Size(1123, 549);
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
            ColumnWaitingForEntrance_Patient.HeaderText = "Čakanie na vstupné vyšetrenie";
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
            tabPageDoctors.Size = new Size(1129, 555);
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
            dataGridViewDoctors.Size = new Size(1123, 549);
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
            tabPageNurses.Size = new Size(1129, 555);
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
            dataGridViewNurses.Size = new Size(1123, 549);
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
            tabPageAmbulationsA.Size = new Size(1129, 555);
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
            dataGridViewAmbA.Size = new Size(1123, 549);
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
            tabPageAmbulationsB.Size = new Size(1129, 555);
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
            dataGridViewAmbB.Size = new Size(1123, 549);
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
            tabPageAnimation.Size = new Size(1143, 589);
            tabPageAnimation.TabIndex = 1;
            tabPageAnimation.Text = "Animácia";
            tabPageAnimation.UseVisualStyleBackColor = true;
            tabPageAnimation.Enter += tabPageAnimation_Enter;
            tabPageAnimation.Leave += tabPageAnimation_Leave;
            // 
            // tabPageStats
            // 
            tabPageStats.Controls.Add(textBoxUtilAmbBInt);
            tabPageStats.Controls.Add(textBoxUtilAmbB);
            tabPageStats.Controls.Add(label31);
            tabPageStats.Controls.Add(textBoxUtilAmbAInt);
            tabPageStats.Controls.Add(textBoxUtilAmbA);
            tabPageStats.Controls.Add(label30);
            tabPageStats.Controls.Add(textBoxUtilDoctorsInt);
            tabPageStats.Controls.Add(textBoxUtilDoctors);
            tabPageStats.Controls.Add(label29);
            tabPageStats.Controls.Add(textBoxUtilNursesInt);
            tabPageStats.Controls.Add(textBoxUtilNurses);
            tabPageStats.Controls.Add(label28);
            tabPageStats.Controls.Add(textBoxWaitMedicalAmbulanceInt);
            tabPageStats.Controls.Add(textBoxWaitMedicalAmbulance);
            tabPageStats.Controls.Add(label25);
            tabPageStats.Controls.Add(textBoxWaitMedicalAloneInt);
            tabPageStats.Controls.Add(textBoxWaitMedicalAlone);
            tabPageStats.Controls.Add(label26);
            tabPageStats.Controls.Add(textBoxWaitMedicalAllInt);
            tabPageStats.Controls.Add(textBoxWaitMedicalAll);
            tabPageStats.Controls.Add(label27);
            tabPageStats.Controls.Add(textBoxEntranceQueueInt);
            tabPageStats.Controls.Add(textBoxEntranceQueue);
            tabPageStats.Controls.Add(label24);
            tabPageStats.Controls.Add(textBoxWaitEntranceAmbulanceInt);
            tabPageStats.Controls.Add(textBoxWaitEntranceAmbulance);
            tabPageStats.Controls.Add(label23);
            tabPageStats.Controls.Add(textBoxWaitEntranceAloneInt);
            tabPageStats.Controls.Add(textBoxWaitEntranceAlone);
            tabPageStats.Controls.Add(label22);
            tabPageStats.Controls.Add(textBoxWaitEntranceAllInt);
            tabPageStats.Controls.Add(textBoxWaitEntranceAll);
            tabPageStats.Controls.Add(label21);
            tabPageStats.Controls.Add(textBoxTimeInSystemAmbulanceInt);
            tabPageStats.Controls.Add(textBoxTimeInSystemAmbulance);
            tabPageStats.Controls.Add(label20);
            tabPageStats.Controls.Add(textBoxTimeInSystemAloneInt);
            tabPageStats.Controls.Add(textBoxTimeInSystemAlone);
            tabPageStats.Controls.Add(label19);
            tabPageStats.Controls.Add(textBoxTimeInSystemAllInt);
            tabPageStats.Controls.Add(textBoxTimeInSystemAll);
            tabPageStats.Controls.Add(label18);
            tabPageStats.Controls.Add(textBoxPatientsServedAmbulanceInt);
            tabPageStats.Controls.Add(textBoxPatientsServedAmbulance);
            tabPageStats.Controls.Add(label17);
            tabPageStats.Controls.Add(textBoxPatientsServedAloneInt);
            tabPageStats.Controls.Add(textBoxPatientsServedAlone);
            tabPageStats.Controls.Add(label16);
            tabPageStats.Controls.Add(label15);
            tabPageStats.Controls.Add(label14);
            tabPageStats.Controls.Add(textBoxPatientsServedAllInt);
            tabPageStats.Controls.Add(textBoxPatientsServedAll);
            tabPageStats.Controls.Add(label13);
            tabPageStats.Location = new Point(4, 24);
            tabPageStats.Name = "tabPageStats";
            tabPageStats.Padding = new Padding(3);
            tabPageStats.Size = new Size(1143, 589);
            tabPageStats.TabIndex = 2;
            tabPageStats.Text = "Štatistiky";
            tabPageStats.UseVisualStyleBackColor = true;
            // 
            // textBoxUtilAmbBInt
            // 
            textBoxUtilAmbBInt.Location = new Point(575, 509);
            textBoxUtilAmbBInt.Name = "textBoxUtilAmbBInt";
            textBoxUtilAmbBInt.Size = new Size(354, 23);
            textBoxUtilAmbBInt.TabIndex = 52;
            // 
            // textBoxUtilAmbB
            // 
            textBoxUtilAmbB.Location = new Point(316, 509);
            textBoxUtilAmbB.Name = "textBoxUtilAmbB";
            textBoxUtilAmbB.Size = new Size(222, 23);
            textBoxUtilAmbB.TabIndex = 51;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label31.Location = new Point(41, 509);
            label31.Name = "label31";
            label31.Size = new Size(166, 17);
            label31.TabIndex = 50;
            label31.Text = "Vyťaženie - ambulancie B";
            // 
            // textBoxUtilAmbAInt
            // 
            textBoxUtilAmbAInt.Location = new Point(575, 480);
            textBoxUtilAmbAInt.Name = "textBoxUtilAmbAInt";
            textBoxUtilAmbAInt.Size = new Size(354, 23);
            textBoxUtilAmbAInt.TabIndex = 49;
            // 
            // textBoxUtilAmbA
            // 
            textBoxUtilAmbA.Location = new Point(316, 480);
            textBoxUtilAmbA.Name = "textBoxUtilAmbA";
            textBoxUtilAmbA.Size = new Size(222, 23);
            textBoxUtilAmbA.TabIndex = 48;
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label30.Location = new Point(41, 480);
            label30.Name = "label30";
            label30.Size = new Size(167, 17);
            label30.TabIndex = 47;
            label30.Text = "Vyťaženie - ambulancie A";
            // 
            // textBoxUtilDoctorsInt
            // 
            textBoxUtilDoctorsInt.Location = new Point(575, 451);
            textBoxUtilDoctorsInt.Name = "textBoxUtilDoctorsInt";
            textBoxUtilDoctorsInt.Size = new Size(354, 23);
            textBoxUtilDoctorsInt.TabIndex = 46;
            // 
            // textBoxUtilDoctors
            // 
            textBoxUtilDoctors.Location = new Point(316, 451);
            textBoxUtilDoctors.Name = "textBoxUtilDoctors";
            textBoxUtilDoctors.Size = new Size(222, 23);
            textBoxUtilDoctors.TabIndex = 45;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label29.Location = new Point(41, 451);
            label29.Name = "label29";
            label29.Size = new Size(132, 17);
            label29.TabIndex = 44;
            label29.Text = "Vyťaženie - doktory";
            // 
            // textBoxUtilNursesInt
            // 
            textBoxUtilNursesInt.Location = new Point(575, 422);
            textBoxUtilNursesInt.Name = "textBoxUtilNursesInt";
            textBoxUtilNursesInt.Size = new Size(354, 23);
            textBoxUtilNursesInt.TabIndex = 43;
            // 
            // textBoxUtilNurses
            // 
            textBoxUtilNurses.Location = new Point(316, 422);
            textBoxUtilNurses.Name = "textBoxUtilNurses";
            textBoxUtilNurses.Size = new Size(222, 23);
            textBoxUtilNurses.TabIndex = 42;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label28.Location = new Point(41, 422);
            label28.Name = "label28";
            label28.Size = new Size(136, 17);
            label28.TabIndex = 41;
            label28.Text = "Vyťaženie - sestričky";
            // 
            // textBoxWaitMedicalAmbulanceInt
            // 
            textBoxWaitMedicalAmbulanceInt.Location = new Point(575, 393);
            textBoxWaitMedicalAmbulanceInt.Name = "textBoxWaitMedicalAmbulanceInt";
            textBoxWaitMedicalAmbulanceInt.Size = new Size(354, 23);
            textBoxWaitMedicalAmbulanceInt.TabIndex = 40;
            // 
            // textBoxWaitMedicalAmbulance
            // 
            textBoxWaitMedicalAmbulance.Location = new Point(316, 393);
            textBoxWaitMedicalAmbulance.Name = "textBoxWaitMedicalAmbulance";
            textBoxWaitMedicalAmbulance.Size = new Size(222, 23);
            textBoxWaitMedicalAmbulance.TabIndex = 39;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label25.Location = new Point(41, 393);
            label25.Name = "label25";
            label25.Size = new Size(216, 17);
            label25.TabIndex = 38;
            label25.Text = "Čas čakania na ošetrenie - sanitka";
            // 
            // textBoxWaitMedicalAloneInt
            // 
            textBoxWaitMedicalAloneInt.Location = new Point(575, 364);
            textBoxWaitMedicalAloneInt.Name = "textBoxWaitMedicalAloneInt";
            textBoxWaitMedicalAloneInt.Size = new Size(354, 23);
            textBoxWaitMedicalAloneInt.TabIndex = 37;
            // 
            // textBoxWaitMedicalAlone
            // 
            textBoxWaitMedicalAlone.Location = new Point(316, 364);
            textBoxWaitMedicalAlone.Name = "textBoxWaitMedicalAlone";
            textBoxWaitMedicalAlone.Size = new Size(222, 23);
            textBoxWaitMedicalAlone.TabIndex = 36;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label26.Location = new Point(41, 364);
            label26.Name = "label26";
            label26.Size = new Size(201, 17);
            label26.TabIndex = 35;
            label26.Text = "Čas čakania na ošetrenie - pešo";
            // 
            // textBoxWaitMedicalAllInt
            // 
            textBoxWaitMedicalAllInt.Location = new Point(575, 335);
            textBoxWaitMedicalAllInt.Name = "textBoxWaitMedicalAllInt";
            textBoxWaitMedicalAllInt.Size = new Size(354, 23);
            textBoxWaitMedicalAllInt.TabIndex = 34;
            // 
            // textBoxWaitMedicalAll
            // 
            textBoxWaitMedicalAll.Location = new Point(316, 335);
            textBoxWaitMedicalAll.Name = "textBoxWaitMedicalAll";
            textBoxWaitMedicalAll.Size = new Size(222, 23);
            textBoxWaitMedicalAll.TabIndex = 33;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label27.Location = new Point(41, 335);
            label27.Name = "label27";
            label27.Size = new Size(207, 17);
            label27.TabIndex = 32;
            label27.Text = "Čas čakania na ošetrenie - všetci";
            // 
            // textBoxEntranceQueueInt
            // 
            textBoxEntranceQueueInt.Location = new Point(575, 306);
            textBoxEntranceQueueInt.Name = "textBoxEntranceQueueInt";
            textBoxEntranceQueueInt.Size = new Size(354, 23);
            textBoxEntranceQueueInt.TabIndex = 31;
            // 
            // textBoxEntranceQueue
            // 
            textBoxEntranceQueue.Location = new Point(316, 306);
            textBoxEntranceQueue.Name = "textBoxEntranceQueue";
            textBoxEntranceQueue.Size = new Size(222, 23);
            textBoxEntranceQueue.TabIndex = 30;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label24.Location = new Point(41, 306);
            label24.Name = "label24";
            label24.Size = new Size(174, 17);
            label24.TabIndex = 29;
            label24.Text = "Dĺžka radu na vstupné vyš.";
            // 
            // textBoxWaitEntranceAmbulanceInt
            // 
            textBoxWaitEntranceAmbulanceInt.Location = new Point(575, 277);
            textBoxWaitEntranceAmbulanceInt.Name = "textBoxWaitEntranceAmbulanceInt";
            textBoxWaitEntranceAmbulanceInt.Size = new Size(354, 23);
            textBoxWaitEntranceAmbulanceInt.TabIndex = 28;
            // 
            // textBoxWaitEntranceAmbulance
            // 
            textBoxWaitEntranceAmbulance.Location = new Point(316, 277);
            textBoxWaitEntranceAmbulance.Name = "textBoxWaitEntranceAmbulance";
            textBoxWaitEntranceAmbulance.Size = new Size(222, 23);
            textBoxWaitEntranceAmbulance.TabIndex = 27;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label23.Location = new Point(41, 277);
            label23.Name = "label23";
            label23.Size = new Size(236, 17);
            label23.TabIndex = 26;
            label23.Text = "Čas čakania na vstupné vyš. - sanitka";
            // 
            // textBoxWaitEntranceAloneInt
            // 
            textBoxWaitEntranceAloneInt.Location = new Point(575, 248);
            textBoxWaitEntranceAloneInt.Name = "textBoxWaitEntranceAloneInt";
            textBoxWaitEntranceAloneInt.Size = new Size(354, 23);
            textBoxWaitEntranceAloneInt.TabIndex = 25;
            // 
            // textBoxWaitEntranceAlone
            // 
            textBoxWaitEntranceAlone.Location = new Point(316, 248);
            textBoxWaitEntranceAlone.Name = "textBoxWaitEntranceAlone";
            textBoxWaitEntranceAlone.Size = new Size(222, 23);
            textBoxWaitEntranceAlone.TabIndex = 24;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label22.Location = new Point(41, 248);
            label22.Name = "label22";
            label22.Size = new Size(221, 17);
            label22.TabIndex = 23;
            label22.Text = "Čas čakania na vstupné vyš. - pešo";
            // 
            // textBoxWaitEntranceAllInt
            // 
            textBoxWaitEntranceAllInt.Location = new Point(575, 219);
            textBoxWaitEntranceAllInt.Name = "textBoxWaitEntranceAllInt";
            textBoxWaitEntranceAllInt.Size = new Size(354, 23);
            textBoxWaitEntranceAllInt.TabIndex = 22;
            // 
            // textBoxWaitEntranceAll
            // 
            textBoxWaitEntranceAll.Location = new Point(316, 219);
            textBoxWaitEntranceAll.Name = "textBoxWaitEntranceAll";
            textBoxWaitEntranceAll.Size = new Size(222, 23);
            textBoxWaitEntranceAll.TabIndex = 21;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label21.Location = new Point(41, 219);
            label21.Name = "label21";
            label21.Size = new Size(227, 17);
            label21.TabIndex = 20;
            label21.Text = "Čas čakania na vstupné vyš. - všetci";
            // 
            // textBoxTimeInSystemAmbulanceInt
            // 
            textBoxTimeInSystemAmbulanceInt.Location = new Point(575, 190);
            textBoxTimeInSystemAmbulanceInt.Name = "textBoxTimeInSystemAmbulanceInt";
            textBoxTimeInSystemAmbulanceInt.Size = new Size(354, 23);
            textBoxTimeInSystemAmbulanceInt.TabIndex = 19;
            // 
            // textBoxTimeInSystemAmbulance
            // 
            textBoxTimeInSystemAmbulance.Location = new Point(316, 190);
            textBoxTimeInSystemAmbulance.Name = "textBoxTimeInSystemAmbulance";
            textBoxTimeInSystemAmbulance.Size = new Size(222, 23);
            textBoxTimeInSystemAmbulance.TabIndex = 18;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label20.Location = new Point(41, 190);
            label20.Name = "label20";
            label20.Size = new Size(151, 17);
            label20.TabIndex = 17;
            label20.Text = "Čas v systéme - sanitka";
            // 
            // textBoxTimeInSystemAloneInt
            // 
            textBoxTimeInSystemAloneInt.Location = new Point(575, 161);
            textBoxTimeInSystemAloneInt.Name = "textBoxTimeInSystemAloneInt";
            textBoxTimeInSystemAloneInt.Size = new Size(354, 23);
            textBoxTimeInSystemAloneInt.TabIndex = 16;
            // 
            // textBoxTimeInSystemAlone
            // 
            textBoxTimeInSystemAlone.Location = new Point(316, 161);
            textBoxTimeInSystemAlone.Name = "textBoxTimeInSystemAlone";
            textBoxTimeInSystemAlone.Size = new Size(222, 23);
            textBoxTimeInSystemAlone.TabIndex = 15;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label19.Location = new Point(41, 161);
            label19.Name = "label19";
            label19.Size = new Size(136, 17);
            label19.TabIndex = 14;
            label19.Text = "Čas v systéme - pešo";
            // 
            // textBoxTimeInSystemAllInt
            // 
            textBoxTimeInSystemAllInt.Location = new Point(575, 132);
            textBoxTimeInSystemAllInt.Name = "textBoxTimeInSystemAllInt";
            textBoxTimeInSystemAllInt.Size = new Size(354, 23);
            textBoxTimeInSystemAllInt.TabIndex = 13;
            // 
            // textBoxTimeInSystemAll
            // 
            textBoxTimeInSystemAll.Location = new Point(316, 132);
            textBoxTimeInSystemAll.Name = "textBoxTimeInSystemAll";
            textBoxTimeInSystemAll.Size = new Size(222, 23);
            textBoxTimeInSystemAll.TabIndex = 12;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label18.Location = new Point(41, 132);
            label18.Name = "label18";
            label18.Size = new Size(142, 17);
            label18.TabIndex = 11;
            label18.Text = "Čas v systéme - všetci";
            // 
            // textBoxPatientsServedAmbulanceInt
            // 
            textBoxPatientsServedAmbulanceInt.Location = new Point(575, 103);
            textBoxPatientsServedAmbulanceInt.Name = "textBoxPatientsServedAmbulanceInt";
            textBoxPatientsServedAmbulanceInt.Size = new Size(354, 23);
            textBoxPatientsServedAmbulanceInt.TabIndex = 10;
            // 
            // textBoxPatientsServedAmbulance
            // 
            textBoxPatientsServedAmbulance.Location = new Point(316, 103);
            textBoxPatientsServedAmbulance.Name = "textBoxPatientsServedAmbulance";
            textBoxPatientsServedAmbulance.Size = new Size(222, 23);
            textBoxPatientsServedAmbulance.TabIndex = 9;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label17.Location = new Point(41, 103);
            label17.Name = "label17";
            label17.Size = new Size(182, 17);
            label17.TabIndex = 8;
            label17.Text = "Obslúžený pacienti - sanitka";
            // 
            // textBoxPatientsServedAloneInt
            // 
            textBoxPatientsServedAloneInt.Location = new Point(575, 74);
            textBoxPatientsServedAloneInt.Name = "textBoxPatientsServedAloneInt";
            textBoxPatientsServedAloneInt.Size = new Size(354, 23);
            textBoxPatientsServedAloneInt.TabIndex = 7;
            // 
            // textBoxPatientsServedAlone
            // 
            textBoxPatientsServedAlone.Location = new Point(316, 74);
            textBoxPatientsServedAlone.Name = "textBoxPatientsServedAlone";
            textBoxPatientsServedAlone.Size = new Size(222, 23);
            textBoxPatientsServedAlone.TabIndex = 6;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label16.Location = new Point(41, 74);
            label16.Name = "label16";
            label16.Size = new Size(167, 17);
            label16.TabIndex = 5;
            label16.Text = "Obslúžený pacienti - pešo";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label15.Location = new Point(679, 17);
            label15.Name = "label15";
            label15.Size = new Size(172, 25);
            label15.TabIndex = 4;
            label15.Text = "95% interval spoľ.";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label14.Location = new Point(383, 17);
            label14.Name = "label14";
            label14.Size = new Size(82, 25);
            label14.TabIndex = 3;
            label14.Text = "Priemer";
            // 
            // textBoxPatientsServedAllInt
            // 
            textBoxPatientsServedAllInt.Location = new Point(575, 45);
            textBoxPatientsServedAllInt.Name = "textBoxPatientsServedAllInt";
            textBoxPatientsServedAllInt.Size = new Size(354, 23);
            textBoxPatientsServedAllInt.TabIndex = 2;
            // 
            // textBoxPatientsServedAll
            // 
            textBoxPatientsServedAll.Location = new Point(316, 45);
            textBoxPatientsServedAll.Name = "textBoxPatientsServedAll";
            textBoxPatientsServedAll.Size = new Size(222, 23);
            textBoxPatientsServedAll.TabIndex = 1;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label13.Location = new Point(41, 45);
            label13.Name = "label13";
            label13.Size = new Size(185, 17);
            label13.TabIndex = 0;
            label13.Text = "Obslúžený pacienti - celkovo";
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
            label3.Location = new Point(37, 25);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 8;
            label3.Text = "Replikácie:";
            // 
            // numericUpDownReplications
            // 
            numericUpDownReplications.Location = new Point(112, 21);
            numericUpDownReplications.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numericUpDownReplications.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownReplications.Name = "numericUpDownReplications";
            numericUpDownReplications.Size = new Size(100, 23);
            numericUpDownReplications.TabIndex = 9;
            numericUpDownReplications.Value = new decimal(new int[] { 200, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(218, 22);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 12;
            label4.Text = "Sestričky:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(225, 60);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 13;
            label5.Text = "Doktori:";
            // 
            // numericUpDownNurses
            // 
            numericUpDownNurses.Location = new Point(280, 21);
            numericUpDownNurses.Name = "numericUpDownNurses";
            numericUpDownNurses.Size = new Size(54, 23);
            numericUpDownNurses.TabIndex = 14;
            numericUpDownNurses.Value = new decimal(new int[] { 8, 0, 0, 0 });
            // 
            // numericUpDownDoctors
            // 
            numericUpDownDoctors.Location = new Point(280, 58);
            numericUpDownDoctors.Name = "numericUpDownDoctors";
            numericUpDownDoctors.Size = new Size(54, 23);
            numericUpDownDoctors.TabIndex = 15;
            numericUpDownDoctors.Value = new decimal(new int[] { 6, 0, 0, 0 });
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 60);
            label6.Name = "label6";
            label6.Size = new Size(86, 15);
            label6.TabIndex = 16;
            label6.Text = "Zahrievanie(h):";
            // 
            // numericUpDownWarpUmHours
            // 
            numericUpDownWarpUmHours.Location = new Point(112, 57);
            numericUpDownWarpUmHours.Name = "numericUpDownWarpUmHours";
            numericUpDownWarpUmHours.Size = new Size(83, 23);
            numericUpDownWarpUmHours.TabIndex = 17;
            numericUpDownWarpUmHours.Value = new decimal(new int[] { 72, 0, 0, 0 });
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
            buttonCreateAnimator.Click += buttonCreateAnimator_Click;
            // 
            // buttonDeleteAnimator
            // 
            buttonDeleteAnimator.Location = new Point(23, 56);
            buttonDeleteAnimator.Name = "buttonDeleteAnimator";
            buttonDeleteAnimator.Size = new Size(157, 23);
            buttonDeleteAnimator.TabIndex = 29;
            buttonDeleteAnimator.Text = "Vymazať animátor";
            buttonDeleteAnimator.UseVisualStyleBackColor = true;
            buttonDeleteAnimator.Click += buttonDeleteAnimator_Click;
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
            groupBox2.Controls.Add(label32);
            groupBox2.Controls.Add(comboBoxAssign);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(numericUpDownReplications);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(numericUpDownNurses);
            groupBox2.Controls.Add(numericUpDownDoctors);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(numericUpDownWarpUmHours);
            groupBox2.Location = new Point(563, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(362, 136);
            groupBox2.TabIndex = 32;
            groupBox2.TabStop = false;
            groupBox2.Text = "Nastavenia simulácie";
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Location = new Point(24, 98);
            label32.Name = "label32";
            label32.Size = new Size(76, 15);
            label32.TabIndex = 19;
            label32.Text = "Prideľovanie:";
            // 
            // comboBoxAssign
            // 
            comboBoxAssign.FormattingEnabled = true;
            comboBoxAssign.Location = new Point(112, 95);
            comboBoxAssign.Name = "comboBoxAssign";
            comboBoxAssign.Size = new Size(222, 23);
            comboBoxAssign.TabIndex = 18;
            comboBoxAssign.SelectedIndexChanged += comboBoxAssign_SelectedIndexChanged;
            // 
            // groupBoxAnimator
            // 
            groupBoxAnimator.Controls.Add(buttonCreateAnimator);
            groupBoxAnimator.Controls.Add(buttonDeleteAnimator);
            groupBoxAnimator.Enabled = false;
            groupBoxAnimator.Location = new Point(931, 34);
            groupBoxAnimator.Name = "groupBoxAnimator";
            groupBoxAnimator.Size = new Size(200, 100);
            groupBoxAnimator.TabIndex = 33;
            groupBoxAnimator.TabStop = false;
            groupBoxAnimator.Text = "Nastavenie animátora";
            // 
            // FormSimulation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1152, 759);
            Controls.Add(groupBoxAnimator);
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
            tabPageStats.ResumeLayout(false);
            tabPageStats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarPauseTime).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarIntervalTime).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownReplications).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNurses).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDoctors).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownWarpUmHours).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBoxAnimator.ResumeLayout(false);
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
        private Label label4;
        private Label label5;
        private NumericUpDown numericUpDownNurses;
        private NumericUpDown numericUpDownDoctors;
        private Label label6;
        private NumericUpDown numericUpDownWarpUmHours;
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
        private GroupBox groupBoxAnimator;
        private DataGridViewTextBoxColumn ColumnId_Patient;
        private DataGridViewTextBoxColumn ColumnAmbulance_patient;
        private DataGridViewTextBoxColumn ColumnWaitingForEntrance_Patient;
        private DataGridViewTextBoxColumn ColumnEntranceComplete_patient;
        private DataGridViewTextBoxColumn ColumnPriority_patient;
        private DataGridViewTextBoxColumn ColumnWaitingForMedical_patient;
        private DataGridViewTextBoxColumn ColumnAssignedNurse_patinet;
        private DataGridViewTextBoxColumn ColumnAssignedDoctor_patient;
        private DataGridViewTextBoxColumn ColumnAssignedAmbulance_patinet;
        private TabPage tabPageStats;
        private Label label14;
        private TextBox textBoxPatientsServedAllInt;
        private TextBox textBoxPatientsServedAll;
        private Label label13;
        private TextBox textBoxPatientsServedAmbulanceInt;
        private TextBox textBoxPatientsServedAmbulance;
        private Label label17;
        private TextBox textBoxPatientsServedAloneInt;
        private TextBox textBoxPatientsServedAlone;
        private Label label16;
        private Label label15;
        private TextBox textBoxTimeInSystemAmbulanceInt;
        private TextBox textBoxTimeInSystemAmbulance;
        private Label label20;
        private TextBox textBoxTimeInSystemAloneInt;
        private TextBox textBoxTimeInSystemAlone;
        private Label label19;
        private TextBox textBoxTimeInSystemAllInt;
        private TextBox textBoxTimeInSystemAll;
        private Label label18;
        private TextBox textBoxEntranceQueueInt;
        private TextBox textBoxEntranceQueue;
        private Label label24;
        private TextBox textBoxWaitEntranceAmbulanceInt;
        private TextBox textBoxWaitEntranceAmbulance;
        private Label label23;
        private TextBox textBoxWaitEntranceAloneInt;
        private TextBox textBoxWaitEntranceAlone;
        private Label label22;
        private TextBox textBoxWaitEntranceAllInt;
        private TextBox textBoxWaitEntranceAll;
        private Label label21;
        private TextBox textBoxWaitMedicalAmbulanceInt;
        private TextBox textBoxWaitMedicalAmbulance;
        private Label label25;
        private TextBox textBoxWaitMedicalAloneInt;
        private TextBox textBoxWaitMedicalAlone;
        private Label label26;
        private TextBox textBoxWaitMedicalAllInt;
        private TextBox textBoxWaitMedicalAll;
        private Label label27;
        private TextBox textBoxUtilAmbBInt;
        private TextBox textBoxUtilAmbB;
        private Label label31;
        private TextBox textBoxUtilAmbAInt;
        private TextBox textBoxUtilAmbA;
        private Label label30;
        private TextBox textBoxUtilDoctorsInt;
        private TextBox textBoxUtilDoctors;
        private Label label29;
        private TextBox textBoxUtilNursesInt;
        private TextBox textBoxUtilNurses;
        private Label label28;
        private Label label32;
        private ComboBox comboBoxAssign;
    }
}

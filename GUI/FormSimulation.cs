using DS_SEM_3.HospitalAgentSimulation.Entities;
using DS_SEM_3.HospitalAgentSimulation.Simulation;
using OSPABA;
using OSPAnimatorGIS;
using Simulation;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Windows.Forms.Integration;

namespace GUI
{
    public partial class FormSimulation : Form
    {
        private ElementHost _WPFHost;
        private MySimulation _simulation;

        public FormSimulation()
        {
            InitializeComponent();
            _simulation = new MySimulation();
            _simulation.OnRefreshUI(RefreshGUI);
            _simulation.OnReplicationWillStart(OnRepliactionStart);

            _simulation.OnReplicationDidFinish(OnRepliactionFinish);

            //_simulation.CreateAnimator();
            //_WPFHost = new ElementHost();
            //_WPFHost.Dock = DockStyle.Fill;
            //_WPFHost.Child = _simulation.Animator.Canvas;
            //tabPageAnimation.Controls.Add(_WPFHost);
        }

        private void RefreshGUI(OSPABA.Simulation sim)
        {
            if (IsDisposed || !IsHandleCreated) return;

            if (InvokeRequired)
            {
                Invoke(() => RefreshGUI(sim));
                return;
            }

            if (_simulation.IsMaxSpeed()) return;


            labelSimTime.Text = _simulation.CurrentTime.ToString("F3");

            if (tabControlMain.SelectedTab == tabPageSimulation)
                RefreshSimulation();

            if (tabControlMain.SelectedTab == tabPageAnimation)
                RefreshAnimation();
        }

        private void OnRepliactionStart(OSPABA.Simulation sim)
        {
            SetSpeed();
        }

        private void OnRepliactionFinish(OSPABA.Simulation sim)
        {
            UpdateActualReplication();
        }

        private void UpdateActualReplication()
        {
            if (InvokeRequired)
            {
                Invoke(new System.Action(UpdateActualReplication));
                return;
            }

            labelActualReplication.Text = _simulation.CurrentReplication.ToString();

            //Stats update
            textBoxPatientsServedAll.Text = MakeAverageString(_simulation.AveragePatientsFinishedAll.GetAverage());
            textBoxPatientsServedAllInt.Text = MakeConfidenceIntervalString(_simulation.AveragePatientsFinishedAll.GetConfidenceInterval95());

            textBoxPatientsServedAlone.Text = MakeAverageString(_simulation.AveragePatientsFinishedAlone.GetAverage());
            textBoxPatientsServedAloneInt.Text = MakeConfidenceIntervalString(_simulation.AveragePatientsFinishedAlone.GetConfidenceInterval95());

            textBoxPatientsServedAmbulance.Text = MakeAverageString(_simulation.AveragePatientsFinishedAmbulance.GetAverage());
            textBoxPatientsServedAmbulanceInt.Text = MakeConfidenceIntervalString(_simulation.AveragePatientsFinishedAmbulance.GetConfidenceInterval95());

            textBoxTimeInSystemAll.Text = MakeTimeSpanString(_simulation.AverageTimeInSystemAll.GetAverage());
            textBoxTimeInSystemAllInt.Text = MakeConfidenceIntervalTimeString(_simulation.AverageTimeInSystemAll.GetConfidenceInterval95());

            textBoxTimeInSystemAlone.Text = MakeTimeSpanString(_simulation.AverageTimeInSystemAlone.GetAverage());
            textBoxTimeInSystemAloneInt.Text = MakeConfidenceIntervalTimeString(_simulation.AverageTimeInSystemAlone.GetConfidenceInterval95());

            textBoxTimeInSystemAmbulance.Text = MakeTimeSpanString(_simulation.AverageTimeInSystemAmbulance.GetAverage());
            textBoxTimeInSystemAmbulanceInt.Text = MakeConfidenceIntervalTimeString(_simulation.AverageTimeInSystemAmbulance.GetConfidenceInterval95());

            textBoxWaitEntranceAll.Text = MakeTimeSpanString(_simulation.AverageWaitingForEntranceTreatAll.GetAverage());
            textBoxWaitEntranceAllInt.Text = MakeConfidenceIntervalTimeString(_simulation.AverageWaitingForEntranceTreatAll.GetConfidenceInterval95());

            textBoxWaitEntranceAlone.Text = MakeTimeSpanString(_simulation.AverageWaitingForEntranceTreatAlone.GetAverage());
            textBoxWaitEntranceAloneInt.Text = MakeConfidenceIntervalTimeString(_simulation.AverageWaitingForEntranceTreatAlone.GetConfidenceInterval95());

            textBoxWaitEntranceAmbulance.Text = MakeTimeSpanString(_simulation.AverageWaitingForEntranceTreatAmbulance.GetAverage());
            textBoxWaitEntranceAmbulanceInt.Text = MakeConfidenceIntervalTimeString(_simulation.AverageWaitingForEntranceTreatAmbulance.GetConfidenceInterval95());

            textBoxEntranceQueue.Text = MakeAverageString(_simulation.AverageEntranceQueueLength.GetAverage());
            textBoxEntranceQueueInt.Text = MakeConfidenceIntervalString(_simulation.AverageEntranceQueueLength.GetConfidenceInterval95());
        
            textBoxWaitMedicalAll.Text = MakeTimeSpanString(_simulation.AverageWaitingForMedicalTreatAll.GetAverage());
            textBoxWaitMedicalAllInt.Text = MakeConfidenceIntervalTimeString(_simulation.AverageWaitingForMedicalTreatAll.GetConfidenceInterval95());

            textBoxWaitMedicalAlone.Text = MakeTimeSpanString(_simulation.AverageWaitingForMedicalTreatAlone.GetAverage());
            textBoxWaitMedicalAloneInt.Text = MakeConfidenceIntervalTimeString(_simulation.AverageWaitingForMedicalTreatAlone.GetConfidenceInterval95());

            textBoxWaitMedicalAmbulance.Text = MakeTimeSpanString(_simulation.AverageWaitingForMedicalTreatAmbulance.GetAverage());
            textBoxWaitMedicalAmbulanceInt.Text = MakeConfidenceIntervalTimeString(_simulation.AverageWaitingForMedicalTreatAmbulance.GetConfidenceInterval95());

            textBoxUtilNurses.Text = MakeAverageString(_simulation.AverageNursesUtilization.GetAverage());
            textBoxUtilNursesInt.Text = MakeConfidenceIntervalString(_simulation.AverageNursesUtilization.GetConfidenceInterval95());

            textBoxUtilDoctors.Text = MakeAverageString(_simulation.AverageDoctorsUtilization.GetAverage());
            textBoxUtilDoctorsInt.Text = MakeConfidenceIntervalString(_simulation.AverageDoctorsUtilization.GetConfidenceInterval95());

            textBoxUtilAmbA.Text = MakeAverageString(_simulation.AverageAmbulanceAUtilization.GetAverage());
            textBoxUtilAmbAInt.Text = MakeConfidenceIntervalString(_simulation.AverageAmbulanceAUtilization.GetConfidenceInterval95());

            textBoxUtilAmbB.Text = MakeAverageString(_simulation.AverageAmbulanceBUtilization.GetAverage());
            textBoxUtilAmbBInt.Text = MakeConfidenceIntervalString(_simulation.AverageAmbulanceBUtilization.GetConfidenceInterval95());
        }

        private string MakeAverageString(double value)
        {
            return value.ToString("F5");
        }

        private string MakeConfidenceIntervalString((double lower, double upper) interval)
        {
            return $"[{interval.lower:F5}  -  {interval.upper:F5}]";
        }

        private string MakeConfidenceIntervalTimeString((double lower, double upper) interval)
        {
            return $"[{MakeTimeSpanString(interval.lower)}  -  {MakeTimeSpanString(interval.upper)}]";
        }

        private string MakeTimeSpanString(double time)
        {
            TimeSpan timeSpan = TimeSpan.FromSeconds(time);

            string str = timeSpan.ToString(@"hh\:mm\:ss");

            return str;
        }

        private void SetSpeed()
        {
            if (InvokeRequired)
            {
                Invoke(new System.Action(SetSpeed));
                return;
            }

            bool isTurboActive = MaxSpeedCheckBox.Checked;

            if (isTurboActive)
            {
                _simulation.SetMaxSimSpeed();
            }
            else
            {
                double interval = trackBarIntervalTime.Value;
                double pause = trackBarPauseTime.Value;

                _simulation.SetSimSpeed(interval, pause);
            }
        }

        private void RefreshSimulation()
        {
            if (tabControlSimulation.SelectedTab == tabPagePatients)
                RefreshPatients();


            RefreshDoctors();
            RefreshNurses();
            RefreshAbmA();
            RefreshAbmB();

            //if (tabControlSimulation.SelectedTab == tabPagePatients)
            //    RefreshPatients();

            //if (tabControlSimulation.SelectedTab == tabPageDoctors)
            //    RefreshDoctors();

            //if (tabControlSimulation.SelectedTab == tabPageNurses)
            //    RefreshNurses();
        }

        private void RefreshAnimation()
        {

        }

        private void RefreshPatients()
        {
            dataGridViewPatients.SuspendLayout();
            dataGridViewPatients.Rows.Clear();
            foreach (var patient in _simulation.AgentHospital.PatientsInHospital.ToList())
            {
                if (patient != null)
                {
                    string id = patient.Id.ToString();
                    string cameByAmbulance = patient.CameByAmbulance ? "Áno" : "Nie";
                    string waitingForEntrance = patient.WaitingForEntranceTreat >= 0 ? patient.WaitingForEntranceTreat.ToString() : "---";
                    string entranceDone = patient.HasEntranceTreatDone ? "Áno" : "Nie";
                    string priority = patient.Priority > 0 ? patient.Priority.ToString() : "---";
                    string waitingForMedical = patient.WaitingForMedicalTreat >= 0 ? patient.WaitingForMedicalTreat.ToString() : "---";
                    string assignedNurse = patient.AssignedNurse != null ? patient.AssignedNurse.Id.ToString() : "---";
                    string assignedDoctor = patient.AssignedDoctor != null ? patient.AssignedDoctor.Id.ToString() : "---";
                    string assignedAmbulance = patient.AssignedAmbulance != null ? 
                        (patient.AssignedAmbulance.IsTypeA ? 
                        "A_" + patient.AssignedAmbulance.Id : "B_" + patient.AssignedAmbulance.Id) 
                        : "---";

                    dataGridViewPatients.Rows.Add(id, cameByAmbulance, waitingForEntrance, entranceDone, priority,
                        waitingForMedical, assignedNurse, assignedDoctor, assignedAmbulance);
                }
            }
            dataGridViewPatients.ResumeLayout();
        }

        private void RefreshDoctors()
        {
            dataGridViewDoctors.SuspendLayout();
            dataGridViewDoctors.Rows.Clear();
            foreach (var doctor in _simulation.AgentResources.Doctors.AllResources.ToList())
            {
                if (doctor != null)
                {
                    string id = doctor.Id.ToString();
                    string isBusy = doctor.IsBusy ? "Áno" : "Nie";
                    string ambulance = doctor.ActualAmbulance != null ?
                        (doctor.ActualAmbulance.IsTypeA ?
                        "A_" + doctor.ActualAmbulance.Id : "B_" + doctor.ActualAmbulance.Id)
                        : "---";

                    dataGridViewDoctors.Rows.Add(id, isBusy, ambulance);
                }
            }
            dataGridViewDoctors.ResumeLayout();
        }

        private void RefreshNurses()
        {
            dataGridViewNurses.SuspendLayout();
            dataGridViewNurses.Rows.Clear();
            foreach (var nurse in _simulation.AgentResources.Nurses.AllResources.ToList())
            {
                if (nurse != null)
                {
                    string id = nurse.Id.ToString();
                    string isBusy = nurse.IsBusy ? "Áno" : "Nie";
                    string ambulance = nurse.ActualAmbulance != null ?
                        (nurse.ActualAmbulance.IsTypeA ?
                        "A_" + nurse.ActualAmbulance.Id : "B_" + nurse.ActualAmbulance.Id)
                        : "---";

                    dataGridViewNurses.Rows.Add(id, isBusy, ambulance);
                }
            }
            dataGridViewNurses.ResumeLayout();
        }

        private void RefreshAbmA() => RefreshAmbulances(dataGridViewAmbA, _simulation.AgentResources.AmbulationsA.AllResources);

        private void RefreshAbmB() => RefreshAmbulances(dataGridViewAmbB, _simulation.AgentResources.AmbulationsB.AllResources);

        private void RefreshAmbulances(DataGridView datagridview, AmbulanceA[] ambulance)
        {
            datagridview.SuspendLayout();
            datagridview.Rows.Clear();
            foreach (var amb in ambulance.ToList())
            {
                if (amb != null)
                {
                    string id = amb.IsTypeA ? "A_" : "B_";
                    id += amb.Id.ToString();
                    string isBusy = amb.IsBusy ? "Áno" : "Nie";
                    string patient = amb.Patient != null ? amb.Patient.Id.ToString() : "---";
                    var busynurse = amb.GetBusyNurse();
                    string nurse = busynurse != null ? busynurse.Id.ToString() : "---";
                    var busydoctor = amb.GetBusyDoctor();
                    string doctor = busydoctor != null ? busydoctor.Id.ToString() : "---";

                    datagridview.Rows.Add(id, isBusy, patient, nurse, doctor);
                }
            }
            datagridview.ResumeLayout();
        }

        private void buttonStartSim_Click(object sender, EventArgs e)
        {
            var nursesCount = (int)numericUpDownNurses.Value;
            var doctorsCount = (int)numericUpDownDoctors.Value;
            var warmUpHours = (int)numericUpDownWarpUmHours.Value;

            _simulation.SetInputParameters(nursesCount, doctorsCount, warmUpHours);

            if (!_simulation.IsRunning())
            {
                buttonStartSim.Text = "Ukončiť";
                int repl = (int)numericUpDownReplications.Value;
                _simulation.SimulateAsync(repl, 24 * 60 * 60 * 28);
            }
            else
            {
                buttonStartSim.Text = "Spustiť";
                _simulation.StopSimulation();
            }
        }

        private void trackBarChange(object sender, EventArgs e)
        {
            SetSpeed();
        }

        private void buttonPauseSim_Click(object sender, EventArgs e)
        {
            if (!_simulation.IsPaused())
            {
                _simulation.PauseSimulation();
                buttonPauseSim.Text = "Pokračovať";
            }
            else
            {
                _simulation.ResumeSimulation();
                buttonPauseSim.Text = "Pozastaviť";
            }

        }

        private void MaxSpeedCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            SetSpeed();
        }
    }
}

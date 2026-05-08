using DS_SEM_3.HospitalAgentSimulation.Entities;
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

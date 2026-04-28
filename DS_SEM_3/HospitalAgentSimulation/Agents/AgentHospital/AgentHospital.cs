using Agents.AgentHospital.ContinualAssistants;
using DS_SEM_3.Generators.Empiric.Continuous;
using DS_SEM_3.Generators.Empiric.Discrete;
using DS_SEM_3.Generators.Triangular;
using DS_SEM_3.Generators.Uniform;
using DS_SEM_3.HospitalAgentSimulation.Entities;
using OSPABA;
using Simulation;
using System.Diagnostics;

namespace Agents.AgentHospital
{
	//meta! id="7"
	public class AgentHospital : OSPABA.Agent
	{
        public List<Patient> PatientsInHospital { get; private set; } = new();
        public Queue<Patient> QueueEntranceAmbulancePatients { get; private set; } = new();
        public Queue<Patient> QueueEntranceAlonePatients { get; private set; } = new();
        //public PriorityQueue<Patient, (int priority, int order)> QueueAmbulanceA { get; private set; } = new();
        private int ambulanceAOrder = 0;
        //public PriorityQueue<Patient, (int priority, int order)> QueueAmbulanceB { get; private set; } = new();
        private int ambulanceBOrder = 0;

        public SortedList<(int priority, int order), Patient> QueueAmbulanceA { get; private set; } = new();
        public SortedList<(int priority, int order), Patient> QueueAmbulanceB { get; private set; } = new();

        public Resources<Nurse> Nurses { get; private set; } = new(12);
        public Resources<Doctor> Doctors { get; private set; } = new(8);
        public Resources<AmbulanceA> AmbulationsA { get; private set; } = new(5);
        public Resources<AmbulanceB> AmbulationsB { get; private set; } = new(7);

        public TriangularDist AlonePatientsMoveToEntranceSpaceGen { get; private set; }
        public ContinuousUniform AmbulancePatientsMoveToEntranceSpaceGen { get; private set; }

        public TriangularDist MoveToAmbulanceGen { get; private set; }

        public ContinuousEmpiric AlonePatientsEntranceTreatGen { get; private set; }
        public ContinuousEmpiric AlonePatientsMedicalTreatGen { get; private set; }
        public DiscreteUniform AmbulancePatientsEntranceTreatGen { get; private set; }
        public ContinuousUniform AmbulancePatientsMedicalTreatGen { get; private set; }

        public DiscreteEmpiric AlonePatientsPriorityGen { get; private set; }
        public DiscreteEmpiric AmbulancePatientsPriorityGen { get; private set; }

        public ContinuousUniform PatientMoveToLeaveDoorGen { get; private set; }

        public AgentHospital(int id, OSPABA.Simulation mySim, Agent parent) :
			base(id, mySim, parent)
		{
			Init();
            MySimulation sim = (MySimulation)MySim;
            AlonePatientsMoveToEntranceSpaceGen = new(sim.SeedGenerator, 120, 300, 150);
            AmbulancePatientsMoveToEntranceSpaceGen = new(sim.SeedGenerator, 90, 200);
            MoveToAmbulanceGen = new(sim.SeedGenerator, 15, 45, 20);
            AlonePatientsEntranceTreatGen = new(sim.SeedGenerator, [
                (3*60, 5*60, 0.6),
                (5*60, 9*60, 0.4)
            ]);
            AlonePatientsMedicalTreatGen = new(sim.SeedGenerator, [
                (10*60, 12*60, 0.1),
                (12*60, 14*60, 0.6),
                (14*60, 18*60, 0.3)
            ]);
            AmbulancePatientsEntranceTreatGen = new(sim.SeedGenerator, 4 * 60, 8 * 60);
            AmbulancePatientsMedicalTreatGen = new(sim.SeedGenerator, 15 * 60, 30 * 60);
            PatientMoveToLeaveDoorGen = new(sim.SeedGenerator, 150, 240);

            AlonePatientsPriorityGen = new(sim.SeedGenerator, [
                (1, 1, 0.1),
                (2, 2, 0.2),
                (3, 3, 0.15),
                (4, 4, 0.25),
                (5, 5, 0.3)
            ]);

            AmbulancePatientsPriorityGen = new(sim.SeedGenerator, [
                (1, 1, 0.3),
                (2, 2, 0.25),
                (3, 3, 0.2),
                (4, 4, 0.15),
                (5, 5, 0.1)
            ]);
        }

		override public void PrepareReplication()
		{
			base.PrepareReplication();
            // Setup component for the next replication
            PatientsInHospital.Clear();
            QueueEntranceAmbulancePatients.Clear();
            QueueEntranceAlonePatients.Clear();
            QueueAmbulanceA.Clear();
            QueueAmbulanceB.Clear();
            ambulanceAOrder = 0;
            ambulanceBOrder = 0;
            Nurses.ResetResources();
            Doctors.ResetResources();
            AmbulationsA.ResetResources();
            AmbulationsB.ResetResources();
        }

        public void EnqueuePatientAmbulanceA(Patient patient, int priority)
        {
            //QueueAmbulanceA.Enqueue(patient, (priority, ambulanceAOrder++));
            QueueAmbulanceA.Add((priority, ambulanceAOrder++), patient);
        }

        public void EnqueuePatientAmbulanceB(Patient patient, int priority)
        {
            //QueueAmbulanceB.Enqueue(patient, (priority, ambulanceBOrder++));
            QueueAmbulanceB.Add((priority, ambulanceBOrder++), patient);
        }

        private Patient DequeuePatient(
            SortedList<(int priority, int order), Patient> sourceQueue,
            SortedList<(int priority, int order), Patient> otherQueue)
        {
            var patient = sourceQueue.Values[0];
            sourceQueue.RemoveAt(0);

            int otherIndex = otherQueue.IndexOfValue(patient);
            if (otherIndex >= 0)
            {
                otherQueue.RemoveAt(otherIndex);
            }

            return patient;
        }

        public Patient DequeuePatientAmbulanceA() => DequeuePatient(QueueAmbulanceA, QueueAmbulanceB);

        public Patient DequeuePatientAmbulanceB() => DequeuePatient(QueueAmbulanceB, QueueAmbulanceA);

        //meta! userInfo="Generated code: do not modify", tag="begin"
        private void Init()
		{
			new ManagerHospital(SimId.ManagerHospital, MySim, this);
			new ProcessMoveToEntranceSpace(SimId.ProcessMoveToEntranceSpace, MySim, this);
			new ProcessMoveToHospital(SimId.ProcessMoveToHospital, MySim, this);
			new ProcessEntranceTreat(SimId.ProcessEntranceTreat, MySim, this);
			new ProcessMedicalTreat(SimId.ProcessMedicalTreat, MySim, this);
			AddOwnMessage(Mc.TreatPatient);
		}
        //meta! tag="end"

        private void StartMoveToHospital(Patient patient, MessageForm message)
        {
            MyMessage msg = (MyMessage)message.CreateCopy();
            msg.Patient = patient;
            msg.Addressee = FindAssistant(SimId.ProcessMoveToHospital);
            MyManager.StartContinualAssistant(msg);
        }

        public void TryAssignResources(MessageForm message)
        {
            var nurse = Nurses.TryGetFreeResource();
            var doctor = Doctors.TryGetFreeResource();
            var ambA = AmbulationsA.TryGetFreeResource();
            var ambB = AmbulationsB.TryGetFreeResource();

            if (QueueAmbulanceA.Count > 0)
            {
                if (nurse != null && doctor != null && ambA != null)
                {
                    var patient = DequeuePatientAmbulanceA();
                    patient.AssignResources(nurse, ambA, doctor);
                    StartMoveToHospital(patient, message);
                    return;
                }
            }
            if (QueueAmbulanceB.Count > 0)
            {
                if (nurse != null && doctor != null && ambB != null)
                {
                    var patient = DequeuePatientAmbulanceB();
                    patient.AssignResources(nurse, ambB, doctor);
                    StartMoveToHospital(patient, message);
                    return;
                }
            }
            if (QueueEntranceAmbulancePatients.Count > 0)
            {
                if (nurse != null && ambB != null)
                {
                    var patient = QueueEntranceAmbulancePatients.Dequeue();
                    patient.AssignResources(nurse, ambB);
                    StartMoveToHospital(patient, message);
                    return;
                }
            }
            if (QueueEntranceAlonePatients.Count > 0)
            {
                if (nurse != null && ambB != null)
                {
                    var patient = QueueEntranceAlonePatients.Dequeue();
                    patient.AssignResources(nurse, ambB);
                    StartMoveToHospital(patient, message);
                    return;
                }
            }
        }
    }
}

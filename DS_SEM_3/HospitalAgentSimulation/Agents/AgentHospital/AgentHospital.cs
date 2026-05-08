using OSPABA;
using Agents.AgentHospital.ContinualAssistants;
using Simulation;
using DS_SEM_3.Generators.Empiric.Continuous;
using DS_SEM_3.Generators.Empiric.Discrete;
using DS_SEM_3.Generators.Triangular;
using DS_SEM_3.Generators.Uniform;
using DS_SEM_3.HospitalAgentSimulation.Entities;
using System.Diagnostics;

namespace Agents.AgentHospital
{
	//meta! id="7"
	public class AgentHospital : OSPABA.Agent
	{
        public List<Patient> PatientsInHospital { get; private set; } = new();
        public QueueEntrancePatients QueueEntrancePatients { get; private set; } = new();

        public PriorityQueuesAmbulances QueuesAmbulances { get; private set; } = new();

        public TriangularDist AlonePatientsMoveToEntranceSpaceGen { get; private set; }
        public ContinuousUniform AmbulancePatientsMoveToEntranceSpaceGen { get; private set; }

        public TriangularDist NurseMoveToAmbulanceGen { get; private set; }
        public TriangularDist DoctorMoveToAmbulanceGen { get; private set; }


        public ContinuousUniform PatientMoveToLeaveDoorGen { get; private set; }

        public AgentHospital(int id, OSPABA.Simulation mySim, Agent parent) :
			base(id, mySim, parent)
		{
			Init();
            MySimulation sim = (MySimulation)MySim;
            AlonePatientsMoveToEntranceSpaceGen = new(sim.SeedGenerator, 120, 300, 150);
            AmbulancePatientsMoveToEntranceSpaceGen = new(sim.SeedGenerator, 90, 200);
            NurseMoveToAmbulanceGen = new(sim.SeedGenerator, 15, 45, 20);
            DoctorMoveToAmbulanceGen = new(sim.SeedGenerator, 15, 45, 20);

            PatientMoveToLeaveDoorGen = new(sim.SeedGenerator, 150, 240);
        }

		override public void PrepareReplication()
		{
			base.PrepareReplication();
            // Setup component for the next replication
            PatientsInHospital.Clear();
            QueueEntrancePatients.Clear();
            QueuesAmbulances.Clear();
        }

		//meta! userInfo="Generated code: do not modify", tag="begin"
		private void Init()
		{
			new ManagerHospital(SimId.ManagerHospital, MySim, this);
			new ProcessMoveToAmbulance(SimId.ProcessMoveToAmbulance, MySim, this);
			new ProcessMoveToLeaveDoor(SimId.ProcessMoveToLeaveDoor, MySim, this);
			new ProcessMoveToEntranceSpace(SimId.ProcessMoveToEntranceSpace, MySim, this);
			AddOwnMessage(Mc.ResourcesAssigned);
			AddOwnMessage(Mc.EntranceTreat);
			AddOwnMessage(Mc.TreatPatient);
			AddOwnMessage(Mc.MedicalTreat);
            AddOwnMessage(Mc.MoveToAmbulance);
            AddOwnMessage(Mc.PatientMoveToEntranceSpace);
            AddOwnMessage(Mc.PatientMoveToLeaveDoor);
		}
		//meta! tag="end"

    }
}
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
        public Queue<Patient> QueueEntranceAmbulancePatients { get; private set; } = new();
        public Queue<Patient> QueueEntranceAlonePatients { get; private set; } = new();

        public PriorityQueuesAmbulances QueuesAmbulances { get; private set; } = new();

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
            QueuesAmbulances.Clear();
        }

		//meta! userInfo="Generated code: do not modify", tag="begin"
		private void Init()
		{
			new ManagerHospital(SimId.ManagerHospital, MySim, this);
			new ProcessMoveToEntranceSpace(SimId.ProcessMoveToEntranceSpace, MySim, this);
			new ProcessMoveToAmbulance(SimId.ProcessMoveToAmbulance, MySim, this);
			AddOwnMessage(Mc.ResourcesAssigned);
			AddOwnMessage(Mc.EntranceTreat);
			AddOwnMessage(Mc.TreatPatient);
			AddOwnMessage(Mc.MedicalTreat);
		}
        //meta! tag="end"

    }
}
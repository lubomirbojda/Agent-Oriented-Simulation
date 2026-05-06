using OSPABA;
using Simulation;
using Agents.AgentEntranceTreat.ContinualAssistants;
using DS_SEM_3.Generators.Empiric.Continuous;
using DS_SEM_3.Generators.Empiric.Discrete;
using DS_SEM_3.Generators.Uniform;

namespace Agents.AgentEntranceTreat
{
	//meta! id="117"
	public class AgentEntranceTreat : OSPABA.Agent
	{
        public ContinuousEmpiric AlonePatientsEntranceTreatGen { get; private set; }
        public DiscreteUniform AmbulancePatientsEntranceTreatGen { get; private set; }

        public DiscreteEmpiric AlonePatientsPriorityGen { get; private set; }
        public DiscreteEmpiric AmbulancePatientsPriorityGen { get; private set; }

        public AgentEntranceTreat(int id, OSPABA.Simulation mySim, Agent parent) :
			base(id, mySim, parent)
		{
			Init();
            MySimulation sim = (MySimulation)MySim;
            AlonePatientsEntranceTreatGen = new(sim.SeedGenerator, [
                (3*60, 5*60, 0.6),
                (5*60, 9*60, 0.4)
            ]);
            AmbulancePatientsEntranceTreatGen = new(sim.SeedGenerator, 4 * 60, 8 * 60);

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
		}

		//meta! userInfo="Generated code: do not modify", tag="begin"
		private void Init()
		{
			new ManagerEntranceTreat(SimId.ManagerEntranceTreat, MySim, this);
			new ProcessEntranceTreat(SimId.ProcessEntranceTreat, MySim, this);
			AddOwnMessage(Mc.EntranceTreat);
            AddOwnMessage(Mc.PatientMakeEntranceTreat);
		}
		//meta! tag="end"
	}
}
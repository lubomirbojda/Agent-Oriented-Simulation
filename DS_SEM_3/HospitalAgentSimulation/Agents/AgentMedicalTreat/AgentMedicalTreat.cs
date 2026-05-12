using OSPABA;
using Simulation;
using Agents.AgentMedicalTreat.ContinualAssistants;
using DS_SEM_3.Generators.Empiric.Continuous;
using DS_SEM_3.Generators.Uniform;

namespace Agents.AgentMedicalTreat
{
	//meta! id="118"
	public class AgentMedicalTreat : OSPABA.Agent
	{
        public ContinuousEmpiric AlonePatientsMedicalTreatGen { get; private set; }
        public ContinuousUniform AmbulancePatientsMedicalTreatGen { get; private set; }

        public AgentMedicalTreat(int id, OSPABA.Simulation mySim, Agent parent) :
			base(id, mySim, parent)
		{
			Init();
			ResetGenerators();
        }

		private void ResetGenerators()
		{
            MySimulation sim = (MySimulation)MySim;
            AlonePatientsMedicalTreatGen = new(sim.SeedGenerator, [
                (10*60, 12*60, 0.1),
                (12*60, 14*60, 0.6),
                (14*60, 18*60, 0.3)
            ]);

            AmbulancePatientsMedicalTreatGen = new(sim.SeedGenerator, 15 * 60, 30 * 60);
        }

		override public void PrepareReplication()
		{
			base.PrepareReplication();
            ResetGenerators();
            // Setup component for the next replication
        }

		//meta! userInfo="Generated code: do not modify", tag="begin"
		private void Init()
		{
			new ManagerMedicalTreat(SimId.ManagerMedicalTreat, MySim, this);
			new ProcessMedicalTreat(SimId.ProcessMedicalTreat, MySim, this);
			AddOwnMessage(Mc.MedicalTreat);
			AddOwnMessage(Mc.PatientMakeMedicalTreat);
		}
		//meta! tag="end"
	}
}
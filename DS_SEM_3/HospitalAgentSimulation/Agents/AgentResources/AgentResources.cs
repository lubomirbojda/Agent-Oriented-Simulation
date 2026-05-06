using OSPABA;
using Simulation;
using DS_SEM_3.HospitalAgentSimulation.Entities;

namespace Agents.AgentResources
{
	//meta! id="108"
	public class AgentResources : OSPABA.Agent
	{
        public Resources<Nurse> Nurses { get; private set; } = new(12);
        public Resources<Doctor> Doctors { get; private set; } = new(8);
        public Resources<AmbulanceA> AmbulationsA { get; private set; } = new(5);
        public Resources<AmbulanceB> AmbulationsB { get; private set; } = new(7);


        public AgentResources(int id, OSPABA.Simulation mySim, Agent parent) :
			base(id, mySim, parent)
		{
			Init();
		}

		override public void PrepareReplication()
		{
			base.PrepareReplication();
            // Setup component for the next replication
            Nurses.ResetResources();
            Doctors.ResetResources();
            AmbulationsA.ResetResources();
            AmbulationsB.ResetResources();
        }

		//meta! userInfo="Generated code: do not modify", tag="begin"
		private void Init()
		{
			new ManagerResources(SimId.ManagerResources, MySim, this);
			AddOwnMessage(Mc.TryAssignResources);
		}
		//meta! tag="end"
    }
}
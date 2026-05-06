using OSPABA;
using Simulation;

namespace Agents.AgentMedicalTreat
{
	//meta! id="118"
	public class AgentMedicalTreat : OSPABA.Agent
	{
		public AgentMedicalTreat(int id, OSPABA.Simulation mySim, Agent parent) :
			base(id, mySim, parent)
		{
			Init();
		}

		override public void PrepareReplication()
		{
			base.PrepareReplication();
			// Setup component for the next replication
		}

		//meta! userInfo="Generated code: do not modify", tag="begin"
		private void Init()
		{
			new ManagerMedicalTreat(SimId.ManagerMedicalTreat, MySim, this);
			AddOwnMessage(Mc.MedicalTreat);
		}
		//meta! tag="end"
	}
}
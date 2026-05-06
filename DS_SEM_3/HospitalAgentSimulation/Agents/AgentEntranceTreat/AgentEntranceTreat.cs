using OSPABA;
using Simulation;

namespace Agents.AgentEntranceTreat
{
	//meta! id="117"
	public class AgentEntranceTreat : OSPABA.Agent
	{
		public AgentEntranceTreat(int id, OSPABA.Simulation mySim, Agent parent) :
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
			new ManagerEntranceTreat(SimId.ManagerEntranceTreat, MySim, this);
			AddOwnMessage(Mc.EntranceTreat);
		}
		//meta! tag="end"
	}
}
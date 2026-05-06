using OSPABA;
using Simulation;

namespace Agents.AgentEntranceTreat
{
	//meta! id="117"
	public class ManagerEntranceTreat : OSPABA.Manager
	{
		public ManagerEntranceTreat(int id, OSPABA.Simulation mySim, Agent myAgent) :
			base(id, mySim, myAgent)
		{
			Init();
		}

		override public void PrepareReplication()
		{
			base.PrepareReplication();
			// Setup component for the next replication

			if (PetriNet != null)
			{
				PetriNet.Clear();
			}
		}

		//meta! sender="AgentHospital", id="121", type="Request"
		public void ProcessEntranceTreat(MessageForm message)
		{
			var msg = message.CreateCopy();
            msg.Addressee = MyAgent.FindAssistant(SimId.ProcessEntranceTreat);
			StartContinualAssistant(msg);
		}

		//meta! userInfo="Process messages defined in code", id="0"
		public void ProcessDefault(MessageForm message)
		{
			switch (message.Code)
			{
			}
		}

		//meta! sender="ProcessEntranceTreat", id="134", type="Finish"
		public void ProcessFinish(MessageForm message)
		{
			message.Code = Mc.EntranceTreat;
			Response(message);
		}

		//meta! userInfo="Generated code: do not modify", tag="begin"
		public void Init()
		{
		}

		override public void ProcessMessage(MessageForm message)
		{
			switch (message.Code)
			{
			case Mc.EntranceTreat:
				ProcessEntranceTreat(message);
			break;

			case Mc.Finish:
				ProcessFinish(message);
			break;

			default:
				ProcessDefault(message);
			break;
			}
		}
		//meta! tag="end"
		public new AgentEntranceTreat MyAgent
		{
			get
			{
				return (AgentEntranceTreat)base.MyAgent;
			}
		}
	}
}
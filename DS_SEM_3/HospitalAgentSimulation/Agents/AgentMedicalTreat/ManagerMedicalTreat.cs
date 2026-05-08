using OSPABA;
using Simulation;

namespace Agents.AgentMedicalTreat
{
	//meta! id="118"
	public class ManagerMedicalTreat : OSPABA.Manager
	{
		public ManagerMedicalTreat(int id, OSPABA.Simulation mySim, Agent myAgent) :
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

		//meta! sender="AgentHospital", id="123", type="Request"
		public void ProcessMedicalTreat(MessageForm message)
		{
			var msg = message.CreateCopy();
            msg.Addressee = MyAgent.FindAssistant(SimId.ProcessMedicalTreat);
            StartContinualAssistant(msg);
        }

		//meta! userInfo="Process messages defined in code", id="0"
		public void ProcessDefault(MessageForm message)
		{
			switch (message.Code)
			{
			}
		}

		//meta! sender="ProcessMedicalTreat", id="136", type="Finish"
		public void ProcessFinish(MessageForm message)
		{
            message.Code = Mc.MedicalTreat;
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
			case Mc.Finish:
				ProcessFinish(message);
			break;

			case Mc.MedicalTreat:
				ProcessMedicalTreat(message);
			break;

			default:
				ProcessDefault(message);
			break;
			}
		}
		//meta! tag="end"
		public new AgentMedicalTreat MyAgent
		{
			get
			{
				return (AgentMedicalTreat)base.MyAgent;
			}
		}
	}
}
using OSPABA;
using Simulation;

namespace Agents.AgentHospital
{
	//meta! id="7"
	public class ManagerHospital : OSPABA.Manager
	{
		public ManagerHospital(int id, OSPABA.Simulation mySim, Agent myAgent) :
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

		//meta! sender="AgentBoss", id="62", type="Request"
		public void ProcessTreatPatient(MessageForm message)
		{
            message.Addressee = MyAgent.FindAssistant(SimId.ProcessMoveToEntranceSpace);
            StartContinualAssistant(message);
        }

		//meta! sender="ProcessEntranceTreat", id="66", type="Finish"
		public void ProcessFinishProcessEntranceTreat(MessageForm message)
		{
        }

		//meta! sender="ProcessMedicalTreat", id="68", type="Finish"
		public void ProcessFinishProcessMedicalTreat(MessageForm message)
		{
            message.Code = Mc.TreatPatient;
            Response(message);
        }

		//meta! sender="ProcessMoveToHospital", id="96", type="Finish"
		public void ProcessFinishProcessMoveToHospital(MessageForm message)
		{
		}

		//meta! sender="ProcessMoveToEntranceSpace", id="91", type="Finish"
		public void ProcessFinishProcessMoveToEntranceSpace(MessageForm message)
		{
		}

		//meta! userInfo="Process messages defined in code", id="0"
		public void ProcessDefault(MessageForm message)
		{
			switch (message.Code)
			{
			}
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
				switch (message.Sender.Id)
				{
				case SimId.ProcessEntranceTreat:
					ProcessFinishProcessEntranceTreat(message);
				break;

				case SimId.ProcessMedicalTreat:
					ProcessFinishProcessMedicalTreat(message);
				break;

				case SimId.ProcessMoveToHospital:
					ProcessFinishProcessMoveToHospital(message);
				break;

				case SimId.ProcessMoveToEntranceSpace:
					ProcessFinishProcessMoveToEntranceSpace(message);
				break;
				}
			break;

			case Mc.TreatPatient:
				ProcessTreatPatient(message);
			break;

			default:
				ProcessDefault(message);
			break;
			}
		}
		//meta! tag="end"
		public new AgentHospital MyAgent
		{
			get
			{
				return (AgentHospital)base.MyAgent;
			}
		}
	}
}

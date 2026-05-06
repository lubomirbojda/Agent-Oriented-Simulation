using OSPABA;
using Agents.AgentHospital;
using Simulation;

namespace Agents.AgentHospital.ContinualAssistants
{
	//meta! id="138"
	public class ProcessMoveToLeaveDoor : OSPABA.Process
	{
		public ProcessMoveToLeaveDoor(int id, OSPABA.Simulation mySim, CommonAgent myAgent) :
			base(id, mySim, myAgent)
		{
		}

		override public void PrepareReplication()
		{
			base.PrepareReplication();
			// Setup component for the next replication
		}

		//meta! sender="AgentHospital", id="139", type="Start"
		public void ProcessStart(MessageForm message)
		{
			message.Code = Mc.PatientMoveToLeaveDoor;
            var leaveTime = MyAgent.PatientMoveToLeaveDoorGen.GenerateNext();
            Hold(leaveTime, message);
        }

		//meta! userInfo="Process messages defined in code", id="0"
		public void ProcessDefault(MessageForm message)
		{
			switch (message.Code)
			{
                case Mc.PatientMoveToLeaveDoor:
                    AssistantFinished(message);
                    break;
            }
		}

		//meta! userInfo="Generated code: do not modify", tag="begin"
		override public void ProcessMessage(MessageForm message)
		{
			switch (message.Code)
			{
			case Mc.Start:
				ProcessStart(message);
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

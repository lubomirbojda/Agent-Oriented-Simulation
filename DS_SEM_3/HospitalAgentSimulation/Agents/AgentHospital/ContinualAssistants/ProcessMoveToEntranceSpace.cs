using OSPABA;
using Agents.AgentHospital;
using Simulation;

namespace Agents.AgentHospital.ContinualAssistants
{
	//meta! id="90"
	public class ProcessMoveToEntranceSpace : OSPABA.Process
	{
		public ProcessMoveToEntranceSpace(int id, OSPABA.Simulation mySim, CommonAgent myAgent) :
			base(id, mySim, myAgent)
		{
			MyAgent.AddOwnMessage(Mc.PatientMoveToEntranceSpace);
		}

		override public void PrepareReplication()
		{
			base.PrepareReplication();
			// Setup component for the next replication
		}

		//meta! sender="AgentHospital", id="91", type="Start"
		public void ProcessStart(MessageForm message)
		{
            MyMessage msg = (MyMessage)message;
            if (msg.Patient == null) return;

            message.Code = Mc.PatientMoveToEntranceSpace;
            double moveTime;
            if (msg.Patient.CameByAmbulance)
            {
                moveTime = MyAgent.AmbulancePatientsMoveToEntranceSpaceGen.GenerateNext();
            }
            else
            {
                moveTime = MyAgent.AlonePatientsMoveToEntranceSpaceGen.GenerateNext();
            }

            Hold(moveTime, message);
        }

		//meta! userInfo="Process messages defined in code", id="0"
		public void ProcessDefault(MessageForm message)
		{
			switch (message.Code)
			{
                case Mc.PatientMoveToEntranceSpace:
                    MyMessage msg = (MyMessage)message;
                    if (msg.Patient == null) return;
                    if (msg.Patient.CameByAmbulance)
                    {
                        MyAgent.QueueEntranceAmbulancePatients.Enqueue(msg.Patient);
                    }
                    else
                    {
                        MyAgent.QueueEntranceAlonePatients.Enqueue(msg.Patient);
                    }

					msg.Patient.TimeStartWaitingForEntranceTreat = MySim.CurrentTime;

					AssistantFinished(message);
                    //MyAgent.TryAssignResources(msg);
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
using OSPABA;
using Simulation;
using Agents.AgentMedicalTreat;

namespace Agents.AgentMedicalTreat.ContinualAssistants
{
	//meta! id="135"
	public class ProcessMedicalTreat : OSPABA.Process
	{
		public ProcessMedicalTreat(int id, OSPABA.Simulation mySim, CommonAgent myAgent) :
			base(id, mySim, myAgent)
		{
		}

		override public void PrepareReplication()
		{
			base.PrepareReplication();
			// Setup component for the next replication
		}

		//meta! sender="AgentMedicalTreat", id="136", type="Start"
		public void ProcessStart(MessageForm message)
		{
            MyMessage msg = (MyMessage)message;
            if (msg.Patient == null) return;

            message.Code = Mc.PatientMakeMedicalTreat;
            double moveTime;
            if (msg.Patient.CameByAmbulance)
            {
                moveTime = MyAgent.AmbulancePatientsMedicalTreatGen.GenerateNext();
            }
            else
            {
                moveTime = MyAgent.AlonePatientsMedicalTreatGen.GenerateNext();
            }

            Hold(moveTime, message);
        }

		//meta! userInfo="Process messages defined in code", id="0"
		public void ProcessDefault(MessageForm message)
		{
			switch (message.Code)
			{
                case Mc.PatientMakeMedicalTreat:
                    MyMessage msg = (MyMessage)message;
                    if (msg.Patient == null) return;
                    msg.Patient.UnassignResources();
                    AssistantFinished(message);

                    //message.Code = Mc.PatientMoveToLeaveDoor;
                    //var leaveTime = MyAgent.PatientMoveToLeaveDoorGen.GenerateNext();
                    //Hold(leaveTime, message);
                    break;
                //case Mc.PatientMoveToLeaveDoor:
                    
                //    break;
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
		public new AgentMedicalTreat MyAgent
		{
			get
			{
				return (AgentMedicalTreat)base.MyAgent;
			}
		}
	}
}
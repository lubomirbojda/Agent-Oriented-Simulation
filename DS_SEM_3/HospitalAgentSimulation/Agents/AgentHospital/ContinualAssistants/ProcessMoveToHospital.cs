using OSPABA;
using Agents.AgentHospital;
using Simulation;

namespace Agents.AgentHospital.ContinualAssistants
{
	//meta! id="95"
	public class ProcessMoveToHospital : OSPABA.Process
	{
		public ProcessMoveToHospital(int id, OSPABA.Simulation mySim, CommonAgent myAgent) :
			base(id, mySim, myAgent)
		{
            MyAgent.AddOwnMessage(Mc.MoveToAmbulance);
        }

		override public void PrepareReplication()
		{
			base.PrepareReplication();
			// Setup component for the next replication
		}

		//meta! sender="AgentHospital", id="96", type="Start"
		public void ProcessStart(MessageForm message)
		{
            MyMessage msg = (MyMessage)message.CreateCopy();
            if (msg.Patient == null) return;

            if (!msg.Patient.HasEntranceTreatDone)
            {
                msg.Patient.WaitingForEntranceTreat = MySim.CurrentTime - msg.Patient.TimeStartWaitingForEntranceTreat;
            }
            else
            {
				msg.Patient.WaitingForMedicalTreat = MySim.CurrentTime - msg.Patient.TimeStartWaitingForMedicalTreat;
            }

            double moveTime = MyAgent.MoveToAmbulanceGen.GenerateNext();
			message.Code = Mc.MoveToAmbulance;
            Hold(moveTime, message);
        }

		//meta! userInfo="Process messages defined in code", id="0"
		public void ProcessDefault(MessageForm message)
		{
			switch (message.Code)
			{
				case Mc.MoveToAmbulance:
                    MyMessage msg = (MyMessage)message.CreateCopy();
                    if (msg.Patient == null) return;
					if (!msg.Patient.HasEntranceTreatDone)
					{
                        msg.Addressee = MyAgent.FindAssistant(SimId.ProcessEntranceTreat);
                        MyAgent.MyManager.StartContinualAssistant(msg);
					}
					else
					{
                        msg.Addressee = MyAgent.FindAssistant(SimId.ProcessMedicalTreat);
                        MyAgent.MyManager.StartContinualAssistant(msg);
                    }

					
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

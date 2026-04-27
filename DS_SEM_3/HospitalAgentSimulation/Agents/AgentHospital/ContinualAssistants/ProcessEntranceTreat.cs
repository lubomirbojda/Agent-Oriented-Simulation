using OSPABA;
using Agents.AgentHospital;
using Simulation;

namespace Agents.AgentHospital.ContinualAssistants
{
	//meta! id="65"
	public class ProcessEntranceTreat : OSPABA.Process
	{
		public ProcessEntranceTreat(int id, OSPABA.Simulation mySim, CommonAgent myAgent) :
			base(id, mySim, myAgent)
		{
            MyAgent.AddOwnMessage(Mc.PatientMakeEntranceTreat);
        }

		override public void PrepareReplication()
		{
			base.PrepareReplication();
			// Setup component for the next replication
		}

		//meta! sender="AgentHospital", id="66", type="Start"
		public void ProcessStart(MessageForm message)
		{
			MyMessage msg = (MyMessage)message;
			if (msg.Patient == null) return;

            message.Code = Mc.PatientMakeEntranceTreat;
            double moveTime;
            if (msg.Patient.CameByAmbulance)
            {
                moveTime = MyAgent.AmbulancePatientsEntranceTreatGen.GenerateNext();
            }
            else
            {
                moveTime = MyAgent.AlonePatientsEntranceTreatGen.GenerateNext();
            }

			Hold(moveTime, message);
        }

		//meta! userInfo="Process messages defined in code", id="0"
		public void ProcessDefault(MessageForm message)
		{
			switch (message.Code)
			{
				case Mc.PatientMakeEntranceTreat:
                    MyMessage msg = (MyMessage)message;
                    if (msg.Patient == null) return;
                    var priority = msg.Patient.Priority;
                    if (priority == 1 || priority == 2)
                    {
                        MyAgent.EnqueuePatientAmbulanceA(msg.Patient, msg.Patient.Priority);
                    }
                    else if (priority == 3 || priority == 4)
                    {
                        MyAgent.EnqueuePatientAmbulanceA(msg.Patient, msg.Patient.Priority);
                        MyAgent.EnqueuePatientAmbulanceB(msg.Patient, msg.Patient.Priority);
                    }
                    else
                    {
                        MyAgent.EnqueuePatientAmbulanceB(msg.Patient, msg.Patient.Priority);
                    }

                    msg.Patient.UnassignResources();
					msg.Patient.HasEntranceTreatDone = true;
					AssistantFinished(message);
                    MyAgent.TryAssignResources(msg);
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

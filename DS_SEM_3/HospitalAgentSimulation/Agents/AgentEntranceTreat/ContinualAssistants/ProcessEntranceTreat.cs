using OSPABA;
using Simulation;
using Agents.AgentEntranceTreat;

namespace Agents.AgentEntranceTreat.ContinualAssistants
{
	//meta! id="133"
	public class ProcessEntranceTreat : OSPABA.Process
	{
		public ProcessEntranceTreat(int id, OSPABA.Simulation mySim, CommonAgent myAgent) :
			base(id, mySim, myAgent)
		{
		}

		override public void PrepareReplication()
		{
			base.PrepareReplication();
			// Setup component for the next replication
		}

		//meta! sender="AgentEntranceTreat", id="134", type="Start"
		public void ProcessStart(MessageForm message)
		{
            MyMessage msg = (MyMessage)message;
            if (msg.Patient == null) return;

            message.Code = Mc.PatientMakeEntranceTreat;
            double time;
            if (msg.Patient.CameByAmbulance)
            {
                time = MyAgent.AmbulancePatientsEntranceTreatGen.GenerateNext();
            }
            else
            {
                time = MyAgent.AlonePatientsEntranceTreatGen.GenerateNext();
            }

            Hold(time, message);
        }

		//meta! userInfo="Process messages defined in code", id="0"
		public void ProcessDefault(MessageForm message)
		{
			switch (message.Code)
			{
                case Mc.PatientMakeEntranceTreat:
                    MyMessage msg = (MyMessage)message;
                    if (msg.Patient == null) return;

                    if (msg.Patient.CameByAmbulance)
                    {
                        msg.Patient.Priority = MyAgent.AmbulancePatientsPriorityGen.GenerateNext();
                    }
                    else
                    {
                        msg.Patient.Priority = MyAgent.AlonePatientsPriorityGen.GenerateNext();
                    }

                    var priority = msg.Patient.Priority;
                    if (priority == 1 || priority == 2)
                    {
                        msg.QueuesAmbulances.EnqueuePatientAmbulanceA(msg.Patient, msg.Patient.Priority);
                    }
                    else if (priority == 3 || priority == 4)
                    {
                        msg.QueuesAmbulances.EnqueuePatientAmbulanceA(msg.Patient, msg.Patient.Priority);
                        msg.QueuesAmbulances.EnqueuePatientAmbulanceB(msg.Patient, msg.Patient.Priority);
                    }
                    else
                    {
                        msg.QueuesAmbulances.EnqueuePatientAmbulanceB(msg.Patient, msg.Patient.Priority);
                    }

                    MyMessage msgP = (MyMessage)message;
                    if (MySim.AnimatorExists)
                    {
                        msgP.Patient?.AssignedNurse?.MainAnimShapeItem.SetVisible(false);
                    }
                    msg.Patient.UnassignResources();
                    


                    msg.Patient.HasEntranceTreatDone = true;
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
		public new AgentEntranceTreat MyAgent
		{
			get
			{
				return (AgentEntranceTreat)base.MyAgent;
			}
		}
	}
}
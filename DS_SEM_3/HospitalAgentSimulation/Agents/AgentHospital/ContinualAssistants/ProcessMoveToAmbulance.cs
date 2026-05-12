using OSPABA;
using Agents.AgentHospital;
using Simulation;

namespace Agents.AgentHospital.ContinualAssistants
{
	//meta! id="95"
	public class ProcessMoveToAmbulance : OSPABA.Process
	{
		public ProcessMoveToAmbulance(int id, OSPABA.Simulation mySim, CommonAgent myAgent) :
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
            MyMessage msg = (MyMessage)message;
            if (msg.Patient == null || msg.Patient.AssignedNurse == null) return;
			var assNurse = msg.Patient.AssignedNurse;
			var assDoctor = msg.Patient.AssignedDoctor;
			double nurseMoveTime = 0;
			double doctorMoveTime = 0;

            if (!msg.Patient.HasEntranceTreatDone)
            {
				msg.Patient.WaitingForEntranceTreat = MySim.CurrentTime - msg.Patient.ArrivalTime;
                if (assNurse.ActualAmbulance != assNurse.LastAmbulance)
					nurseMoveTime = MyAgent.NurseMoveToAmbulanceGen.GenerateNext();	
				
                msg.Code = Mc.MoveToAmbulance;
                Hold(nurseMoveTime, msg);
                return;
            }
            else
            {
				if (assDoctor == null) return;
                msg.Patient.WaitingForMedicalTreat = MySim.CurrentTime - msg.Patient.ArrivalTime;

                if (assNurse.ActualAmbulance != assNurse.LastAmbulance)
                    nurseMoveTime = MyAgent.NurseMoveToAmbulanceGen.GenerateNext();

				if (assDoctor.ActualAmbulance != assDoctor.LastAmbulance)
					doctorMoveTime = MyAgent.DoctorMoveToAmbulanceGen.GenerateNext();

				var higherMoveTime = Math.Max(doctorMoveTime, nurseMoveTime);
                msg.Code = Mc.MoveToAmbulance;
                Hold(higherMoveTime, msg);
                return;
            }
        }

		//meta! userInfo="Process messages defined in code", id="0"
		public void ProcessDefault(MessageForm message)
		{
            switch (message.Code)
            {
                case Mc.MoveToAmbulance:
                    MyMessage msg = (MyMessage)message;
                    if (msg.Patient == null) return;
					msg.Patient.CanStartTreat = true;

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
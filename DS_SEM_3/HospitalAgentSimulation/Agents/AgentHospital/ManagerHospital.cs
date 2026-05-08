using DS_SEM_3.HospitalAgentSimulation.Entities;
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
			MyMessage msg = (MyMessage)message;
			if (msg.Patient != null)
				MyAgent.PatientsInHospital.Add(msg.Patient);

            message.Addressee = MyAgent.FindAssistant(SimId.ProcessMoveToEntranceSpace);
            StartContinualAssistant(message);
        }

		//meta! userInfo="Removed from model"
		public void ProcessFinishProcessEntranceTreat(MessageForm message)
		{
        }

		//meta! userInfo="Removed from model"
		public void ProcessFinishProcessMedicalTreat(MessageForm message)
		{
			MyMessage msg = (MyMessage)message;
			if (msg.Patient != null)
				MyAgent.PatientsInHospital.Remove(msg.Patient);

            message.Code = Mc.TreatPatient;
            Response(message);
        }

		//meta! sender="ProcessMoveToAmbulance", id="96", type="Finish"
		public void ProcessFinishProcessMoveToAmbulance(MessageForm message)
        {
			MyMessage msg = (MyMessage)message;
            if (msg.Patient == null) return;

			if (!msg.Patient.HasEntranceTreatDone)
			{
				msg.Code = Mc.EntranceTreat;
                msg.Addressee = MySim.FindAgent(SimId.AgentEntranceTreat);
            }
			else
			{
				msg.Code = Mc.MedicalTreat;
                msg.Addressee = MySim.FindAgent(SimId.AgentMedicalTreat);
            }

			Request(msg);
        }

		//meta! sender="ProcessMoveToEntranceSpace", id="91", type="Finish"
		public void ProcessFinishProcessMoveToEntranceSpace(MessageForm message)
		{
            MyMessage msg = (MyMessage)message;
			msg.QueuesAmbulances = MyAgent.QueuesAmbulances;
			msg.QueueEntrancePatients = MyAgent.QueueEntrancePatients;
            msg.Code = Mc.TryAssignResources;
            msg.Addressee = MySim.FindAgent(SimId.AgentResources);
            Notice(msg);
        }

		//meta! userInfo="Process messages defined in code", id="0"
		public void ProcessDefault(MessageForm message)
		{
			switch (message.Code)
			{
			}
		}

		//meta! userInfo="Removed from model"
		public void ProcessTryAssignResources(MessageForm message)
		{
		}

		//meta! sender="AgentEntranceTreat", id="121", type="Response"
		public void ProcessEntranceTreat(MessageForm message)
		{
            message.Code = Mc.TryAssignResources;
            message.Addressee = MySim.FindAgent(SimId.AgentResources);
            Notice(message);
        }

		//meta! sender="AgentMedicalTreat", id="123", type="Response"
		public void ProcessMedicalTreat(MessageForm message)
		{
            message.Code = Mc.TryAssignResources;
            message.Addressee = MySim.FindAgent(SimId.AgentResources);
            Notice(message);

			var msg = message.CreateCopy();
            msg.Addressee = MyAgent.FindAssistant(SimId.ProcessMoveToLeaveDoor);
            StartContinualAssistant(msg);
        }

		//meta! sender="AgentResources", id="127", type="Notice"
		public void ProcessResourcesAssigned(MessageForm message)
		{
            MyMessage msg = (MyMessage)message;
			if (msg.Patient == null) return;

			var msgCopy = msg.CreateCopy();
			msgCopy.Addressee = MyAgent.FindAssistant(SimId.ProcessMoveToAmbulance);
			StartContinualAssistant(msgCopy);

			//message.Code = Mc.TryAssignResources;
			//message.Addressee = MySim.FindAgent(SimId.AgentResources);
			//Notice(message);
		}

		//meta! sender="ProcessMoveToLeaveDoor", id="139", type="Finish"
		public void ProcessFinishProcessMoveToLeaveDoor(MessageForm message)
		{
            MyMessage msg = (MyMessage)message;
            if (msg.Patient != null)
                MyAgent.PatientsInHospital.Remove(msg.Patient);

            message.Code = Mc.TreatPatient;
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

			case Mc.TreatPatient:
				ProcessTreatPatient(message);
			break;

			case Mc.ResourcesAssigned:
				ProcessResourcesAssigned(message);
			break;

			case Mc.Finish:
				switch (message.Sender.Id)
				{
				case SimId.ProcessMoveToAmbulance:
					ProcessFinishProcessMoveToAmbulance(message);
				break;

				case SimId.ProcessMoveToEntranceSpace:
					ProcessFinishProcessMoveToEntranceSpace(message);
				break;

				case SimId.ProcessMoveToLeaveDoor:
					ProcessFinishProcessMoveToLeaveDoor(message);
				break;
				}
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
		public new AgentHospital MyAgent
		{
			get
			{
				return (AgentHospital)base.MyAgent;
			}
		}

        private void StartMoveToAmbulance(Patient patient, MessageForm message)
        {
            MyMessage msg = (MyMessage)message.CreateCopy();
            msg.Patient = patient;
            msg.Addressee = MyAgent.FindAssistant(SimId.ProcessMoveToAmbulance);
            StartContinualAssistant(msg);
        }
    }
}
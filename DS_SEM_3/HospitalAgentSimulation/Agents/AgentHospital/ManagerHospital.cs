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
        }

		//meta! sender="ProcessMoveToEntranceSpace", id="91", type="Finish"
		public void ProcessFinishProcessMoveToEntranceSpace(MessageForm message)
		{
            message.Code = Mc.TryAssignResources;
            message.Addressee = MySim.FindAgent(SimId.AgentResources);
            Request(message);
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
		}

		//meta! sender="AgentMedicalTreat", id="123", type="Response"
		public void ProcessMedicalTreat(MessageForm message)
		{
		}

		//meta! sender="AgentResources", id="127", type="Notice"
		public void ProcessResourcesAssigned(MessageForm message)
		{

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

			case Mc.Finish:
				switch (message.Sender.Id)
				{
				case SimId.ProcessMoveToEntranceSpace:
					ProcessFinishProcessMoveToEntranceSpace(message);
				break;

				case SimId.ProcessMoveToAmbulance:
					ProcessFinishProcessMoveToAmbulance(message);
				break;
				}
			break;

			case Mc.ResourcesAssigned:
				ProcessResourcesAssigned(message);
			break;

			case Mc.MedicalTreat:
				ProcessMedicalTreat(message);
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

        private void StartMoveToAmbulance(Patient patient, MessageForm message)
        {
            MyMessage msg = (MyMessage)message.CreateCopy();
            msg.Patient = patient;
            msg.Addressee = MyAgent.FindAssistant(SimId.ProcessMoveToAmbulance);
            StartContinualAssistant(msg);
        }
    }
}
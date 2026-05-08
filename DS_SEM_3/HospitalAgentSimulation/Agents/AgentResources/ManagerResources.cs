using DS_SEM_3.HospitalAgentSimulation.Entities;
using OSPABA;
using OSPAnimatorGIS;
using Simulation;

namespace Agents.AgentResources
{
	//meta! id="108"
	public class ManagerResources : OSPABA.Manager
	{
		public ManagerResources(int id, OSPABA.Simulation mySim, Agent myAgent) :
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

		//meta! userInfo="Process messages defined in code", id="0"
		public void ProcessDefault(MessageForm message)
		{
			switch (message.Code)
			{
			}
		}

		//meta! sender="AgentHospital", id="126", type="Notice"
		public void ProcessTryAssignResources(MessageForm message)
		{
            MyMessage msg = (MyMessage)message;
            TryAssignResources(msg);
        }

		//meta! userInfo="Generated code: do not modify", tag="begin"
		public void Init()
		{
		}

		override public void ProcessMessage(MessageForm message)
		{
			switch (message.Code)
			{
			case Mc.TryAssignResources:
				ProcessTryAssignResources(message);
			break;

			default:
				ProcessDefault(message);
			break;
			}
		}
		//meta! tag="end"
		public new AgentResources MyAgent
		{
			get
			{
				return (AgentResources)base.MyAgent;
			}
		}

        private void AssignedResources(Patient patient, MyMessage message)
        {
			var msg = (MyMessage)message.CreateCopy();
            msg.Patient = patient;
            msg.Code = Mc.ResourcesAssigned;
            msg.Addressee = MySim.FindAgent(SimId.AgentHospital);
            Notice(msg);
        }

        private void TryAssignResources(MyMessage message)
        {
            bool assigned = true;

            // Cyklus beží, kým sa nám v predchádzajúcom kroku podarilo niekoho priradiť
            while (assigned)
            {
                assigned = false;

                // Skúsime získať aktuálne voľné zdroje v tejto iterácii
                var nurse = MyAgent.Nurses.TryGetFreeResource();
                var doctor = MyAgent.Doctors.TryGetFreeResource();
                var ambA = MyAgent.AmbulationsA.TryGetFreeResource();
                var ambB = MyAgent.AmbulationsB.TryGetFreeResource();

                var queueAmbA = message.QueuesAmbulances.QueueAmbulanceA;
                var queueAmbB = message.QueuesAmbulances.QueueAmbulanceB;

                // 1. Skúsime obslúžiť pacientov z radu A (Priority 1, 2, 3, 4)
                if (queueAmbA.Count > 0 && nurse != null && doctor != null && ambA != null)
                {
                    var patient = message.QueuesAmbulances.DequeuePatientAmbulanceA();
                    patient.AssignResources(nurse, ambA, doctor);
                    AssignedResources(patient, message);
                    assigned = true;
                    continue; // Skočíme na začiatok cyklu, pre načítanie nových voľných zdrojov
                }

                // 2. Skúsime obslúžiť pacientov z radu B (Priority 3, 4, 5)
                if (queueAmbB.Count > 0 && nurse != null && doctor != null && ambB != null)
                {
                    var patient = message.QueuesAmbulances.DequeuePatientAmbulanceB();
                    patient.AssignResources(nurse, ambB, doctor);
                    AssignedResources(patient, message);
                    assigned = true;
                    continue;
                }

                // 3. Skúsime obslúžiť pacientov na Vstupnom vyšetrení
                if (message.QueueEntrancePatients.GetCount() > 0 && nurse != null && ambB != null)
                {
                    var patient = message.QueueEntrancePatients.Dequeue();
                    patient.AssignResources(nurse, ambB);
                    AssignedResources(patient, message);
                    assigned = true;
                    continue;
                }
            }
        }
    }
}
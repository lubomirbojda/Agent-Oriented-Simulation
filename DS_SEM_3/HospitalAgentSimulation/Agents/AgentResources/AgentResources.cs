using DS_SEM_3.HospitalAgentSimulation.Entities;
using OSPABA;
using Simulation;

namespace Agents.AgentResources
{
	//meta! id="108"
	public class AgentResources : OSPABA.Agent
	{
        public Resources<Nurse> Nurses { get; private set; } = new(12);
        public Resources<Doctor> Doctors { get; private set; } = new(8);
        public Resources<AmbulanceA> AmbulationsA { get; private set; } = new(5);
        public Resources<AmbulanceB> AmbulationsB { get; private set; } = new(7);


        public AgentResources(int id, OSPABA.Simulation mySim, Agent parent) :
			base(id, mySim, parent)
		{
			Init();
		}

		override public void PrepareReplication()
		{
			base.PrepareReplication();
            // Setup component for the next replication
            Nurses.ResetResources();
            Doctors.ResetResources();
            AmbulationsA.ResetResources();
            AmbulationsB.ResetResources();
        }

		//meta! userInfo="Generated code: do not modify", tag="begin"
		private void Init()
		{
			new ManagerResources(SimId.ManagerResources, MySim, this);
			AddOwnMessage(Mc.TryAssignResources);
		}
        //meta! tag="end"

        private void StartMoveToAmbulance(Patient patient, MessageForm message)
        {
            MyMessage msg = (MyMessage)message.CreateCopy();
            msg.Patient = patient;
            msg.Addressee = FindAssistant(SimId.ProcessMoveToAmbulance);
            MyManager.StartContinualAssistant(msg);
        }

        private void TryAssignResources(MessageForm message)
        {
            var nurse = Nurses.TryGetFreeResource();
            var doctor = Doctors.TryGetFreeResource();
            var ambA = AmbulationsA.TryGetFreeResource();
            var ambB = AmbulationsB.TryGetFreeResource();

            if (QueueAmbulanceA.Count > 0)
            {
                if (nurse != null && doctor != null && ambA != null)
                {
                    var patient = DequeuePatientAmbulanceA();
                    patient.AssignResources(nurse, ambA, doctor);
                    StartMoveToAmbulance(patient, message);
                    return;
                }
            }
            if (QueueAmbulanceB.Count > 0)
            {
                if (nurse != null && doctor != null && ambB != null)
                {
                    var patient = DequeuePatientAmbulanceB();
                    patient.AssignResources(nurse, ambB, doctor);
                    StartMoveToAmbulance(patient, message);
                    return;
                }
            }
            if (QueueEntranceAmbulancePatients.Count > 0)
            {
                if (nurse != null && ambB != null)
                {
                    var patient = QueueEntranceAmbulancePatients.Dequeue();
                    patient.AssignResources(nurse, ambB);
                    StartMoveToAmbulance(patient, message);
                    return;
                }
            }
            if (QueueEntranceAlonePatients.Count > 0)
            {
                if (nurse != null && ambB != null)
                {
                    var patient = QueueEntranceAlonePatients.Dequeue();
                    patient.AssignResources(nurse, ambB);
                    StartMoveToAmbulance(patient, message);
                    return;
                }
            }
        }
    }
}
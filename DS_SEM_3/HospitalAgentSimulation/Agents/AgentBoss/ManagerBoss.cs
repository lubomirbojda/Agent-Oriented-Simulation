using OSPABA;
using Simulation;

namespace Agents.AgentBoss
{
    //meta! id="1"
    public class ManagerBoss : OSPABA.Manager
    {
        public ManagerBoss(int id, OSPABA.Simulation mySim, Agent myAgent) :
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

		//meta! sender="AgentHospital", id="62", type="Response"
		public void ProcessTreatPatient(MessageForm message)
        {
            message.Code = Mc.PatientLeave;
            message.Addressee = MySim.FindAgent(SimId.AgentEnviroment);
            Notice(message);
        }

		//meta! sender="AgentEnviroment", id="52", type="Notice"
		public void ProcessPatientArrival(MessageForm message)
        {
            message.Code = Mc.TreatPatient;
            message.Addressee = MySim.FindAgent(SimId.AgentHospital);
            Request(message);
        }

		//meta! userInfo="Process messages defined in code", id="0"
		public void ProcessDefault(MessageForm message)
        {
            switch (message.Code)
            {
            }
        }

		//meta! userInfo="Generated code: do not modify", tag="begin"
		public void Init()
		{
		}

		override public void ProcessMessage(MessageForm message)
		{
			switch (message.Code)
			{
			case Mc.TreatPatient:
				ProcessTreatPatient(message);
			break;

			case Mc.PatientArrival:
				ProcessPatientArrival(message);
			break;

			default:
				ProcessDefault(message);
			break;
			}
		}
		//meta! tag="end"
        public new AgentBoss MyAgent
        {
            get
            {
                return (AgentBoss)base.MyAgent;
            }
        }
    }
}
using OSPABA;
using Simulation;
using System.Reflection.Metadata;

namespace Agents.AgentEnviroment
{
    //meta! id="3"
    public class ManagerEnviroment : OSPABA.Manager
    {
        public ManagerEnviroment(int id, OSPABA.Simulation mySim, Agent myAgent) :
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

		//meta! sender="SchedulerAmbulancePatientArrival", id="50", type="Notice"
		public void ProcessPatientArrivedSchedulerAmbulancePatientArrival(MessageForm message)
        {
            ProcessPatientArrived(message);
        }

		//meta! sender="SchedulerAlonePatientArrival", id="83", type="Notice"
		public void ProcessPatientArrivedSchedulerAlonePatientArrival(MessageForm message)
        {
            ProcessPatientArrived(message);
        }

        private void ProcessPatientArrived(MessageForm message)
        {
            message.Code = Mc.PatientArrival;
            message.Addressee = MySim.FindAgent(SimId.AgentBoss);
            Notice(message);
        }

		//meta! sender="SchedulerAlonePatientArrival", id="82", type="Finish"
		public void ProcessFinishSchedulerAlonePatientArrival(MessageForm message)
        {
        }

		//meta! sender="SchedulerAmbulancePatientArrival", id="49", type="Finish"
		public void ProcessFinishSchedulerAmbulancePatientArrival(MessageForm message)
        {
        }

		//meta! sender="AgentBoss", id="60", type="Notice"
		public void ProcessPatientLeave(MessageForm message)
        {
            //MyMessage msg = (MyMessage)message;
            MySimulation sim = (MySimulation)MySim;
            var msg = (MyMessage)message;
            if (msg.Patient == null) return;
            var timeInSystem = sim.CurrentTime - msg.Patient.ArrivalTime;
            sim.PatientsFinished++;
            MyAgent.AverageTimeInSystem.Add(timeInSystem);
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
			case Mc.PatientArrived:
				switch (message.Sender.Id)
				{
				case SimId.SchedulerAlonePatientArrival:
					ProcessPatientArrivedSchedulerAlonePatientArrival(message);
				break;

				case SimId.SchedulerAmbulancePatientArrival:
					ProcessPatientArrivedSchedulerAmbulancePatientArrival(message);
				break;
				}
			break;

			case Mc.Finish:
				switch (message.Sender.Id)
				{
				case SimId.SchedulerAlonePatientArrival:
					ProcessFinishSchedulerAlonePatientArrival(message);
				break;

				case SimId.SchedulerAmbulancePatientArrival:
					ProcessFinishSchedulerAmbulancePatientArrival(message);
				break;
				}
			break;

			case Mc.PatientLeave:
				ProcessPatientLeave(message);
			break;

			default:
				ProcessDefault(message);
			break;
			}
		}
		//meta! tag="end"
        public new AgentEnviroment MyAgent
        {
            get
            {
                return (AgentEnviroment)base.MyAgent;
            }
        }
    }
}
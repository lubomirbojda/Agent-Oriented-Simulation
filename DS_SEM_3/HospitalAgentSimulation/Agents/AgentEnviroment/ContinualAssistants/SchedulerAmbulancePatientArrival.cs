using Agents.AgentEnviroment;
using DS_SEM_3.HospitalAgentSimulation.Entities;
using OSPABA;
using Simulation;

namespace Agents.AgentEnviroment.ContinualAssistants
{
    //meta! id="48"
    public class SchedulerAmbulancePatientArrival : OSPABA.Scheduler
    {
        public SchedulerAmbulancePatientArrival(int id, OSPABA.Simulation mySim, CommonAgent myAgent) :
            base(id, mySim, myAgent)
        {
        }

        override public void PrepareReplication()
        {
            base.PrepareReplication();
            // Setup component for the next replication
        }

        //meta! sender="AgentEnviroment", id="49", type="Start"
        public void ProcessStart(MessageForm message)
        {
            AgentEnviroment sender = (AgentEnviroment)message.Sender;

            MyMessage msgCopy = (MyMessage)message.CreateCopy();
            msgCopy.Code = Mc.PatientArrived;

            Hold(sender.AmbulancePatientGen.GenerateNext(), msgCopy);
        }

        //meta! userInfo="Process messages defined in code", id="0"
        public void ProcessDefault(MessageForm message)
        {
            switch (message.Code)
            {
                case Mc.PatientArrived:
                    //AgentEnviroment sender = (AgentEnviroment)message.Sender;
                    Hold(MyAgent.AmbulancePatientGen.GenerateNext(), message.CreateCopy());

                    MyMessage msg = (MyMessage)message;
                    msg.Patient = new Patient(true, MySim.CurrentTime, 
                        MyAgent.PatientsIdSeq++);
                    msg.Addressee = MyAgent;

                    Notice(msg);

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
        public new AgentEnviroment MyAgent
        {
            get
            {
                return (AgentEnviroment)base.MyAgent;
            }
        }
    }
}

using DS_SEM_3.HospitalAgentSimulation.Entities;
using OSPABA;

namespace Simulation
{
    public class MyMessage : OSPABA.MessageForm
    {
        public Patient? Patient { get; set; }
        public Queue<Patient> QueueEntranceAmbulancePatients { get; set; } = new();
        public Queue<Patient> QueueEntranceAlonePatients { get; set; } = new();
        public PriorityQueuesAmbulances QueuesAmbulances { get; set; } = new();


        public MyMessage(OSPABA.Simulation mySim) :
            base(mySim)
        {
            Patient = null;
        }

        public MyMessage(MyMessage original) :
            base(original)
        {
            // copy() is called in superclass
        }

        override public MessageForm CreateCopy()
        {
            return new MyMessage(this);
        }

        override protected void Copy(MessageForm message)
        {
            base.Copy(message);
            MyMessage original = (MyMessage)message;
            // Copy attributes
            Patient = original.Patient;
            QueueEntranceAlonePatients = original.QueueEntranceAlonePatients;
            QueueEntranceAmbulancePatients = original.QueueEntranceAmbulancePatients;
            QueuesAmbulances = original.QueuesAmbulances;
        }
    }
}
using OSPABA;
using Simulation;
using Agents.AgentEnviroment.ContinualAssistants;
using DS_SEM_3.Generators.Empiric.Discrete;
using DS_SEM_3.Generators.Exponential;

namespace Agents.AgentEnviroment
{
    //meta! id="3"
    public class AgentEnviroment : OSPABA.Agent
    {
        public ExponentialDist AmbulancePatientGen { get; private set; }
        public ExponentialDist AlonePatientGen { get; private set; }

        public int PatientsIdSeq { get; set; } = 0;

        public AgentEnviroment(int id, OSPABA.Simulation mySim, Agent parent) :
            base(id, mySim, parent)
        {
            Init();
            MySimulation sim = (MySimulation)MySim;
            AmbulancePatientGen = new(sim.SeedGenerator, 1 / 15d);
            AlonePatientGen = new(sim.SeedGenerator, 1 / 15d);
        }

        override public void PrepareReplication()
        {
            base.PrepareReplication();
            // Setup component for the next replication
            MySimulation sim = (MySimulation)MySim;
            AmbulancePatientGen = new(sim.SeedGenerator, 1 / 180d);
            AlonePatientGen = new(sim.SeedGenerator, 1 / 120d);

            //Start schedulers for patients arrival
            MyMessage messsage = new(MySim);
            messsage.Addressee = FindAssistant(SimId.SchedulerAlonePatientArrival);
            MyManager.StartContinualAssistant(messsage);

            messsage = new(MySim);
            messsage.Addressee = FindAssistant(SimId.SchedulerAmbulancePatientArrival);
            MyManager.StartContinualAssistant(messsage);

            PatientsIdSeq = 0;
        }

		//meta! userInfo="Generated code: do not modify", tag="begin"
		private void Init()
		{
			new ManagerEnviroment(SimId.ManagerEnviroment, MySim, this);
			new SchedulerAlonePatientArrival(SimId.SchedulerAlonePatientArrival, MySim, this);
			new SchedulerAmbulancePatientArrival(SimId.SchedulerAmbulancePatientArrival, MySim, this);
			AddOwnMessage(Mc.PatientArrived);
			AddOwnMessage(Mc.PatientLeave);
		}
		//meta! tag="end"
    }
}
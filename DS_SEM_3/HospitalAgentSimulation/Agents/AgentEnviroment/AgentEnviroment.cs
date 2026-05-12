using OSPABA;
using Simulation;
using Agents.AgentEnviroment.ContinualAssistants;
using DS_SEM_3.Generators.Empiric.Discrete;
using DS_SEM_3.Generators.Exponential;
using DS_SEM_3.Statistics;
using DS_SEM_3.Generators.Erlang;

namespace Agents.AgentEnviroment
{
    //meta! id="3"
    public class AgentEnviroment : OSPABA.Agent
    {
        public ErlangDist AmbulancePatientGen { get; private set; }
        public ExponentialDist AlonePatientGen { get; private set; }

        public int PatientsIdSeq { get; set; } = 0;

        public SimpleStatistics AverageTimeInSystemAll { get; private set; } = new();
        public SimpleStatistics AverageTimeInSystemAlone { get; set; } = new();
        public SimpleStatistics AverageTimeInSystemAmbulance { get; set; } = new();

        public AgentEnviroment(int id, OSPABA.Simulation mySim, Agent parent) :
            base(id, mySim, parent)
        {
            Init();
            MySimulation sim = (MySimulation)MySim;
            AmbulancePatientGen = new(sim.SeedGenerator, 7, 1.0 / (0.836d * 60));
            AlonePatientGen = new(sim.SeedGenerator, 1.0 / (9.57d * 60));
        }

        override public void PrepareReplication()
        {
            base.PrepareReplication();
            // Setup component for the next replication
            MySimulation sim = (MySimulation)MySim;
            AmbulancePatientGen = new(sim.SeedGenerator, 7, 1.0 / (0.836d * 60));
            AlonePatientGen = new(sim.SeedGenerator, 1.0 / (9.57d * 60));

            //Reset stats
            AverageTimeInSystemAll.Reset();
            AverageTimeInSystemAlone.Reset();
            AverageTimeInSystemAmbulance.Reset();

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
			new SchedulerAmbulancePatientArrival(SimId.SchedulerAmbulancePatientArrival, MySim, this);
			new SchedulerAlonePatientArrival(SimId.SchedulerAlonePatientArrival, MySim, this);
			AddOwnMessage(Mc.PatientArrived);
			AddOwnMessage(Mc.PatientLeave);
		}
		//meta! tag="end"
    }
}
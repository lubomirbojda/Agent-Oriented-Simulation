using Agents.AgentBoss;
using OSPABA;
using Agents.AgentHospital;
using Agents.AgentEnviroment;

namespace Simulation
{
    public class MySimulation : OSPABA.Simulation
    {
        public Random SeedGenerator { get; private set; } = new Random();
        public int PatientsFinished = 0;

        public MySimulation()
        {
            Init();
        }

        override public void PrepareSimulation()
        {
            base.PrepareSimulation();
            // Create global statistcis
        }

        override public void PrepareReplication()
        {
            base.PrepareReplication();
            // Reset entities, queues, local statistics, etc...
            Console.WriteLine("Repliacation : " + CurrentReplication + " started");
        }

        override public void ReplicationFinished()
        {
            // Collect local statistics into global, update UI, etc...
            base.ReplicationFinished();
            Console.WriteLine("Patients finished: " + PatientsFinished);
            Console.WriteLine("Repliacation : " + CurrentReplication + " finished");

            PatientsFinished = 0;

        }

        override public void SimulationFinished()
        {
            // Display simulation results
            base.SimulationFinished();
        }

        //meta! userInfo="Generated code: do not modify", tag="begin"
        private void Init()
        {
            AgentBoss = new AgentBoss(SimId.AgentBoss, this, null);
            AgentEnviroment = new AgentEnviroment(SimId.AgentEnviroment, this, AgentBoss);
            AgentHospital = new AgentHospital(SimId.AgentHospital, this, AgentBoss);
        }
        public AgentBoss AgentBoss
        { get; set; }
        public AgentEnviroment AgentEnviroment
        { get; set; }
        public AgentHospital AgentHospital
        { get; set; }
        //meta! tag="end"
    }
}

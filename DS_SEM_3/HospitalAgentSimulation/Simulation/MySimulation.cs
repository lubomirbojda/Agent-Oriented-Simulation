using Agents.AgentBoss;
using Agents.AgentResources;
using OSPABA;
using Agents.AgentHospital;
using Agents.AgentEnviroment;
using Agents.AgentMedicalTreat;
using Agents.AgentEntranceTreat;
using DS_SEM_3.Statistics;

namespace Simulation
{
    public class MySimulation : OSPABA.Simulation
    {
        public Random SeedGenerator { get; private set; } = new Random();
        public int PatientsFinished { get; set; } = 0;
        public int AlonePatientsFinished { get; set; } = 0;
        public int AmbulancePatientsFinished { get; set; } = 0;

        //Stats
        public SimpleStatistics AveragePatientsFinishedAll { get; set; } = new();
        public SimpleStatistics AveragePatientsFinishedAlone { get; set; } = new();
        public SimpleStatistics AveragePatientsFinishedAmbulance { get; set; } = new();

        public SimpleStatistics AverageTimeInSystemAll { get; set; } = new();
        public SimpleStatistics AverageTimeInSystemAlone { get; set; } = new();
        public SimpleStatistics AverageTimeInSystemAmbulance { get; set; } = new();

        public SimpleStatistics AverageWaitingForEntranceTreatAll { get; set; } = new();
        public SimpleStatistics AverageWaitingForEntranceTreatAlone { get; set; } = new();
        public SimpleStatistics AverageWaitingForEntranceTreatAmbulance { get; set; } = new();

        public SimpleStatistics AverageEntranceQueueLength { get; set; } = new();

        public SimpleStatistics AverageWaitingForMedicalTreatAll { get; set; } = new();
        public SimpleStatistics AverageWaitingForMedicalTreatAlone { get; set; } = new();
        public SimpleStatistics AverageWaitingForMedicalTreatAmbulance { get; set; } = new();

        public SimpleStatistics AverageNursesUtilization { get; set; } = new();
        public SimpleStatistics AverageDoctorsUtilization { get; set; } = new();
        public SimpleStatistics AverageAmbulanceAUtilization { get; set; } = new();
        public SimpleStatistics AverageAmbulanceBUtilization { get; set; } = new();

        public MySimulation()
        {
            Init();
        }

        public void SetSeed(int seed)
        {
            SeedGenerator = new Random(seed);
        }

        override public void PrepareSimulation()
        {
            base.PrepareSimulation();
            ResetStats();
            // Create global statistcis
        }

        override public void PrepareReplication()
        {
            base.PrepareReplication();
            // Reset entities, queues, local statistics, etc...
        }

        override public void ReplicationFinished()
        {
            // Collect local statistics into global, update UI, etc...
            base.ReplicationFinished();

            AveragePatientsFinishedAll.Add(PatientsFinished);
            AveragePatientsFinishedAlone.Add(AlonePatientsFinished);
            AveragePatientsFinishedAmbulance.Add(AmbulancePatientsFinished);

            AverageTimeInSystemAll.Add(AgentEnviroment.AverageTimeInSystemAll.GetAverage());
            AverageTimeInSystemAlone.Add(AgentEnviroment.AverageTimeInSystemAlone.GetAverage());
            AverageTimeInSystemAmbulance.Add(AgentEnviroment.AverageTimeInSystemAmbulance.GetAverage());

            AverageWaitingForEntranceTreatAll.Add(AgentHospital.AverageWaitingForEntranceTreatAll.GetAverage());
            AverageWaitingForEntranceTreatAlone.Add(AgentHospital.AverageWaitingForEntranceTreatAlone.GetAverage());
            AverageWaitingForEntranceTreatAmbulance.Add(AgentHospital.AverageWaitingForEntranceTreatAmbulance.GetAverage());

            AverageEntranceQueueLength.Add(AgentHospital.AverageEntranceQueueLength.GetAverage(CurrentTime));

            AverageWaitingForMedicalTreatAll.Add(AgentHospital.AverageWaitingForMedicalTreatAll.GetAverage());
            AverageWaitingForMedicalTreatAlone.Add(AgentHospital.AverageWaitingForMedicalTreatAlone.GetAverage());
            AverageWaitingForMedicalTreatAmbulance.Add(AgentHospital.AverageWaitingForMedicalTreatAmbulance.GetAverage());

            double avgBusyNurses = AgentResources.Nurses.AverageUtilization.GetAverage(CurrentTime);
            double avgBusyDoctors = AgentResources.Doctors.AverageUtilization.GetAverage(CurrentTime);
            double avgBusyAmbA = AgentResources.AmbulationsA.AverageUtilization.GetAverage(CurrentTime);
            double avgBusyAmbB = AgentResources.AmbulationsB.AverageUtilization.GetAverage(CurrentTime);

            AverageNursesUtilization.Add(avgBusyNurses / AgentResources.Nurses.AllResources.Length);
            AverageDoctorsUtilization.Add(avgBusyDoctors / AgentResources.Doctors.AllResources.Length);
            AverageAmbulanceAUtilization.Add(avgBusyAmbA / AgentResources.AmbulationsA.AllResources.Length);
            AverageAmbulanceBUtilization.Add(avgBusyAmbB / AgentResources.AmbulationsB.AllResources.Length);

            //Reset counters
            PatientsFinished = 0;
            AlonePatientsFinished = 0;
            AmbulancePatientsFinished = 0;
        }

        private void ResetStats()
        {
            AveragePatientsFinishedAll.Reset();
            AveragePatientsFinishedAlone.Reset();
            AveragePatientsFinishedAmbulance.Reset();
            AverageTimeInSystemAll.Reset();
            AverageTimeInSystemAmbulance.Reset();
            AverageTimeInSystemAlone.Reset();
            AverageWaitingForEntranceTreatAll.Reset();
            AverageWaitingForEntranceTreatAlone.Reset();
            AverageWaitingForEntranceTreatAmbulance.Reset();
            AverageEntranceQueueLength.Reset();
            AverageWaitingForMedicalTreatAll.Reset();
            AverageWaitingForMedicalTreatAlone.Reset();
            AverageWaitingForMedicalTreatAmbulance.Reset();
            AverageNursesUtilization.Reset();
            AverageDoctorsUtilization.Reset();
            AverageAmbulanceAUtilization.Reset();
            AverageAmbulanceBUtilization.Reset();
        }

        override public void SimulationFinished()
        {
            // Display simulation results
            base.SimulationFinished();
        }

        public void SetInputParameters(int nursesCount, int doctorsCount, int warmUpHours)
        {
            AgentResources.SetUpResources(nursesCount, doctorsCount);
        }

		//meta! userInfo="Generated code: do not modify", tag="begin"
		private void Init()
		{
			AgentBoss = new AgentBoss(SimId.AgentBoss, this, null);
			AgentEnviroment = new AgentEnviroment(SimId.AgentEnviroment, this, AgentBoss);
			AgentHospital = new AgentHospital(SimId.AgentHospital, this, AgentBoss);
			AgentResources = new AgentResources(SimId.AgentResources, this, AgentHospital);
			AgentEntranceTreat = new AgentEntranceTreat(SimId.AgentEntranceTreat, this, AgentHospital);
			AgentMedicalTreat = new AgentMedicalTreat(SimId.AgentMedicalTreat, this, AgentHospital);
		}
		public AgentBoss AgentBoss
		{ get; set; }
		public AgentEnviroment AgentEnviroment
		{ get; set; }
		public AgentHospital AgentHospital
		{ get; set; }
		public AgentResources AgentResources
		{ get; set; }
		public AgentEntranceTreat AgentEntranceTreat
		{ get; set; }
		public AgentMedicalTreat AgentMedicalTreat
		{ get; set; }
		//meta! tag="end"
    }
}
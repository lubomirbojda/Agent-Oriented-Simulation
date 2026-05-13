using DS_SEM_3.HospitalAgentSimulation.Entities;
using OSPABA;
using Simulation;

namespace Agents.AgentResources
{
	//meta! id="108"
	public class AgentResources : OSPABA.Agent
	{
		public Resources<Nurse> Nurses { get; private set; } = new(0);
        public Resources<Doctor> Doctors { get; private set; } = new(0);
        public Resources<AmbulanceA> AmbulationsA { get; private set; } = new(5);
        public Resources<AmbulanceB> AmbulationsB { get; private set; } = new(7);


        public AgentResources(int id, OSPABA.Simulation mySim, Agent parent) :
			base(id, mySim, parent)
		{
			Init();
		}

		public void SetUpResources(int nursesCount, int doctorsCount)
		{
			Nurses = new(nursesCount);
			Doctors = new(doctorsCount);

			//animator set start position
			int i = 0;
			foreach (var nurse in Nurses.AllResources)
			{
				nurse.MainAnimShapeItem.SetPosition(-480 + (45 * i) , 550);
				i++;
			}
			i = 0;
            foreach (var doctor in Doctors.AllResources)
            {
                doctor.MainAnimShapeItem.SetPosition(1820 + (45 * i), 550);
                i++;
            }

			i = 0;
			foreach (var ambulance in AmbulationsA.AllResources)
			{
                var X = 100 + i * 250;
                var Y = 200;
                ambulance.MainAnimShapeItem.SetPosition(X, Y);
                var circleX = X + (ambulance.MainAnimShapeItem.Width / 2);
                var circleY = Y + ambulance.MainAnimShapeItem.Height + 20;
                ambulance.CircleNode.SetPosition(circleX, circleY);
                i++;
            }

            i = 0;
            foreach (var ambulance in AmbulationsB.AllResources)
            {
                var X = 100 + i * 250;
                var Y = 800;
                ambulance.MainAnimShapeItem.SetPosition(X, Y);
                var circleX = X + (ambulance.MainAnimShapeItem.Width / 2);
                var circleY = Y - 40;
                ambulance.CircleNode.SetPosition(circleX, circleY);
                i++;
            }

            
        }

		override public void PrepareReplication()
		{
			base.PrepareReplication();
            // Setup component for the next replication
            Nurses.ResetResources();
            Doctors.ResetResources();
            AmbulationsA.ResetResources();
            AmbulationsB.ResetResources();

			Nurses.ResetResourceUtilStats(MySim.CurrentTime);
            Doctors.ResetResourceUtilStats(MySim.CurrentTime);
            AmbulationsA.ResetResourceUtilStats(MySim.CurrentTime);
            AmbulationsB.ResetResourceUtilStats(MySim.CurrentTime);

            SetUpResources(Nurses.AllResources.Length, Doctors.AllResources.Length);
        }

        //meta! userInfo="Generated code: do not modify", tag="begin"
        private void Init()
		{
			new ManagerResources(SimId.ManagerResources, MySim, this);
			AddOwnMessage(Mc.TryAssignResources);
		}
		//meta! tag="end"
    }
}
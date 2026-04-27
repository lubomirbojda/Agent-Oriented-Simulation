namespace DS_SEM_3.HospitalAgentSimulation.Entities;

public class Nurse : Resource
{
    public Ambulance? ActualAmbulance { get; set; }

    public override void Reset()
    {
        base.Reset();
        ActualAmbulance = null;
    }
}

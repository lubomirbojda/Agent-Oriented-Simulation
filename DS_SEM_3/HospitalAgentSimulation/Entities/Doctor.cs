namespace DS_SEM_3.HospitalAgentSimulation.Entities;

public class Doctor : Resource
{
    public AmbulanceA? ActualAmbulance { get; set; }
    public AmbulanceA? LastAmbulance { get; set; }

    public override void Reset()
    {
        base.Reset();
        ActualAmbulance = null;
        LastAmbulance = null;
    }
}

namespace DS_SEM_3.HospitalAgentSimulation.Entities;

public class AmbulanceA : Resource
{
    public Patient? Patient { get; set; }
    public List<Nurse> Nurses { get; private set; } = new();
    public List<Doctor> Doctors { get; private set; } = new();
    public bool IsTypeA { get; protected set; } = true;

    public override void Reset()
    {
        base.Reset();
        Patient = null;
        Nurses.Clear();
        Doctors.Clear();
    }

    public Nurse? GetBusyNurse() => Nurses.FirstOrDefault(x => x.IsBusy);
    public Doctor? GetBusyDoctor() => Doctors.FirstOrDefault(x => x.IsBusy);

    public void RemoveNurse(Nurse nurse) => Nurses.Remove(nurse);
    public void RemoveDoctor(Doctor doctor) => Doctors.Remove(doctor);
}

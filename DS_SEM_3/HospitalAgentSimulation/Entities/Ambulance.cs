namespace DS_SEM_3.HospitalAgentSimulation.Entities;

public class Ambulance : Resource
{
    public Patient? Patient { get; set; }
    public List<Nurse> Nurses { get; private set; } = new();
    public List<Doctor> Doctors { get; private set; } = new();

    public override void Reset()
    {
        base.Reset();
        Patient = null;
        Nurses.Clear();
        Doctors.Clear();
    }

    public void RemoveNurse(Nurse nurse) => Nurses.Remove(nurse);
    public void RemoveDoctor(Doctor doctor) => Doctors.Remove(doctor);
}

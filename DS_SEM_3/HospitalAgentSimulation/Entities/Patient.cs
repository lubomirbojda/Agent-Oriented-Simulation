namespace DS_SEM_3.HospitalAgentSimulation.Entities;

public class Patient
{
    public bool CameByAmbulance { get; private set; }
    public double ArrivalTime { get; private set; }

    public int Id { get; private set; } = 0;
    public int Priority { get; private set; } = 0;

    public Nurse? AssignedNurse { get; set; }
    public Doctor? AssignedDoctor { get; set; }
    public Ambulance? AssignedAmbulance { get; set; }

    public bool HasEntranceTreatDone { get; set; } = false;

    public Patient(bool cameByAmbulance, double arrivalTime, int id, int priority)
    {
        CameByAmbulance = cameByAmbulance;
        ArrivalTime = arrivalTime;
        Id = id;
        Priority = priority;
    }

    public void AssignResources(Nurse nurse, Ambulance ambulance, Doctor? doctor = null)
    {
        if (ambulance != nurse.ActualAmbulance)
        {
            ambulance.Nurses.Add(nurse);
            nurse.ActualAmbulance?.RemoveNurse(nurse);
        }
        nurse.IsBusy = true;
        nurse.ActualAmbulance = ambulance;
        ambulance.IsBusy = true;
        ambulance.Patient = this;
        if (doctor != null)
        {
            if (ambulance != doctor.ActualAmbulance)
            {
                ambulance.Doctors.Add(doctor);
                doctor.ActualAmbulance?.RemoveDoctor(doctor);
            
            }
            doctor.IsBusy = true;
            doctor.ActualAmbulance = ambulance;
        }

        AssignedNurse = nurse;
        AssignedAmbulance = ambulance;
        AssignedDoctor = doctor;
    }

    public void UnassignResources()
    {
        if (AssignedNurse != null)
        {
            AssignedNurse.IsBusy = false;
        }

        if (AssignedDoctor != null)
        {
            AssignedDoctor.IsBusy = false;
        }

        if (AssignedAmbulance != null)
        {
            AssignedAmbulance.IsBusy = false;
            AssignedAmbulance.Patient = null;
        }

        AssignedNurse = null;
        AssignedDoctor = null;
        AssignedAmbulance = null;
    }
}

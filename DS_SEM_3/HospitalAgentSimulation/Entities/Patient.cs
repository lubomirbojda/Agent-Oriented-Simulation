namespace DS_SEM_3.HospitalAgentSimulation.Entities;

public class Patient
{
    public bool CameByAmbulance { get; private set; }
    public double ArrivalTime { get; private set; }

    public double TimeStartWaitingForEntranceTreat { get; set; } = -1;
    public double WaitingForEntranceTreat { get; set; } = -1;

    public double TimeStartWaitingForMedicalTreat { get; set; } = -1;
    public double WaitingForMedicalTreat { get; set; } = -1;

    public int Id { get; private set; } = 0;
    public int Priority { get; set; } = 0;

    public Nurse? AssignedNurse { get; set; }
    public Doctor? AssignedDoctor { get; set; }
    public AmbulanceA? AssignedAmbulance { get; set; }

    public bool HasEntranceTreatDone { get; set; } = false;

    public bool HasAssignedAllResources { get; private set; } = false;

    public bool CanStartTreat { get; set; } = false;

    public Patient(bool cameByAmbulance, double arrivalTime, int id)
    {
        CameByAmbulance = cameByAmbulance;
        ArrivalTime = arrivalTime;
        Id = id;
    }

    public void AssignResources(Nurse nurse, AmbulanceA ambulance, Doctor? doctor = null)
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
        HasAssignedAllResources = true;
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
        HasAssignedAllResources = false;
    }
}

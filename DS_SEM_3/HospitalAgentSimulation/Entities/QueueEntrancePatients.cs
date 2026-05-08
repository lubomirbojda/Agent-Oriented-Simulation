using OSPABA;

namespace DS_SEM_3.HospitalAgentSimulation.Entities;

public class QueueEntrancePatients
{
    private Queue<Patient> QueueEntranceAmbulancePatients = new();
    private Queue<Patient> QueueEntranceAlonePatients = new();

    public void Enqueue(Patient patient)
    {
        if (patient.CameByAmbulance)
        {
            QueueEntranceAmbulancePatients.Enqueue(patient);
        }
        else
        {
            QueueEntranceAlonePatients.Enqueue(patient);
        }
    }

    public Patient Dequeue()
    {
        if (QueueEntranceAmbulancePatients.Count > 0)
        {
            return QueueEntranceAmbulancePatients.Dequeue();
        }
        else
        {
            return QueueEntranceAlonePatients.Dequeue();
        }
    }

    public int GetCount()
    {
        return QueueEntranceAmbulancePatients.Count + QueueEntranceAlonePatients.Count;
    }

    public void Clear()
    {
        QueueEntranceAmbulancePatients.Clear();
        QueueEntranceAlonePatients.Clear();
    }
}

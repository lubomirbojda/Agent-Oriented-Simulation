namespace DS_SEM_3.HospitalAgentSimulation.Entities;

public class PriorityQueuesAmbulances
{
    private int ambulanceAOrder = 0;
    private int ambulanceBOrder = 0;
    public SortedList<(int priority, int order), Patient> QueueAmbulanceA { get; private set; } = new();
    public SortedList<(int priority, int order), Patient> QueueAmbulanceB { get; private set; } = new();

    public void EnqueuePatientAmbulanceA(Patient patient, int priority)
    {
        QueueAmbulanceA.Add((priority, ambulanceAOrder++), patient);
    }

    public void EnqueuePatientAmbulanceB(Patient patient, int priority)
    {
        QueueAmbulanceB.Add((priority, ambulanceBOrder++), patient);
    }

    private Patient DequeuePatient(
            SortedList<(int priority, int order), Patient> sourceQueue,
            SortedList<(int priority, int order), Patient> otherQueue)
    {
        var patient = sourceQueue.Values[0];
        sourceQueue.RemoveAt(0);

        int otherIndex = otherQueue.IndexOfValue(patient);
        if (otherIndex >= 0)
        {
            otherQueue.RemoveAt(otherIndex);
        }

        return patient;
    }

    public Patient DequeuePatientAmbulanceA() => DequeuePatient(QueueAmbulanceA, QueueAmbulanceB);

    public Patient DequeuePatientAmbulanceB() => DequeuePatient(QueueAmbulanceB, QueueAmbulanceA);

    public void Clear()
    {
        QueueAmbulanceA.Clear();
        QueueAmbulanceB.Clear();
        ambulanceAOrder = 0;
        ambulanceBOrder = 0;
    }
}

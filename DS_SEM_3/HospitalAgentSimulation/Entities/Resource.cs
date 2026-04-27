namespace DS_SEM_3.HospitalAgentSimulation.Entities;

public class Resource
{
    public bool IsBusy { get; set; } = false;
    public int Id { get; set; } = 0;

    public virtual void Reset()
    {
        IsBusy = false;
    }
}

using DS_SEM_3.Statistics;

namespace DS_SEM_3.HospitalAgentSimulation.Entities;

public class Resources<T> where T : Resource, new()
{
    public T[] AllResources { get; private set; }
    public TimeStatistics AverageUtilization { get; set; } = new();

    public Resources(int count)
    {
        AllResources = new T[count];
        for (int i = 0; i < count; i++)
        {
            AllResources[i] = new T()
            {
                Id = i
            };
        }
    }

    public T? TryGetFreeResource() => AllResources.FirstOrDefault(x => !x.IsBusy);

    public void UpdateResourceUtilStats(double currentTime)
    {
        AverageUtilization.Add(AllResources.Count(r => r.IsBusy), currentTime);
    }

    public void ResetResourceUtilStats(double? time = null)
    {
        if (time != null)
        {
            AverageUtilization.ResetAtTime(time.Value);
            return;
        }
        AverageUtilization.Reset();
    }

    public void ResetResources()
    {
        foreach (var resource in AllResources)
        {
            resource.Reset();
        }
    }
}

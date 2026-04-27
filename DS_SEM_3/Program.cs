using Simulation;

namespace DS_SEM_3;

public class Program
{
    static void Main(string[] args)
    {
        MySimulation sim = new MySimulation();
        sim.Simulate(100, 24*60*60);
    }
}

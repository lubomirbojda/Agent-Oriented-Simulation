using OSPAnimator;
using System.Drawing;

namespace DS_SEM_3.HospitalAgentSimulation.Entities;

public class AmbulanceA : Resource
{
    public Patient? Patient { get; set; }
    public List<Nurse> Nurses { get; private set; } = new();
    public List<Doctor> Doctors { get; private set; } = new();
    public bool IsTypeA { get; protected set; } = true;

    public AnimShapeItem CircleNode { get; set; } = new();

    public AmbulanceA() : base()
    {
        MainAnimShapeItem.Height = 100;
        MainAnimShapeItem.Width = 200;
        MainAnimShapeItem.AnimShape = AnimShape.RECTANGLE;

        CircleNode.Height = 20;
        CircleNode.Width = 20;
        CircleNode.AnimShape = AnimShape.CIRCLE;
    }

    public override void Reset()
    {
        base.Reset();
        Patient = null;
        Nurses.Clear();
        Doctors.Clear();
    }

    public PointF GetActiveNursePosition(double time)
    {
        float x = MainAnimShapeItem.GetPosition(time).X + 15;
        float y = MainAnimShapeItem.GetPosition(time).Y + 15;
        return new(x, y);
    }

    public Nurse? GetBusyNurse() => Nurses.FirstOrDefault(x => x.IsBusy);
    public Doctor? GetBusyDoctor() => Doctors.FirstOrDefault(x => x.IsBusy);

    public void RemoveNurse(Nurse nurse) => Nurses.Remove(nurse);
    public void RemoveDoctor(Doctor doctor) => Doctors.Remove(doctor);
}

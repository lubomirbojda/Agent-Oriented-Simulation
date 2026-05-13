using OSPAnimator;

namespace DS_SEM_3.HospitalAgentSimulation.Entities;

public class Doctor : Resource
{
    public AmbulanceA? ActualAmbulance { get; set; }
    public AmbulanceA? LastAmbulance { get; set; }

    public Doctor() : base()
    {
        MainAnimShapeItem.Height = 30;
        MainAnimShapeItem.Width = 30;
        MainAnimShapeItem.AnimShape = AnimShape.CIRCLE;
    }

    public override void Reset()
    {
        base.Reset();
        ActualAmbulance = null;
        LastAmbulance = null;
    }
}

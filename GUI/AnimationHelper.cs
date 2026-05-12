using OSPAnimator;

namespace GUI
{
    public static class AnimationHelper
    {
        // Posuny IDčok pre animátor, aby sa nemiešali pacienti s doktormi
        public const int DOC_OFFSET = 30000;
        public const int NURSE_OFFSET = 40000;

        // Vráti stredové súradnice ambulancie
        public static PointF GetAmbulanceCenter(bool isTypeA, int ambId)
        {
            float x = 50 + ambId * 150 + 50; // +50 pre stred štvorca
            float y = (isTypeA ? 200 : 400) + 50;
            return new PointF(x, y);
        }

        // Vráti rohovú súradnicu ambulancie (pre voľný personál)
        public static PointF GetAmbulanceCorner(bool isTypeA, int ambId, bool isDoctor)
        {
            float x = 50 + ambId * 150 + (isDoctor ? 80 : 10); // Doktor do pravého rohu, sestra do ľavého
            float y = (isTypeA ? 200 : 400) + 10;
            return new PointF(x, y);
        }

        // --- METÓDY VOLANÉ PRIAMO Z TVOJHO MODELU ---

        public static void RegisterPatient(OSPABA.Simulation sim, int patientId, bool isAmbulance)
        {
            if (!sim.AnimatorExists) return;
            var pShape = new AnimShapeItem();
            pShape.AnimShape = AnimShape.CIRCLE; // [cite: 103]
            pShape.Color = isAmbulance ? System.Windows.Media.Colors.Red : System.Windows.Media.Colors.DarkBlue;
            pShape.Width = 20; pShape.Height = 20;
            pShape.Label = "P" + patientId; // [cite: 115]

            sim.Animator.Register(patientId, pShape); // [cite: 85]
            pShape.SetPosition(500, 50); // Štart v čakárni hore [cite: 119]
        }

        public static void MovePatientToAmbulance(OSPABA.Simulation sim, int patientId, bool isTypeA, int ambId, double duration)
        {
            if (!sim.AnimatorExists) return;
            var pShape = (AnimShapeItem)sim.Animator.GetAnim(patientId); // [cite: 89]
            if (pShape == null) return;

            var center = GetAmbulanceCenter(isTypeA, ambId);

            // Cesta: Súčasná pozícia -> stredná chodba -> stred ambulancie
            PointF[] path = new PointF[] { // 
                new PointF(500, 300), // Prechodový bod v strede chodby
                center
            };

            pShape.StartAnim(sim.CurrentTime, duration, path);
        }

        public static void SetResourceState(OSPABA.Simulation sim, int resourceId, bool isDoctor, bool isTypeA, int ambId, bool isBusy, double duration)
        {
            if (!sim.AnimatorExists) return;
            int animId = (isDoctor ? DOC_OFFSET : NURSE_OFFSET) + resourceId;
            var shape = (AnimShapeItem)sim.Animator.GetAnim(animId);

            // Ak ešte nebol registrovaný, zaregistrujeme ho
            if (shape == null)
            {
                shape = new AnimShapeItem();
                shape.AnimShape = AnimShape.CIRCLE;
                shape.Color = isDoctor ? System.Windows.Media.Colors.Green : System.Windows.Media.Colors.DeepPink;
                shape.Width = 15; shape.Height = 15;
                shape.Label = (isDoctor ? "D" : "S") + resourceId;
                sim.Animator.Register(animId, shape);
                shape.SetPosition(800, 50); // Počiatočná spawn lokácia
            }

            // Rozhodnutie o cieli: Stred miestnosti ak je Busy, Roh miestnosti ak je Idle
            PointF target = isBusy ? GetAmbulanceCenter(isTypeA, ambId) : GetAmbulanceCorner(isTypeA, ambId, isDoctor);

            shape.MoveTo(sim.CurrentTime, duration, target.X, target.Y);
        }

        public static void RemovePatient(OSPABA.Simulation sim, int patientId)
        {
            if (!sim.AnimatorExists) return;
            var pShape = sim.Animator.GetAnim(patientId);
            if (pShape != null) pShape.Remove(); // Vymazanie z animátora pri odchode [cite: 133, 136]
        }
    }
}

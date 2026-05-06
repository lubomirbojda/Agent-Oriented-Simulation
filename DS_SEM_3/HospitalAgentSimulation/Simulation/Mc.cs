using OSPABA;

namespace Simulation
{
	public class Mc : OSPABA.IdList
	{
		//meta! userInfo="Generated code: do not modify", tag="begin"
		public const int PatientArrived = 1002;
		public const int PatientArrival = 1004;
		public const int EntranceTreat = 1015;
		public const int MedicalTreat = 1017;
		public const int PatientLeave = 1010;
		public const int TreatPatient = 1012;
		public const int TryAssignResources = 1019;
		public const int ResourcesAssigned = 1020;
		//meta! tag="end"

		// 1..1000 range reserved for user

		public const int PatientMoveToEntranceSpace = 1;
		public const int PatientMakeEntranceTreat = 2;
		public const int MoveToAmbulance = 3;
		public const int PatientMakeMedicalTreat = 4;
		public const int PatientMoveToLeaveDoor = 5;
    }
}
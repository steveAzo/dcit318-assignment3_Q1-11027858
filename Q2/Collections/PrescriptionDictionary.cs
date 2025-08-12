namespace Collections
{
    public class PrescriptionDictionary
    {
        public Dictionary<int, List<Prescription>> PrescriptionsByPatientId = new();

        public void PopulateFromPrescriptions(List<Prescription> prescriptions)
        {
            foreach (var prescription in prescriptions)
            {
                if (!PrescriptionsByPatientId.ContainsKey(prescription.PatientId))
                {
                    PrescriptionsByPatientId[prescription.PatientId] = new List<Prescription>();
                }
                PrescriptionsByPatientId[prescription.PatientId].Add(prescription);
            }
        }

        public List<Prescription> GetPrescriptionsByPatientId(int patientId)
        {
            if (PrescriptionsByPatientId.TryGetValue(patientId, out var prescriptions))
            {
                return prescriptions;
            }
            return new List<Prescription>();
        }

    }
}
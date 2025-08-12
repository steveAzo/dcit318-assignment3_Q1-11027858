using Collections;

public class HealthSystemApp
{
    private readonly Repository<Patient> _patientRepo = new();
    private readonly Repository<Prescription> _prescriptionRepo = new();
    private readonly PrescriptionDictionary _prescriptionDictionMap = new();

    public void SeedData()
    {
        Patient patient1 = new Patient(1, "Stephen", 22, "Male");
        _patientRepo.Add(patient1);
        Patient patient2 = new Patient(2, "Bennet", 21, "Female");
        _patientRepo.Add(patient2);

        Prescription prescription1 = new Prescription(1, 1, "Pain Relief", DateTime.Parse("2023-12-23"));
        _prescriptionRepo.Add(prescription1);
        Prescription prescription2 = new Prescription(2, 1, "Cold", DateTime.Parse("2019-12-19"));
        _prescriptionRepo.Add(prescription2);
        Prescription prescription3 = new Prescription(3, 2, "Flu", DateTime.Parse("2021-12-21"));
        _prescriptionRepo.Add(prescription3);
        Prescription prescription4 = new Prescription(4, 2, "Pain Relief", DateTime.Parse("2015-06-15"));
        _prescriptionRepo.Add(prescription4);
    }

    public void BuildPrescriptionMap()
    {
        var allPrescriptions = _prescriptionRepo.GetAll();
        _prescriptionDictionMap.PopulateFromPrescriptions(allPrescriptions);
    }

    public void PrintAllPatients()
    {
        var patients = _patientRepo.GetAll();
        Console.WriteLine("----- Patients -----");
        foreach (var p in patients)
        {
            Console.WriteLine($"Id: {p.Id} | Name: {p.Name} | Age: {p.Age} | Gender: {p.Gender}");
        }
    }

    public void PrintPrescriptionsForPatient(int patientId)
    {
        var prescriptions = _prescriptionDictionMap.GetPrescriptionsByPatientId(patientId);
        Console.WriteLine($"----- Prescriptions for PatientId: {patientId} ----");
        if (prescriptions.Count == 0)
        {
            Console.WriteLine("No prescriptions found for this patient.");
            return;
        }

        foreach (var pr in prescriptions)
        {
            Console.WriteLine($"PrescriptionsId: {pr.Id} | Medication: {pr.MedicationName} | Issued: {pr.DateIssued:d}");
        }
    }
}

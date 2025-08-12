public class Prescription
{
    public int Id;
    public int PatientId;
    public string? MedicationName;
    public DateTime DateIssued;

    public Prescription(int Id, int PatientId, string MedicationName, DateTime DateIssued)
    {
        this.Id = Id;
        this.PatientId = PatientId;
        this.MedicationName = MedicationName;
        this.DateIssued = DateIssued;
    }
}
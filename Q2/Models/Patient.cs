public class Patient
{
    public int Id;
    public string? Name;
    public int Age;
    public string? Gender;

    public Patient(int Id, string Name, int Age, string Gender)
    {
        this.Id = Id;
        this.Name = Name;
        this.Age = Age;
        this.Gender = Gender;
    }
}
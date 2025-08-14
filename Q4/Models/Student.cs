public class Student
{
    public int Id;
    public string? FullName;
    public int Score;

    public Student(int Id, string FullName, int Score)
    {
        this.Id = Id;
        this.FullName = FullName;
        this.Score = Score;
    }

    public string GetGrade()
    {
        if (Score < 50) return "F";
        else if (Score >= 50 && Score < 60) return "D";
        else if (Score >= 60 && Score < 70) return "C";
        else if (Score >= 70 && Score < 80) return "B";
        else return "A";
    }
}
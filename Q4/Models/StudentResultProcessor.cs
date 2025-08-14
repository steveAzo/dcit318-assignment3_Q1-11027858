using System;
using System.IO;


public class StudentResultProcessor
{
    public List<Student> ReadStudentsFromFile(string inputPathFile)
    {
        List<Student> students = new();
        using (StreamReader reader = new StreamReader(inputPathFile))
        {
            string line;
            while ((line = reader.ReadLine()!) != null)
            {
                string[] properties = line.Split(',');
                (string idStr, string FullName, string scoreStr) = (properties[0], properties[1], properties[2]);

                int Id = int.Parse(idStr);
                if (!int.TryParse(scoreStr, out var Score))
                {
                    throw new InvalidScoreFormat("Score should be an integer");
                }

                if (Id == 0 || string.IsNullOrWhiteSpace(FullName) || Score == 0) throw new MissingFieldException("Some fields are missing");

                Student student = new Student(Id, FullName, Score);
                students.Add(student);

            }
        }
        return students;
    }

    public void WriteReportToFile(List<Student> students, string ouputFilePath)
    {
        using (StreamWriter writer = new StreamWriter(ouputFilePath))
        {
            foreach (var student in students)
            {
                writer.WriteLine($"{student.FullName} ({student.Id}): Score = {student.Score}, Grade = {student.GetGrade()}");
            }
        }
    }
}
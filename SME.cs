namespace CSHARPTUTORIAL;

public class Student
{
    public int _StudentID;
    public string _Name;
    public int _Age;

    public Student()
    {
        Console.WriteLine("No student data");
    }
    public Student(int StudentID, string Name, int Age)
    {
        this._StudentID = StudentID;
        this._Name = Name;
        this._Age = Age;
    }

    public virtual void DisplayStudentInformation()
    {
        Console.WriteLine($"Student ID: {this._StudentID} \n Name: {this._Name} \n Age: {this._Age}");
    }
}

public class GraduateStudent : Student
{
    string ResearchTopic;

    public override void DisplayStudentInformation()
    {
        Console.WriteLine($"Student ID: {this._StudentID} \n Name: {this._Name} \n Age: {this._Age} \n Research Topic: {this.ResearchTopic}");
    }
}

public class SME
{
    public static void StudentManagementSystem()
    {

    }
}

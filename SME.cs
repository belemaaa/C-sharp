namespace CSHARPTUTORIAL;

public class Student
{
    public int _StudentID;
    public string _Name;
    private int _Age;

    public Student()
        : this(00000, "No Name provided", 00000) { }

    public Student(int StudentID, string Name, int Age)
    {
        this._StudentID = StudentID;
        this._Name = Name;
        this.Age = Age;
    }

    public int Age
    {
        get { return _Age; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Age should be a positive number");
            }
            _Age = value;
        }
    }

    public virtual void DisplayStudentInformation()
    {
        Console.WriteLine($"Student ID: {this._StudentID} \nName: {this._Name} \nAge: {this.Age}");
    }
}

public class GraduateStudent : Student
{
    public string _ResearchTopic;

    public GraduateStudent(int StudentID, string Name, int Age, string ResearchTopic)
        : base(StudentID, Name, Age)
    {
        this._ResearchTopic = ResearchTopic;
    }

    public override void DisplayStudentInformation()
    {
        Console.WriteLine($"Student ID: {this._StudentID} \nName: {this._Name} \nAge: {this.Age} \nResearch Topic: {this._ResearchTopic}");
    }
}

public class SME
{
    public static void StudentManagementSystem()
    {
        // Student S1 = new Student(101, "James", 19);
        // S1.DisplayStudentInformation();

        Student GS1 = new GraduateStudent(102, "John Doe", 25, "Machine Learning");
        GS1.DisplayStudentInformation();
    }
}

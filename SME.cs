namespace CSHARPTUTORIAL;

public class Student
{
    // private static int _lastID = 1;
    private Guid _StudentID;
    public string _Name;
    private int _Age;
    private int _PhoneNumber;
    public string _Email;
    public string _Department;
    public string _Gender;

    public Student(string Name, int Age, string Email, int PhoneNumber, string Department, string Gender)
    {
        this._StudentID = Guid.NewGuid();
        this._Name = Name;
        this.Age = Age;
        this._Email = Email;
        this.PhoneNumber = PhoneNumber;
        this._Department = Department;
        this._Gender = Gender;
    }

    public int Age
    {
        get { return _Age; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Age must be a positive integer");
            }
            _Age = value;
        }
    }

    public int PhoneNumber
    {
        get { return _PhoneNumber; }
        set
        {
            if (value < 11 || value > 11)
            {
                throw new ArgumentException("Phone number must be 11 characters");
            }
            _PhoneNumber = value;
        }
    }

    public Guid StudentID
    {
        get { return _StudentID; }
    }

    public virtual void DisplayStudentInformation()
    {
        Console.WriteLine($"Student ID: {this._StudentID} \nName: {this._Name} \nAge: {this.Age} \nPhone Number: {this.PhoneNumber}" + 
            $"\nDepartment: {this._Department} \nGender: {this._Gender}");
    }
}

public class GraduateStudent : Student
{
    public string _ResearchTopic;

    public GraduateStudent(int StudentID, string Name, int Age, string ResearchTopic)
    {
        this._Name = Name;
        this.Age = Age;
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

        GraduateStudent GS1 = new GraduateStudent(102, "Grace", 23, "Machine Learning");
        GS1.DisplayStudentInformation();
    }
}

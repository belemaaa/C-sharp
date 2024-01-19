using System.Text.Json.Serialization.Metadata;

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

    public GraduateStudent(
        string Name, 
        int Age, 
        string Email, 
        int PhoneNumber, 
        string Department, 
        string Gender, 
        string ResearchTopic
        )
        : base(Name, Age, Email, PhoneNumber, Department, Gender)
    {
        this._ResearchTopic = ResearchTopic;
    }

    public override void DisplayStudentInformation()
    {
        Console.WriteLine($"Student ID: {this.StudentID} \nName: {this._Name} \nAge: {this.Age} \nPhone Number: {this.PhoneNumber}" +
                          $"\nDepartment: {this._Department} \nGender: {this._Gender} \nResearch Topic: {this._ResearchTopic}");
    }
}

public class SMS
{
    public static void StudentManagementSystem()
    {
        Console.WriteLine("Welcome to the Student Registration Portal");
        Console.WriteLine("Do you wish to register a student?");
        string registerStudent = Console.ReadLine();

        if (registerStudent == "yes".ToLower())
        {
        StartReg:
            Console.WriteLine("How many students do you wish to register?");
            bool tryStudentNumber = int.TryParse(Console.ReadLine(), out int studentNumber);

            if (!tryStudentNumber)
            {
                Console.WriteLine("Invalid input");
                goto StartReg;
            }
            else
            {
                for (int i = 1; i <= studentNumber; i++)
                {
                    Console.WriteLine($"Fill in the details for student {i}:");
                    Console.Write("Name: ");
                    string Name = Console.ReadLine();

                    Console.Write("Age");
                    bool tryAge = int.TryParse(Console.ReadLine(), out int Age);

                    if (tryAge)
                    {
                        Console.Write("Phone number:");
                        bool tryPhone = int.TryParse(Console.ReadLine(), out int PhoneNumber);

                        if (tryPhone)
                        {
                            Console.WriteLine("Email");
                            string Email = Console.ReadLine();

                            Console.WriteLine("Department");
                            string Department = Console.ReadLine();

                            Console.WriteLine("Gender");
                            string Gender = Console.ReadLine();
                        }
                    }
                }
            }
        }
    }
}

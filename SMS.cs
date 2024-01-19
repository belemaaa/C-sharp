using System.Text.Json.Serialization.Metadata;

namespace CSHARPTUTORIAL;

public class Student
{
    // private static int _lastID = 1;
    private Guid _StudentID;
    public string _Name;
    private int _Age;
    public string _PhoneNumber;
    public string _Email;
    public string _Department;
    public string _Gender;

    public Student(string Name, int Age, string Email, string PhoneNumber, string Department, string Gender)
    {
        this._StudentID = Guid.NewGuid();
        this._Name = Name;
        this.Age = Age;
        this._Email = Email;
        this._PhoneNumber = PhoneNumber;
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

    public Guid StudentID
    {
        get { return _StudentID; }
    }

    public virtual void DisplayStudentInformation()
    {
        Console.WriteLine($"Student ID: {this._StudentID} \nName: {this._Name} \nAge: {this.Age} \nPhone Number: {this._PhoneNumber}" +
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
        string PhoneNumber,
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
        Console.WriteLine($"Student ID: {this.StudentID} \nName: {this._Name} \nAge: {this.Age} \nPhone Number: {this._PhoneNumber}" +
                          $"\nDepartment: {this._Department} \nGender: {this._Gender} \nResearch Topic: {this._ResearchTopic}");
    }
}

public class SMS
{
    public static void StudentManagementSystem()
    {
        Console.WriteLine("Welcome to the Student Registration Portal");
        Console.WriteLine("Do you wish to register a student?");
        string? registerStudent = Console.ReadLine();

        if (registerStudent == "yes".ToLower())
        {
            Console.WriteLine("What type of student do you wish to register? \n1. Regular student \n2. Graduate student");
            bool tryStudentType = int.TryParse(Console.ReadLine(), out int StudentType);

            if (tryStudentType)
            {
            StartReg:
                Console.WriteLine("How many students do you wish to register?");
                bool tryStudentNumber = int.TryParse(Console.ReadLine(), out int studentNumber);

                // array to store all students data
                Student[] Students = new Student[studentNumber];
                GraduateStudent[] GraduateStudents = new GraduateStudent[studentNumber];

                if (!tryStudentNumber)
                {
                    Console.WriteLine("Invalid input");
                    goto StartReg;
                }
                else
                {
                    for (int i = 0; i < studentNumber; i++)
                    {
                        Console.WriteLine($"Fill in the details for student {i + 1}:");
                        Console.Write("Name: ");
                        string? Name = Console.ReadLine();

                    StartAge:
                        Console.Write("Age: ");
                        bool tryAge = int.TryParse(Console.ReadLine(), out int Age);

                        if (tryAge)
                        {
                            Console.Write("Phone number: ");
                            string? PhoneNumber = Console.ReadLine();

                            Console.Write("Email: ");
                            string? Email = Console.ReadLine();

                            Console.Write("Department: ");
                            string? Department = Console.ReadLine();

                            Console.Write("Gender: ");
                            string? Gender = Console.ReadLine();

                            if (StudentType == 2)
                            {
                                Console.Write("Research Topic: ");
                                string? ResearchTopic = Console.ReadLine();

#pragma warning disable CS8604 // Possible null reference argument.
                                GraduateStudent Student = new GraduateStudent(
                                    Name, Age, Email, PhoneNumber, Department, Gender, ResearchTopic
                                );
#pragma warning restore CS8604 // Possible null reference argument.
                                GraduateStudents[i] = Student;
                            }
                            else if (StudentType == 1)
                            {
#pragma warning disable CS8604 // Possible null reference argument.
                                Student Student = new Student(
                                    Name, Age, Email, PhoneNumber, Department, Gender
                                );
#pragma warning restore CS8604 // Possible null reference argument.
                                Students[i] = Student;
                            }

                        }
                        else
                        {
                            Console.WriteLine("Invalid value for age");
                            goto StartAge;
                        }
                    }
                    Console.WriteLine("\n\nSTUDENT DETAILS ENTERED:");
                    Console.WriteLine("---------------------------");
                    if (StudentType == 1)
                    {
                        for (int j = 0; j < Students.Length; j++)
                        {
                            Console.WriteLine("\nStudents");
                            Console.WriteLine($"StudentID: {Students[j].StudentID} \nName: {Students[j]._Name} \nAge: {Students[j].Age}" +
                                $"\nPhone number: {Students[j]._PhoneNumber} \nEmail: {Students[j]._Email} \nDepartment: {Students[j]._Department} \nGender: {Students[j]._Gender}");
                        }
                    }
                    else
                    {
                        for (int j = 0; j < GraduateStudents.Length; j++)
                        {
                            Console.WriteLine("Students");
                            Console.WriteLine($"StudentID: {GraduateStudents[j].StudentID} \nName: {GraduateStudents[j]._Name} \nAge: {GraduateStudents[j].Age}" +
                                $"\nPhone number: {GraduateStudents[j]._PhoneNumber} \nEmail: {GraduateStudents[j]._Email} \nDepartment: {GraduateStudents[j]._Department}" +
                                $"\nGender: {GraduateStudents[j]._Gender} \nResearch topic: {GraduateStudents[j]._ResearchTopic}");
                        }
                    }
                }
            }
        }


    }
}

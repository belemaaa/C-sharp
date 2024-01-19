namespace CSHARPTUTORIAL;


public class Students
{
    private int _ID;
    private string _Name;
    private int _PassMark = 35;

    public int ID
    {
        set
        {
            if (value <= 0)
            {
                throw new Exception("Student ID cannot be negative");
            }
            this._ID = value;
        }
        get
        {
            return _ID;
        }
    }

    public string Name{
        set{
            if (string.IsNullOrEmpty(value)){
                throw new Exception("Name value cannot be null or empty");
            }
            this._Name = value;
        }
        get{
            if (string.IsNullOrEmpty(this._Name)){
                return "No Name";
            }
            else{
                return this._Name;
            }   
        }
    }

    public int PassMark{
        get{
            return this._PassMark;
        }
    }
}

public class Properties
{
    public static void PropertiesOps()
    {
        Students s1 = new Students();
        s1.ID = 9;
        Console.WriteLine($"Name: {s1.Name} ");
    }
}
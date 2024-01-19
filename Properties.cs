namespace CSHARPTUTORIAL;


public class Students
{
    private int _ID;
    private string? _Name;
    private int PassMark = 35;

    public int ID{
        set{
            if (value <= 0){
                throw new Exception("Student ID cannot be negative");
            }
            this._ID = value;
        }
        get {
            return _ID;
        }
    }

    public string Name{
        set{
            if (value == null || value == ""){
                throw new Exception("Name cannot be null");
            }
            this._Name = value;
        }
        get{
            return _Name;
        }
    }
} 

public class Properties
{
    public static void PropertiesOps()
    {
        Students s1 = new Students();
        s1.ID = 9;

        Console.WriteLine(s1.ID);
    }
}
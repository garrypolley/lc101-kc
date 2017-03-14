namespace Fun {
public class Student {

    private string name;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public override string ToString()
    {
        return string.Format("{0}", name);
    }

}
}
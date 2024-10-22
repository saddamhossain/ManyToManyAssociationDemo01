namespace ManyToManyAssociationDemo01;

public class Course
{
    public string Title { get; private set; }
    public string Code { get; private set; }
    public double Credit { get; private set; }

    public Course(string title, string code, double credit)
    {
        Title = title;
        Code = code;
        Credit = credit;
    }
}

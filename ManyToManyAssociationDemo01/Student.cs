namespace ManyToManyAssociationDemo01;

public class Student
{
    public string Name { get; private set; }
    public string Id { get; private set; }
    public int Age { get; private set; }

    public Student(string name, string id, int age)
    {
        Name = name;
        Id = id;
        Age = age;
    }
}

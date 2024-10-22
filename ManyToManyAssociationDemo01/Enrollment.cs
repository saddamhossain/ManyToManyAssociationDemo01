namespace ManyToManyAssociationDemo01;

public class Enrollment
{
    public Course Course { get; private set; }
    public Student Student { get; private set; }
    public DateTime EnrollmentDate { get; private set; }

    public Enrollment(Student student, Course course, DateTime enrollmentDate)
    {
        Student = student;
        Course = course;
        EnrollmentDate = enrollmentDate;
    }
}

namespace ManyToManyAssociationDemo01;

public class EnrollmentCollection
{
    private const int MaxStudentsPerCourse = 30;

    private List<Enrollment> enrollments = new List<Enrollment>();

    public bool AddEnrollment(Enrollment enrollment)
    {
        int studentsInCourse = GetStudentCountInCourse(enrollment.Course);

        if (studentsInCourse < MaxStudentsPerCourse)
        {
            enrollments.Add(enrollment);
            return true;
        }
        return false;
    }

    private int GetStudentCountInCourse(Course course)
    {
        return enrollments.Count(e => e.Course == course);
    }

    public List<Enrollment> GetAllEnrollments()
    {
        return enrollments.ToList();
    }
}

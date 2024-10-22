Student student1 = new Student("Dolon", "12345", 20);
Student student2 = new Student("Jami", "67890", 22);

Course course1 = new Course("C#", "C#101", 3.0);
Course course2 = new Course("C++", "C++101", 4.0);

// Create Enrollments
Enrollment enrollment1 = new Enrollment(student1, course1, new DateTime(2024, 8, 7));
Enrollment enrollment2 = new Enrollment(student1, course2, new DateTime(2024, 8, 8));
Enrollment enrollment3 = new Enrollment(student2, course1, new DateTime(2024, 5, 27));
Enrollment enrollment4 = new Enrollment(student2, course2, new DateTime(2024, 5, 7));

// Create Enrollment Collection and Add Enrollments
EnrollmentCollection enrollmentCollection = new EnrollmentCollection();
enrollmentCollection.AddEnrollment(enrollment1);
enrollmentCollection.AddEnrollment(enrollment2);
enrollmentCollection.AddEnrollment(enrollment3);
enrollmentCollection.AddEnrollment(enrollment4);

// Print out all enrollments using manual string formatting
foreach (Enrollment enrollment in enrollmentCollection.GetAllEnrollments())
{
    Console.WriteLine($"{enrollment.Student.Name} is enrolled in {enrollment.Course.Title} on {enrollment.EnrollmentDate.ToShortDateString()}");
}
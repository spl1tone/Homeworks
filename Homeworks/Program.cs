namespace Homeworks;

internal class Program
{
    static void Main (string[] args)
    {
        School school = new School("Some School");
        Subjects subject = new Subjects("Math");
        Teacher teacher = new Teacher(1, "Olga", "Vasilevna", "olga@gmail.com", "12345",subject);
        Console.WriteLine(teacher.TeacherInfo());
        Course course = new Course(1, "Some Course", "Some Description about whis course",teacher);
        Students student = new Students(1,"Vlad", "Levon","levonvlad@gmail.com","54321",course);
        Console.WriteLine(course.CourseInfo());
        Class @class = new Class("10A",teacher,student);
        @class.CreateSchedule(new DateTime(2023, 07, 13,8,30,0), new DateTime(2023, 07, 13,15,40,0));

        school.AddStudent(student);
        school.AddTeacher(teacher);
        school.AddClass(@class);
        school.AddSubject(subject);
            

    }

}
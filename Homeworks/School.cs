﻿namespace Homeworks;

record School
{
    public string SchoolName { get; set; } = "Default School Name";

    public List<Class> Classes { get; set; } = new();
    public List<Teacher> Teachers { get; set; } = new();
    public List<Students> Students { get; set; } = new();
    public List<Subjects> Subjects { get; set; } = new();

    public School ()
    {

    }
    public School (string schoolName)
    {
        SchoolName = schoolName;
    }
    public void AddStudent (Students student)
    {
        Students.Add(student);
    }
    public void RemoveStudent (Students student)
    {
        Students.Remove(student);
    }
    public void AddTeacher (Teacher teacher)
    {
        Teachers.Add(teacher);
    }
    public void RemoveTeacher (Teacher teacher)
    {
        Teachers.Remove(teacher);
    }

    public void AddClass (Class @class)
    {
        Classes.Add(@class);
    }
    public void RemoveClass (Class @class)
    {
        Classes.Remove(@class);
    }
    public void AddSubject (Subjects subject)
    {
        Subjects.Add(subject);
    }
    public void RemoveSubject (Subjects subject)
    {
        Subjects.Remove(subject);
    }
}

record Class
{
    public string ClassName { get; set; } = "Default Class Name";
    public Teacher Teacher { get; set; } = new();
    public List<Students> Students { get; set; } = new();

    public Class ()
    {

    }

    public Class (string name, Teacher teacher)
    {
        ClassName = name;
        Teacher = teacher;
    }
    public Class (string name, Teacher teacher, Students students)
    {
        ClassName = name;
        Teacher = teacher;
        Students.Add(students);
    }
    public Class (string name, Teacher teacher, List<Students> students)
    {
        ClassName = name;
        Teacher = teacher;
        Students = students;
    }

    public void AddStudents (Students student)
    {
        Students.Add(student);
    }
    public void RemoveStudents (Students student)
    {
        Students.Remove(student);
    }

    public void CreateSchedule (Class @class, DateTime startTime, DateTime endTime)
    {
        Console.WriteLine($"For class: {@class.ClassName}, lessons starts at {startTime.ToString()}, and ends at {endTime.ToString()}");
    }

}

record Teacher
{
    string pwd;
    public int Id { get; set; } = 1;
    public string FirstName { get; set; } = "Default Teacher Name";
    public string LastName { get; set; } = "Default Teacher Last Name";
    public string Email { get; set; } = "defaultTeacher@mail.com";
    public string Password
    {
        get { return pwd; }
        set
        {
            int i = 0;
            foreach (char c in pwd) {
                i++;
            }
            if (i < 4) {
                Console.WriteLine("Password must be more than 4 characters");
            }
            else {
                value = pwd;
            }
        }
    }
    public Subjects Subject { get; set; } = new();

    public Teacher ()
    {

    }

    public Teacher (string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public Teacher (int id, string firstName, string lastName, string email, string password)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Password = password;
    }

    public void UpdateTeacherInf (Teacher teacher, string newFirstName, string newLastName, Subjects newSubject)
    {
        teacher.FirstName = newFirstName;
        teacher.LastName = newLastName;
        teacher.Subject = newSubject;
    }
}

record Students
{
    string pwd;
    public int Id { get; set; } = 1;
    public string FirstName { get; set; } = "Default Student Name";
    public string LastName { get; set; } = "Default Student Last Name";
    public string Email { get; set; } = "defaultStudent@mail.com";
    public string Password
    {
        get { return pwd; }
        set
        {
            int i = 0;
            foreach (char c in pwd) {
                i++;
            }
            if (i < 4) {
                Console.WriteLine("Password must be more than 4 characters");
            }
            else {
                value = pwd;
            }
        }
    }
    public List<Course> Courses { get; set; } = new();

    public string GetFullNameStudent () => $"{FirstName} {LastName}";

    public Students ()
    {

    }

    public Students (string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
    public Students (string firstName, string lastName, Course course)
    {
        FirstName = firstName;
        LastName = lastName;
        Courses.Add(course);
    }
    public Students (string firstName, string lastName, List<Course> courses)
    {
        FirstName = firstName;
        LastName = lastName;
        Courses = courses;
    }
}

record Course
{
    public int Id { get; set; } = 1;
    public string CourseName { get; set; } = "Default Course";
    public string Description { get; set; } = "Default Description";
    public Teacher Teacher { get; set; } = new();
    public List<Module> Modules { get; set; } = new();
    public List<Students> Students { get; set; } = new();

    public Course ()
    {

    }
    public Course (int id, string courseName, string description)
    {
        Id = id;
        CourseName = courseName;
        Description = description;
    }
    public Course (int id, string courseName, string description, Teacher teacher, Module module, Students student)
    {
        Id = id;
        CourseName = courseName;
        Description = description;
        Teacher = teacher;
        Modules.Add(module);
        Students.Add(student);
    }
    public Course (int id, string courseName, string description, Teacher teacher, List<Module> modules, List<Students> students)
    {
        Id = id;
        CourseName = courseName;
        Description = description;
        Teacher = teacher;
        Modules = modules;
        Students = students;
    }

    public bool CourseEquals (Course course) =>
        Id == course.Id &&
        CourseName == course.CourseName &&
        Description == course.Description;
}

record Module
{
    public int Id { get; set; } = 1;
    public string ModuleName { get; set; } = "Default module";
    public Course Courses { get; set; } = new();
    public List<Assignment> Assignments { get; set; } = new();

    public Module ()
    {

    }
    public Module (int id, string moduleName)
    {
        Id = id;
        ModuleName = moduleName;
    }
    public Module (int id, string moduleName, Course course, Assignment assignment)
    {
        Id = id;
        ModuleName = moduleName;
        Courses = course;
        Assignments.Add(assignment);
    }
    public Module (int id, string moduleName, Course course, List<Assignment> assignments)
    {
        Id = id;
        ModuleName = moduleName;
        Courses = course;
        Assignments = assignments;
    }
}

record Assignment
{
    public int Id { get; set; } = 1;
    public string AssignmentName { get; set; } = "Default AssignmentName";
    public Module Module { get; set; } = new();

    public Assignment ()
    {

    }

    public Assignment (int id, string assignmentName)
    {
        Id = id;
        AssignmentName = assignmentName;
    }
    public Assignment (int id, string assignmentName, Module module)
    {
        Id = id;
        AssignmentName = assignmentName;
        Module = module;
    }
}

record Subjects
{
    public string SubjectName { get; set; } = "Default Subject";
    public Teacher Teacher { get; set; } = new();

    public Subjects ()
    {

    }

    public Subjects (string subjectName)
    {
        SubjectName = subjectName;
    }
    public Subjects (string subjectName, Teacher teacher)
    {
        SubjectName = subjectName;
        Teacher = teacher;
    }
}
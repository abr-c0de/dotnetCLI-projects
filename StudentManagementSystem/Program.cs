
using StdManagementSys;

StudentRepository student = new StudentRepository();
CourseRepository course = new CourseRepository();

EnrollmentManagement enrollmentManagement = new EnrollmentManagement();


while (true)
{
    Console.WriteLine("\n******************************************STUDENT MANAGEMENT SYSTEM*************************************************\n" +
        "\n---------------Admin Dashbord--------------\n");

    Console.WriteLine($"\n Press 1 to Add Student\n Press 2 to Add a New Course\n Press 3 to Enroll Student in a Course\n" +
        $"\n Press 4 to Remove Student From a Course\n Press 5 to Remove Student From all Courses\n Press 6 to Delete a Course\n" +
        $"\n Press 7 to Get List of Students and Courses\n Press 8 to Delete Student\n Press 9 to Exit");

    Console.WriteLine("\n------------------------------************************************************-------------------------------------\n");

    Console.WriteLine("\nEnter Your Choice: ");

    switch (Console.ReadLine())
    {
        case "1": AddStudent(); break;
        case "2": AddCourse(); break;
        case "3": EnrollStudent(); break;
        case "4": RemoveStudentFromCourse(); break;
        case "5": RemoveStudentFromAllCourse(); break;
        case "6": DeleteCourse(); break;
        case "7": ListStudents(); break;
        case "8": DeleteStudent(); break;
        case "9": return;
        default: Console.WriteLine("Invalid Choice Please Try Again!"); break;

    }
}

 void AddStudent()
{
    Console.WriteLine("Enter the name: ");
    string Name = Console.ReadLine();

    Console.WriteLine("Enter the Age: ");
    int Age = int.Parse(Console.ReadLine());

    int Id = Utility.getStdId();

    student.Add(new Student(Id, Name,Age));

    Console.WriteLine("New Student Added.\n");

}

void AddCourse()
{
    Console.WriteLine("Enter Course Title: ");
    string Title = Console.ReadLine();

    Console.WriteLine("Duration of the Course: ");
    string Duration = Console.ReadLine();

    int id = Utility.getCrsId();

    course.Add(new Course(id, Title,Duration));

    Console.WriteLine("New Course Added.\n");

}

void EnrollStudent()
{

    Console.WriteLine("Enter Student ID : ");

    int studentid = int.Parse(Console.ReadLine());

    Console.WriteLine("Enter Course ID : ");

    int courseid = int.Parse(Console.ReadLine());


    if(student.GetById(studentid) != null && course.GetById(courseid) != null)
    {
        enrollmentManagement.Enroll(studentid, courseid);

        Console.WriteLine("Student added successfully to this course.\n");

    }
    else
    {
        Console.WriteLine("Invalid Id's");
    }

    

}

void RemoveStudentFromCourse()
{
    Console.WriteLine("Enter Student ID : ");

    int studentid = int.Parse(Console.ReadLine());

    Console.WriteLine("Enter Course ID : ");

    int courseid = int.Parse(Console.ReadLine());

    enrollmentManagement.UnEnroll(studentid, courseid);

    Console.WriteLine("Student successfully removed from this course.\n");

}
void RemoveStudentFromAllCourse()
{
    Console.WriteLine("Enter Student ID : ");
    int studentid = int.Parse(Console.ReadLine());

    enrollmentManagement.RemoveStudentFromAllCourse(studentid);
    Console.WriteLine("Student Removed from all courses.\n");

}
void DeleteCourse()
{
    Console.WriteLine("Enter Course ID : ");

    int courseid = int.Parse(Console.ReadLine());
    course.Delete(courseid);

    Console.WriteLine("Course Deleted.\n");

}

void DeleteStudent()
{
    Console.WriteLine("Enter Student ID : ");
    int studentid = int.Parse(Console.ReadLine());

    student.Delete(studentid);
    enrollmentManagement.RemoveStudentFromAllCourse(studentid);
    Console.WriteLine("Student Deleted Successfully.\n");

}
void ListStudents()
{
    Console.WriteLine("\n*****************List of courses enrolled by Each Student***************\n");

    foreach (var std in student.GetAll())
    {
        Console.WriteLine(std);

        var Corids = enrollmentManagement.GetCoursesByStudent(std.Id);

        foreach (var c in Corids)
        {
            var C = course.GetById(c);
            Console.WriteLine($"Enrolled In : {C.Title}\n");
        }
    }



}
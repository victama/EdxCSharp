using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdxConsoleApplication
{

    /**
     * Student information, such as: First Name, Last Name, Birthdate, Address
     */
    public class Student
    {
        // public static class variable with number of Student instances
        public static int Enrolled { get; set; }

        // private fields
        private string firstName;
        private string lastName;
        private DateTime birthdate;
        private string address;

        // properties encapsulating fields
        public string FirstName { get { return firstName; } set { firstName = value; } }
        public string LastName { get { return lastName; } set { lastName = value; } }
        public DateTime Birthdate { get { return birthdate; } set { birthdate = value; } }
        public string Address { get { return address; } set { address = value; } }

        public Student(string firstName, string lastName, DateTime birthdate, string address)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Birthdate = birthdate;
            this.Address = address;
            Enrolled++;
        }
    }

    /**
     * Teacher information with pertinent fields
     */
    public class Teacher
    {
        // private fields
        private string firstName;
        private string lastName;
        private DateTime birthdate;
        private string address;

        // properties encapsulating fields
        public string FirstName { get { return firstName; } set { firstName = value; } }
        public string LastName { get { return lastName; } set { lastName = value; } }
        public DateTime Birthdate { get { return birthdate; } set { birthdate = value; } }
        public string Address { get { return address; } set { address = value; } }

        public Teacher(string firstName, string lastName, DateTime birthdate, string address)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Birthdate = birthdate;
            this.Address = address;
        }
    }

    /**
     * Information for a course that would be part of your selected degree and program, with pertinent fields
     */
    public class Course
    {
        // private fields
        private string name;
        private string description;
        private int credits;
        private Degree degree;
        private bool hasStarted;

        private Student[] students;
        private Teacher[] teachers;

        // properties encapsulating fields
        public string Name { get { return name; } set { name = value; } }
        public string Description { get { return description; } set { description = value; } }
        public int Credits { get { return credits; } set { credits = value; } }
        public Degree Degree { get { return degree; } set { degree = value; } }
        public bool HasStarted { get { return hasStarted; } set { hasStarted = value; } }

        public Course(string name, string description, int credits, bool hasStarted)
        {
            this.Name = name;
            this.Description = description;
            this.Credits = credits;
            this.HasStarted = hasStarted;
        }

        public bool AddStudent(Student student)
        {
            if (student == null) throw new ArgumentNullException();
            if (students == null) students = new Student[3];
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i] == null)
                {
                    students[i] = student;
                    return true;
                }
            }
            return false;
        }

        public bool AddTeacher(Teacher teacher)
        {
            if (teacher == null) throw new ArgumentNullException();
            if (teachers == null) teachers = new Teacher[3];
            for (int i = 0; i < teachers.Length; i++)
            {
                if (teachers[i] == null)
                {
                    teachers[i] = teacher;
                    return true;
                }
            }
            return false;
        }
    }

    /**
     * A university degree with pertinent fields
     */
    public class Degree
    {
        // private fields
        private string name;
        private string description;
        private int credits;
        private Course course;

        // properties encapsulating fields
        public string Name { get { return name; } set { name = value; } }
        public string Description { get { return description; } set { description = value; } }
        public int Credits { get { return credits; } set { credits = value; } }
        public Course Course { get { return course; } set { course = value; } }

        public Degree(string name, string description, int credits)
        {
            this.Name = name;
            this.Description = description;
            this.Credits = credits;
        }
    }

    /**
     * A university program with pertinent fields
     */
    public class UProgram
    {
        // private fields
        private string name;
        private Teacher headDepartment;
        private Degree degree;

        // properties encapsulating fields
        public string Name { get { return name; } set { name = value; } }
        public Degree Degree { get { return degree; } set { degree = value; } }
        public Teacher HeadDepartment { get { return headDepartment; } set { headDepartment = value; } }

        public UProgram(string name, Teacher headDepartment)
        {
            this.Name = name;
            this.HeadDepartment = headDepartment;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Variable definition
            Teacher teacher;
            Course course;
            Degree degree;
            UProgram program;

            // Variable initialization
            course = new Course("Programming with C#", "Let's learn to program in C# with M$!", 40, true);
            for (int i = 0; i < 3; i++)
            {
                int humanCardinal = i + 1;
                Student student = new Student("Student " + humanCardinal, "Fullname", new DateTime(1982, 12, humanCardinal), "5C, 46, Mieses Street, Cadiz, Spain");
                course.AddStudent(student);
            }
            teacher = new Teacher("Valeria", "Mazza", new DateTime(1972, 2, 17), "69, Calle del Rosario, Santa Fe, Argentina");
            course.AddTeacher(teacher);
            degree = new Degree("Bachelor of Science", "Bachelor's degree for this exercise", 240);
            degree.Course = course;
            course.Degree = degree;
            program = new UProgram("Information Technology", teacher);
            program.Degree = degree;

            // Using Console.WriteLine statements, output the following information to the console window:
            // - The name of the program and the degree it contains
            // - The name of the course in the degree
            // - The count of the number of students in the course.
            PrintDetails(program);

            // Warn user about finalization and wait...
            Console.Write("Press any key to continue . . .");
            Console.ReadKey();
        }

        static void PrintDetails(UProgram program)
        {
            Console.WriteLine();
            Console.WriteLine("The {0} program contains the {1} degree", program.Name, program.Degree.Name);
            Console.WriteLine();
            Console.WriteLine("The {0} degree contains the course {1}", program.Degree.Name, program.Degree.Course.Name);
            Console.WriteLine();
            Console.WriteLine("The {0} course contains {1} student(s)", program.Degree.Course.Name, Student.Enrolled);
            Console.WriteLine();
        }

    }
}

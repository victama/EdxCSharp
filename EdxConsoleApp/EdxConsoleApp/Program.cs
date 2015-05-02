using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * I preferred the use of inner classes instead of one file per class due to MOOC's upload system.
 * Grading Criteria critical points are commented with numbers in code, e.g.:
 * "private ArrayList students; // 1. Used an ArrayList of Students, inside the Course object."
 */
namespace EdxConsoleApplication
{
    /**
     * Person base class with common attributes for a person.
     */
    public class Person
    {
        // Private fields.
        private string firstName;
        private string lastName;
        private DateTime birthdate;
        private string address;

        // Properties encapsulating fields.
        public string FirstName { get { return firstName; } set { firstName = value; } }
        public string LastName { get { return lastName; } set { lastName = value; } }
        public DateTime Birthdate { get { return birthdate; } set { birthdate = value; } }
        public string Address { get { return address; } set { address = value; } }
    }

    /**
     * Student information, such as: First Name, Last Name, Birthdate, Address. Inherits from the Person base class.
     */
    public class Student : Person
    {
        // Public static class variable with number of Student instances.
        public static int Enrolled { get; set; }

        public Stack Grades { get; set; } // 2. Added a Stack called Grades inside the Student object.

        public Student(string firstName, string lastName, DateTime birthdate, string address)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Birthdate = birthdate;
            this.Address = address;
            this.Grades = new Stack();
            Enrolled++;
        }

        // Student might have a TakeTest() method.
        public void TakeTest()
        {
            Console.WriteLine("Student {0} {1} took a grade!", FirstName, LastName);
        }
    }

    /**
     * Teacher information with pertinent fields. Inherits from the Person base class.
     */
    public class Teacher : Person
    {
        public Teacher(string firstName, string lastName, DateTime birthdate, string address)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Birthdate = birthdate;
            this.Address = address;
        }

        // Teacher object might have a GradeTest() method.
        public void GradeTest()
        {
            Console.WriteLine("Teacher {0} {1} tested a grade!", FirstName, LastName);
        }
    }

    /**
     * Information for a course that would be part of your selected degree and program, with pertinent fields.
     */
    public class Course
    {
        // Private fields.
        private string name;
        private string description;
        private int credits;
        private Degree degree;
        private bool hasStarted;
        private ArrayList students; // 1. Used an ArrayList of Students, inside the Course object.
        private Teacher[] teachers;

        // Properties encapsulating fields.
        public string Name { get { return name; } set { name = value; } }
        public string Description { get { return description; } set { description = value; } }
        public int Credits { get { return credits; } set { credits = value; } }
        public Degree Degree { get { return degree; } set { degree = value; } }
        public bool HasStarted { get { return hasStarted; } set { hasStarted = value; } }
        public ArrayList Students { get { return students; } set { students = value; } }

        public Course(string name, string description, int credits, bool hasStarted)
        {
            this.Name = name;
            this.Description = description;
            this.Credits = credits;
            this.HasStarted = hasStarted;
            this.Students = new ArrayList();
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
     * A university degree with pertinent fields.
     */
    public class Degree
    {
        // Private fields.
        private string name;
        private string description;
        private int credits;
        private Course course;

        // Properties encapsulating fields.
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
     * A university program with pertinent fields.
     */
    public class UProgram
    {
        // Private fields.
        private string name;
        private Teacher headDepartment;
        private Degree degree;

        // Properties encapsulating fields.
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
            // variable definition
            Teacher teacher;
            Course course;
            Degree degree;
            UProgram program;

            // variable initialization
            course = new Course("Programming with C#", "Let's learn to program in C# with M$!", 40, true);
            Random seed = new Random();
            for (int i = 0; i < 3; i++)
            {
                int humanCardinal = i + 1;
                Student student = new Student("Student " + humanCardinal, "Fullname " + humanCardinal, new DateTime(1982, 12, humanCardinal), "5C, 46, Mieses Street, Cadiz, Spain");
                // add 5 grades to the the Stack in the each Student object
                for (int j = 0; j < 5; j++)
                {
                    double grade = Math.Round(seed.NextDouble() * 10.0, 2);
                    student.Grades.Push(grade);
                }
                course.Students.Add(student); // 3. Added 3 Student objects to this ArrayList using the ArrayList method for adding objects.
            }
            teacher = new Teacher("Valeria", "Mazza", new DateTime(1972, 2, 17), "69, Calle del Rosario, Santa Fe, Argentina");
            course.AddTeacher(teacher);
            degree = new Degree("Bachelor of Science", "Bachelor's degree for this exercise", 240);
            degree.Course = course;
            course.Degree = degree;
            program = new UProgram("Information Technology", teacher);
            program.Degree = degree;

            // using Console.WriteLine statements, output information to the console
            ListStudents(course);

            // warn user about finalization and wait...
            Console.Write("Press any key to continue . . .");
            Console.ReadKey();
        }

        static void ListStudents(Course course)
        {
            foreach (Object obj in course.Students) // 4. Used a foreach loop to output the first and last name of each Student in the ArrayList.
            {
                Student student = (Student)obj; // 5. Cast the object from the ArrayList to Student, inside the foreach loop, before printing out the name information.
                Console.WriteLine("Student's '{0} {1}' last grade was {2}", student.FirstName, student.LastName, student.Grades.Peek());
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * I preferred the use of inner classes instead of one file per class due to MOOC's upload system.
 * 
 * 7. Share your code for feedback and ideas with your fellow students such as:
 * 7.1. What other objects could benefit from inheritance in this code?
 * 
 * "Program", "Degree" and "Course" are all three "University Terms", and if we inspect their fields
 * we'll see at least "name" and "description" in common. We could create a "UniversityTerm" class
 * and make them inherit from it. We could even create a "CreditableEntity" class and make "Course"
 * and "Degree" inherit from it, because they have "credits" field in common.
 * 
 * In real life, this inheritance hierarchy would be an overkill, and we could probably give better
 * names to new classes suggested, but they are only to ilustrate my answer to this question.
 * 
 * 7.2. Can you think of a different hierarchy for the Person, Teacher, and Student?  What is it?
 * 
 * This hierarchy could be extended with the figure of a "HeadDepartment", field that was mentioned
 * possibly associated with a "UProgram". It should be a Teacher, so the hierarchy would be:
 * 
 * Student : Person (Student inherits from Person)
 * HeadDepartment : Teacher : Person (HeadDepartment inherits from Teacher, that inherits from Person)
 */
namespace EdxConsoleApplication
{
    /**
     * 1. Create a Person base class with common attributes for a person
     */
    public class Person
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
    }

    /**
     * Student information, such as: First Name, Last Name, Birthdate, Address.
     * 
     * 2. Make your Student and Teacher classes inherit from the Person base class
     */
    public class Student : Person
    {
        // public static class variable with number of Student instances
        public static int Enrolled { get; set; }

        // 3. Modify your Student and Teacher classes so that they inherit the common attributes from Person
        //    Attributes are available, as demonstrated by using them here
        public Student(string firstName, string lastName, DateTime birthdate, string address)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Birthdate = birthdate;
            this.Address = address;
            Enrolled++;
        }

        // 4. Modify your Student and Teacher classes so they include characteristics specific to their type.
        //    For example, a Student might have a TakeTest() method
        public void TakeTest()
        {
            Console.WriteLine("Student {0} {1} took a grade!", FirstName, LastName);
        }
    }

    /**
     * Teacher information with pertinent fields
     * 
     * 2. Make your Student and Teacher classes inherit from the Person base class
     */
    public class Teacher : Person
    {
        // 3. Modify your Student and Teacher classes so that they inherit the common attributes from Person
        //    Attributes are available, as demonstrated by using them here
        public Teacher(string firstName, string lastName, DateTime birthdate, string address)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Birthdate = birthdate;
            this.Address = address;
        }

        // 4. Modify your Student and Teacher classes so they include characteristics specific to their type.
        //    For example, a Teacher object might have a GradeTest() method
        public void GradeTest()
        {
            Console.WriteLine("Teacher {0} {1} tested a grade!", FirstName, LastName);
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

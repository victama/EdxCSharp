using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdxConsoleApplication
{

    /**
     * Student information, such as: First Name, Last Name, Birthdate, Address, City, State/Province, Zip/Postal, Country
     */
    public struct Student
    {
        public string firstName;
        public string lastName;
        public DateTime birthdate;
        public string address;
        public string city;
        public string stateOrProvince;
        public string zipCode;
        public string country;

        public Student(string firstName, string lastName, DateTime birthdate, string address, string city, string stateOrProvince, string zipCode, string country)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthdate = birthdate;
            this.address = address;
            this.city = city;
            this.stateOrProvince = stateOrProvince;
            this.zipCode = zipCode;
            this.country = country;
        }
    }

    /**
     * Professor information with pertinent fields
     */
    public struct Professor
    {
        public string firstName;
        public string lastName;
        public DateTime birthdate;
        public string address;
        public string city;
        public string stateOrProvince;
        public string zipCode;
        public string country;

        public Professor(string firstName, string lastName, DateTime birthdate, string address, string city, string stateOrProvince, string zipCode, string country)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthdate = birthdate;
            this.address = address;
            this.city = city;
            this.stateOrProvince = stateOrProvince;
            this.zipCode = zipCode;
            this.country = country;
        }
    }

    /**
     * Information for a course that would be part of your selected degree and program, with pertinent fields
     */
    public struct Course
    {
        public string name;
        public string description;
        public int credits;
        public string degree;
        public bool hasStarted;

        public Course(string name, string description, int credits, string degree, bool hasStarted)
        {
            this.name = name;
            this.description = description;
            this.credits = credits;
            this.degree = degree;
            this.hasStarted = hasStarted;
        }
    }

    /**
     * A university degree with pertinent fields
     */
    public struct Degree
    {
        public string name;
        public string description;
        public int credits;

        public Degree(string name, string description, int credits)
        {
            this.name = name;
            this.description = description;
            this.credits = credits;
        }
    }

    /**
     * A university program with pertinent fields
     */
    public struct UniversityProgram
    {
        public string name;
        public string degrees;
        public string headDepartment;

        public UniversityProgram(string name, string degrees, string headDepartment)
        {
            this.name = name;
            this.degrees = degrees;
            this.headDepartment = headDepartment;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Variable definition
            Student[] students;

            // Var initialization
            students = new Student[5];

            // Students info initialization (in loop, same data for all of them, but using loop index to distinguish)
            for (int i = 0; i < 5; i++)
            {
                int humanCardinal = i + 1;
                students[i] = new Student("Student " + humanCardinal, "Fullname", new DateTime(1982, 12, humanCardinal), "5C, 46, Mieses Street", "Cadiz", "Andalucia", "11111", "Spain");
            }

            // Students info visualization in console
            for (int i = 0; i < 5; i++)
            {
                PrintStudentDetails(students[i]);
            }

            // Warn user about finalization and wait...
            Console.Write("Press any key to close this window...");
            Console.ReadKey();
        }

        static void PrintStudentDetails(Student student)
        {
            Console.WriteLine();
            Console.WriteLine("Student information:");
            Console.WriteLine("Full name: {0} {1}", student.firstName, student.lastName);
            Console.WriteLine("Full address: {0}, {1}, {2}, {3}, {4}", student.address, student.zipCode, student.city, student.stateOrProvince, student.country);
            Console.WriteLine("Birthdate: {0}", student.birthdate);
            Console.WriteLine();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdxConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            GetStudentInfo();
            GetProfessorInfo();
            GetCourseInfo();
            GetDegreeInfo();
            GetProgramInfo();

            Console.Write("Press any key to close this window...");
            Console.ReadKey();

            ValidateBirthDate("");
        }

        static void GetStudentInfo()
        {
            // Student information, such as: First Name, Last Name, Birthdate, Address, City, State/Province, Zip/Postal, Country
            string firstName;
            string lastName;
            DateTime birthdate;
            string address;
            string city;
            string stateOrProvince;
            string zipCode;
            string country;

            Console.WriteLine("Enter the student's first name: ");
            firstName = Console.ReadLine();
            Console.WriteLine("Enter the student's last name: ");
            lastName = Console.ReadLine();
            Console.WriteLine("Enter the student's birth date: ");
            string birthdateStr = Console.ReadLine();
            birthdate = DateTime.Parse(birthdateStr);
            Console.WriteLine("Enter the student's address: ");
            address = Console.ReadLine();
            Console.WriteLine("Enter the student's city: ");
            city = Console.ReadLine();
            Console.WriteLine("Enter the student's state/province: ");
            stateOrProvince = Console.ReadLine();
            Console.WriteLine("Enter the student's zip code: ");
            zipCode = Console.ReadLine();
            Console.WriteLine("Enter the student's country: ");
            country = Console.ReadLine();

            PrintStudentDetails(firstName, lastName, address, zipCode, city, stateOrProvince, country, birthdate);
        }

        static void PrintStudentDetails(string first, string last, string address, string zipCode, string city, string stateOrProvince, string country, DateTime birthday)
        {
            Console.WriteLine();
            Console.WriteLine("Student information:");
            Console.WriteLine("Full name: {0} {1}", first, last);
            Console.WriteLine("Full address: {0}, {1}, {2}, {3}, {4}", address, zipCode, city, stateOrProvince, country);
            Console.WriteLine("Birthdate: {0}", birthday);
            Console.WriteLine();
        }

        static void GetProfessorInfo()
        {
            // Professor information with pertinent fields
            string firstName;
            string lastName;
            DateTime birthdate;
            string address;
            string city;
            string stateOrProvince;
            string zipCode;
            string country;

            Console.WriteLine("Enter the professor's first name: ");
            firstName = Console.ReadLine();
            Console.WriteLine("Enter the professor's last name: ");
            lastName = Console.ReadLine();
            Console.WriteLine("Enter the professor's birth date: ");
            string birthdateStr = Console.ReadLine();
            birthdate = DateTime.Parse(birthdateStr);
            Console.WriteLine("Enter the professor's address: ");
            address = Console.ReadLine();
            Console.WriteLine("Enter the professor's city: ");
            city = Console.ReadLine();
            Console.WriteLine("Enter the professor's state/province: ");
            stateOrProvince = Console.ReadLine();
            Console.WriteLine("Enter the professor's zip code: ");
            zipCode = Console.ReadLine();
            Console.WriteLine("Enter the professor's country: ");
            country = Console.ReadLine();

            PrintProfessorDetails(firstName, lastName, address, zipCode, city, stateOrProvince, country, birthdate);
        }

        static void PrintProfessorDetails(string first, string last, string address, string zipCode, string city, string stateOrProvince, string country, DateTime birthday)
        {
            Console.WriteLine();
            Console.WriteLine("Professor information:");
            Console.WriteLine("Full name: {0} {1}", first, last);
            Console.WriteLine("Full address: {0}, {1}, {2}, {3}, {4}", address, zipCode, city, stateOrProvince, country);
            Console.WriteLine("Birthdate: {0}", birthday);
            Console.WriteLine();
        }

        static void GetCourseInfo()
        {
            // Information for a course that would be part of your selected degree and program, with pertinent fields
            string name;
            string description;
            int credits;
            string degree;
            bool hasStarted;

            Console.WriteLine("Enter the course's name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter the course's description: ");
            description = Console.ReadLine();
            Console.WriteLine("Enter the course's credits: ");
            string creditsStr = Console.ReadLine();
            credits = Convert.ToInt32(creditsStr);
            Console.WriteLine("Enter the course's degree: ");
            degree = Console.ReadLine();
            Console.WriteLine("Has the course started? [Y/N] ");
            string hasStartedStr = Console.ReadLine();
            hasStarted = "Y".Equals(hasStartedStr) ? true : false;
            
            PrintCourseDetails(name, description, credits, degree, hasStarted);
        }

        static void PrintCourseDetails(string name, string description, int credits, string degree, bool hasStarted)
        {
            Console.WriteLine();
            Console.WriteLine("Course information:");
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Description: {0}", description);
            Console.WriteLine("Credits: {0}", credits);
            Console.WriteLine("Degree: {0}", degree);
            Console.WriteLine("Has started? {0}", hasStarted ? "Yes" : "No");
            Console.WriteLine();
        }

        static void GetDegreeInfo()
        {
            // A university degree with pertinent fields
            string name;
            string description;
            int credits;

            Console.WriteLine("Enter the degree's name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter the degree's description: ");
            description = Console.ReadLine();
            Console.WriteLine("Enter the degree's credits: ");
            string creditsStr = Console.ReadLine();
            credits = Convert.ToInt32(creditsStr);

            PrintDegreeDetails(name, description, credits);
        }

        static void PrintDegreeDetails(string name, string description, int credits)
        {
            Console.WriteLine();
            Console.WriteLine("Degree information:");
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Description: {0}", description);
            Console.WriteLine("Credits: {0}", credits);
            Console.WriteLine();
        }

        static void GetProgramInfo()
        {
            // A university program with pertinent fields
            string name;
            string degrees;
            string headDepartment;

            Console.WriteLine("Enter the program's name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter the program's degrees: ");
            degrees = Console.ReadLine();
            Console.WriteLine("Enter the program's head department: ");
            headDepartment = Console.ReadLine();

            PrintProgramDetails(name, degrees, headDepartment);
        }

        static void PrintProgramDetails(string name, string degrees, string headDepartment)
        {
            Console.WriteLine();
            Console.WriteLine("Program information:");
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Degrees: {0}", degrees);
            Console.WriteLine("Department Head: {0}", headDepartment);
            Console.WriteLine();
        }

        static void ValidateBirthDate(string birthdateStr)
        {
            throw new NotImplementedException();
        }
    }
}

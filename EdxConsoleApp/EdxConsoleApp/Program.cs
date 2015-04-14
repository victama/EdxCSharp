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
            // Student information, such as: First Name, Last Name, Birthdate, Address Line 1 and 2, City, State/Province, Zip/Postal, Country, etc...
            string studentFirstName;
            string studentLastName;
            DateTime studentBirthdate;
            string studentAddressLine1;
            string studentAddressLine2;
            string studentCity;
            string studentStateOrProvince;
            string studentZipCode;
            string studentCountry;
            int studentTelephoneNumber;
            string studentAwards;
            string studentNotes;

            // Professor information with pertinent fields
            string professorFirstName;
            string professorLastName;
            DateTime professorBirthdate;
            string professorAddressLine1;
            string professorAddressLine2;
            string professorCity;
            string professorStateOrProvince;
            string professorZipCode;
            string professorCountry;
            int professorTelephoneNumber;
            string professorCertifications;
            string professorNotes;

            // A university degree with pertinent fields
            string degreeName;
            string degreeDescription;
            int degreeCredits;

            // A university program with pertinent fields
            string programName;
            string programDegrees;
            string programHeadDepartment;

            // Information for a course that would be part of your selected degree and program, with pertinent fields
            string courseName;
            string courseDescription;
            int courseCredits;
            bool courseHasStarted;
            string courseDegree;

            // ASSIGN DATA
            studentFirstName = "Luis";
            studentLastName = "Gutierrez";
            studentBirthdate = DateTime.Parse("1982/12/12");
            studentAddressLine1 = "5C, 46, Mieses Street";
            studentAddressLine2 = "";
            studentCity = "Cadiz";
            studentStateOrProvince = "Andalucia";
            studentZipCode = "11111";
            studentCountry = "Spain";
            studentTelephoneNumber = 654987321;
            studentAwards = "Promotion's first";
            studentNotes = "Smooth criminal";

            professorFirstName = "Valeria";
            professorLastName = "Mazza";
            professorBirthdate = DateTime.Parse("1966/06/06");
            professorAddressLine1 = "128, Huxley Avenue";
            professorAddressLine2 = "";
            professorCity = "London";
            professorStateOrProvince = "London";
            professorZipCode = "W12";
            professorCountry = "United Kingdom";
            professorTelephoneNumber = 645978312;
            professorCertifications = "Master of Puppets";
            professorNotes = "Son of the Great Britain";

            degreeName = "Bachelor of Science in Information Technology";
            degreeDescription = "The curriculum for Baker’s Computer Science program is based on guidance from industry professionals and updated continuously to prepare you for any one of a number of careers in today’s workplaces.";
            degreeCredits = 240;

            programName = "Computer Science or Arts";
            programDegrees = "Bachelor, Master, Ph.D.";
            programHeadDepartment = "Valeria Mazza";

            courseName = "Computer Science 101";
            courseDescription = "CS101 teaches the essential ideas of Computer Science for a zero-prior-experience audience. The course uses small coding experiments in the browser to play with the nature of computers, understanding their strengths and limitations. Sign up for the 'To be announced' session to be notified by email when the class is next run, and sign up for 'Self-Study' to start browsing the class materials right away. Self-Study mode makes all the videos and assignments available to be done at your own pace, but without a certificate of completion at the end.";
            courseCredits = 40;
            courseDegree = "Bachelor of Science in Information Technology";
            courseHasStarted = true;

            // PRINT DATA
            Console.WriteLine();
            Console.WriteLine("Student information:");
            Console.WriteLine("Full name: {0} {1}", studentFirstName, studentLastName);
            Console.WriteLine("Full address: {0} {1}, {2}, {3}, {4}, {5}", studentAddressLine1, studentAddressLine2, studentZipCode, studentCity, studentStateOrProvince, studentCountry);
            Console.WriteLine("Birthdate: {0}, Telephone: {1}, Awards: {2}, Notes: {3}", studentBirthdate, studentTelephoneNumber, studentAwards, studentNotes);

            Console.WriteLine();
            Console.WriteLine("Professor information:");
            Console.WriteLine("Full name: {0} {1}", professorFirstName, professorLastName);
            Console.WriteLine("Full address: {0} {1}, {2}, {3}, {4}, {5}", professorAddressLine1, professorAddressLine2, professorZipCode, professorCity, professorStateOrProvince, professorCountry);
            Console.WriteLine("Birthdate: {0}, Telephone: {1}, Certifications: {2}, Notes: {3}", professorBirthdate, professorTelephoneNumber, professorCertifications, professorNotes);

            Console.WriteLine();
            Console.WriteLine("Degree information:");
            Console.WriteLine("Name: {0}", degreeName);
            Console.WriteLine("Description: {0}", degreeDescription);
            Console.WriteLine("Credits: {0}", degreeCredits);

            Console.WriteLine();
            Console.WriteLine("Program information:");
            Console.WriteLine("Name: {0}", programName);
            Console.WriteLine("Degrees: {0}", programDegrees);
            Console.WriteLine("Department Head: {0}", programHeadDepartment);

            Console.WriteLine();
            Console.WriteLine("Course information:");
            Console.WriteLine("Name: {0}", courseName);
            Console.WriteLine("Description: {0}", courseDescription);
            Console.WriteLine("Credits: {0}", courseCredits);
            Console.WriteLine("Degree: {0}", courseDegree);
            Console.WriteLine("Has started? {0}", courseHasStarted ? "Yes" : "No");

            Console.ReadKey();
        }
    }
}

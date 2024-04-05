using System;
using System.Collections.Generic;
using ClassSectionBL;

namespace ClassSection
{
    public class Program
    {
        static void Main(string[] args)
        {
            Section firstSection = new Section { sectionName = "BSIT 2-1" };

            Console.WriteLine($"\nAdd Student to Section: {firstSection.sectionName}");

            Students newStudent = new Students();
            //Input Students
            Console.Write("\nEnter the student name to add: ");
            String studName = Console.ReadLine();
            newStudent.studentName = studName;

            Console.Write("\nEnter the student number to add: ");
            String studNum = Console.ReadLine();
            newStudent.studentNumber = studNum;

            Console.Write("\nEnter the student GWA to add: ");
            String studGWA = Console.ReadLine();
            newStudent.GWA = studGWA;

            Students newStudent2 = new Students();
            Console.WriteLine("\nAdd Another Student: ");
            Console.Write("\nEnter the student name to add: ");
            String studName2 = Console.ReadLine();
            newStudent2.studentName = studName2;

            Console.Write("\nEnter the student number to add: ");
            String studNum2 = Console.ReadLine();
            newStudent2.studentNumber = studNum2;

            Console.Write("\nEnter the student GWA to add: ");
            String studGWA2 = Console.ReadLine();
            newStudent2.GWA = studGWA2;

            firstSection.AddStudent(newStudent); //ADD Method
            firstSection.AddStudent(newStudent2); //ADD Method

            Console.WriteLine("\nSearch Student:\n\nEnter the Last Name of the student to be searched: (Uppercase the first letter)");
            String lname = Console.ReadLine();
            bool studentFound = firstSection.SearchStudent(lname); //SEARCH Method

            if (studentFound)
            {
                Console.WriteLine($"\nStudent: {lname} is found");
            }
            else
            {
                Console.WriteLine($"\nStudent: {lname} cannot be found");
            }

            Console.WriteLine("\nBefore Removing a Student");

            DisplayStudents(firstSection.student);

            firstSection.DeleteStudent(newStudent); //DELETE Student Method

            Console.WriteLine("\nAfter Removing a Student");

            DisplayStudents(firstSection.student);

        }
        public static void DisplayStudents(List<Students> students)
        {
            foreach (var studs in students)//DISPLAY Students
            {
                Console.WriteLine($"\nStudent Name: {studs.studentName}\nStudent ID: {studs.studentNumber}\nGWA: {studs.GWA}");
            }
        }
    }
}

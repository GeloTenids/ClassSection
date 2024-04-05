using System;
using System.Collections.Generic;

namespace ClassSectionBL
{
    public class Section
    {
        public string sectionName;
        public List<Students> student = new List<Students>();//Create List

        public void AddStudent(Students aStudent)//ADD Student 
        {
            student.Add(aStudent);
        }

        public bool SearchStudent(string StudentName)//SEARCH student 
        {

            bool studentFound = new bool();
            foreach (var findStudent in student)
            {
                if (findStudent.studentName.Contains(StudentName))
                {
                    studentFound = true;
                    break;
                }
                else
                {
                    studentFound = false;
                }
            }
            return studentFound;
        }

        public void DeleteStudent(Students removeStudent) //Delete Student
        {
            student.Remove(removeStudent);
        }

    }
}

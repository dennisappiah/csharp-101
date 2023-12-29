using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance.Events.Models
{
    public class CollegeClassModel
    {
        public event EventHandler<string> EnrolmentFull;

        private List<string> enrolledStudents = new List<string>();
        private List<string> waitingList = new List<string>();

        public string CourseTitle { get; private set; }
        public int MaximumStudents { get; private set; }


        public CollegeClassModel(string courseTitle, int maximumStdents)
        {
            CourseTitle = courseTitle;
            MaximumStudents = maximumStdents;
        }

        public string SignUpStudent(string studentName)
        {
            string output = "";

            if (enrolledStudents.Count < MaximumStudents)
            {
                enrolledStudents.Add(studentName);

                output = $"{studentName} was enrolled in {CourseTitle} ";

                // check to see if we are maxed out (fire off event)
                if (enrolledStudents.Count == MaximumStudents)
                {
                    EnrolmentFull?.Invoke(this, $"{CourseTitle} is now full");

                }
               
            }
            else
            {
                waitingList.Add(studentName);
                output = $"{studentName} are on waiting list ";
            }

            return output;
        }


    }
}

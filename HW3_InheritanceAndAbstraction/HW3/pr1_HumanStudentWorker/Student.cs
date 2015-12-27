namespace pr1_HumanStudentWorker
{
    using System;
    using System.Text.RegularExpressions;

    public class Student : Human
    {
        private string _facultyNumber;

        public Student(string firstName, string lastName, string fNumber) : base(firstName, lastName)
        {
            this.FacultyNumber = fNumber;
        }

        public string FacultyNumber
        {
            get { return this._facultyNumber; }
            set 
            {
                Regex regex = new Regex(@"[0-9a-zA-Z]{5,10}");
                Match match = regex.Match(value);
                if (match.Success)
                {
                    this._facultyNumber = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("FacultyNumber", "FacultiNumber shout be 5-10 digits / letters");
                }
            }
        }


    }
}

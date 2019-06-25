using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
     class Student : PrivateSchool
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; } = new DateTime();
        public double _tuitionFees { get; set; }
        public string Course { get; set; }

        //Default Contractor 
        public Student()
        {
            ID = Students.Count;
            ID++;
            FirstName = "";
            LastName = "";
            _tuitionFees = 0;
        }

        //contractor
        public Student(int id,string first_name, string last_name, DateTime date_of_birth, double tuition_fees)
        {
            ID = id;
            FirstName = first_name;
            LastName = last_name;
            DateOfBirth = date_of_birth;
            _tuitionFees = tuition_fees;
        }

        //Get data
        public string GetFirstName(){  return FirstName; }

        public string GetLastName(){  return LastName;  }

        public DateTime GetDateOfBirth() { return DateOfBirth;  }

        public double GetTuitionFees(){ return _tuitionFees;  }

        //set data
        public void SetFirstName(string fname){ FirstName = fname;  }

        public void SetLastName(string lname){  LastName = lname;   }

        public void SetDateOfBirth(DateTime date_of_birth){   DateOfBirth = date_of_birth; }

        public void SetTuitionFees(double tuition_fees){   _tuitionFees = tuition_fees;  }

    }



    class Trainer:Student
    {
        public string Subject { get; set; }

        //contractor default
        public Trainer()
        {

            FirstName = "";
            LastName = "";
            Subject = "";
        }

        public Trainer(int id,string fname , string lname, string subject)
        {
            ID = id;
            FirstName = fname;
            LastName = lname;
            Subject = subject;
        }

    }
}

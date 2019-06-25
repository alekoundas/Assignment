using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class PrivateSchool
    {
        public List<Student> Students { get; set; } = new List<Student>();
        public List<Trainer> Trainers { get; set; } = new List<Trainer>();
        public List<Course> Courses { get; set; } = new List<Course>();
        public List<Assignment> Assignments { get; set; } = new List<Assignment>();
        public List<TrainersCourse> TrainersCourses { get; set; } = new List<TrainersCourse>();
        public List<StudentsCourse> StudentsCourses { get; set; } = new List<StudentsCourse>();
        public List<StudentsAssignment> StudentsAssignments { get; set; } = new List<StudentsAssignment>();


        //INPUT
        public void AddStudent(string fname, string lname, DateTime date, double tuition_fees)
        {
            int current_id = Students.Count + 1;
            var student = new Student(current_id, fname, lname, date, tuition_fees);
            Students.Add(student);
            PrivateSchool.OutputStudents(student);
        }

        public void AddTrainer(string fname, string lname, string subject)
        {
            int current_id = Trainers.Count + 1;
            var trainer = new Trainer(current_id, fname, lname, subject);
            Trainers.Add(trainer);
            PrivateSchool.OutputTrainer(trainer);
        }

        public void AddAssignments(string title, string desc, DateTime sub_date)
        {
            int current_id = Assignments.Count + 1;
            var assignment = new Assignment(current_id, title, desc, sub_date);
            Assignments.Add(assignment);
            PrivateSchool.OutputAssignments(assignment);
        }

        public void AddCource(string title, string stream, string type, DateTime start_date, DateTime end_date)
        {
            int current_id = Courses.Count + 1;
            var course = new Course(current_id, title, stream, type, start_date, end_date);
            Courses.Add(course);
            PrivateSchool.OutputCourses(course);

        }




        //OUTPUT
        public void OutputStudents()
        {
            int i = 1;
            Console.WriteLine("                                                      Students                                                            ");
            Console.WriteLine("_______________________________________________________________________________________________________________________\n");
            Console.WriteLine($"  {"No.",-4} |      {"Name",-10} |      {"Last Name",-15} | {"Birthday",-10} | {"Tuition",-10} | {"ID",-10}");
            Console.WriteLine("-------+-----------------+----------------------+------------+------------+-----");
            foreach (var item in Students)
            {

                Console.WriteLine($"  {i++,-4} |      {item.GetFirstName(),-10} |      {item.GetLastName(),-15} | {item.DateOfBirth.ToString("d/M/yyyy"),-10} | {item.GetTuitionFees(),-10} | {item.ID,-10}");
                Console.WriteLine("-------+-----------------+----------------------+------------+------------+-----");
            }
            if (Trainers.Count == 0)
            {
                Console.WriteLine("No Students Submited Yet!");
            }
            Console.WriteLine("\n\n");
        }
        private static void OutputStudents(Student Student)
        {
            Console.WriteLine("-----------------+----------------------+------------+------------+-----");
            Console.WriteLine($"      {Student.FirstName,-10} |      {Student.LastName,-15} | {Student.DateOfBirth.ToString("d/M/yyyy"),-10} | {Student._tuitionFees,-10} | {Student.ID,-10}");
            Console.WriteLine("-----------------+----------------------+------------+------------+-----");
        }




        public void OutputTrainer()
        {
            int i = 1;
            Console.WriteLine("                                                      Trainers                                                            ");
            Console.WriteLine("_______________________________________________________________________________________________________________________\n");
            Console.WriteLine($"  {"No.",-4} |      {"Name",-10} |      {"Last Name",-15} | {"Subject",-10} | {"ID",-10}");
            Console.WriteLine("-------+-----------------+----------------------+------------+-----");

            foreach (Trainer item in Trainers)
            {

                Console.WriteLine($"  {i++,-4} |      {item.FirstName,-10} |      {item.LastName,-15} | {item.Subject,-10} | {item.ID,-10}");
                Console.WriteLine("-------+-----------------+----------------------+------------+-----");
            }

            if (Trainers.Count == 0)
            {
                Console.WriteLine("No Courses Submited Yet!");
            }
            Console.WriteLine("\n\n");
        }
        private static void OutputTrainer(Trainer trainer)
        {
            Console.WriteLine("-----------------+----------------------+------------+-----");
            Console.WriteLine($"      {trainer.FirstName,-10} |      {trainer.LastName,-15} | {trainer.Subject,-10} | {trainer.ID,-10}");
            Console.WriteLine("-----------------+----------------------+------------+-----");
        }






        public void OutputCourses()
        {
            int i = 1;
            Console.WriteLine("                                                      Courses                                                            ");
            Console.WriteLine("_______________________________________________________________________________________________________________________\n");
            Console.WriteLine($"  {"No.",-4} |     {"Stream",-15}  |       {"Type",-10} | {"StartDate",-10} |   {"EndDate",-8}  |  {"ID",-10}");
            Console.WriteLine("-------+----------------------+------------------+------------+-------------+------");

            foreach (Course item in Courses)
            {
                Console.WriteLine($"  {i++,-4} |    {item.Stream,-15}   |       {item.Type,-8}   | {item.StartDate.ToString("dd/MM/yyyy"),-10} | {item.EndDate.ToString("dd/MM/yyyy"),-10}  |  {item.ID,-5}");
                Console.WriteLine("-------+----------------------+------------------+------------+-------------+------");
            }

            if (Courses.Count == 0)
            {
                Console.WriteLine("No Courses Submited Yet!");
            }
            Console.WriteLine("\n\n");
        }
        private static void OutputCourses(Course course)
        {
            Console.WriteLine("-----------------------+------------------+------------+-------------+------");
            Console.WriteLine($"     {course.Stream,-15}   |       {course.Type,-8}   | {course.StartDate.ToString("dd/MM/yyyy"),-10} | {course.EndDate.ToString("dd/MM/yyyy"),-10}  |  {course.ID,-5}");
            Console.WriteLine("-----------------------+------------------+------------+-------------+------");
        }







        public void OutputAssignments()
        {
            int i = 1;
            Console.WriteLine("                                                      Assignments                                                            ");
            Console.WriteLine("_______________________________________________________________________________________________________________________\n");
            Console.WriteLine($"  {"No.",-4} | {"Submition Date",-8}|   {"ID",-3} |  {"Description",+30}");
            Console.WriteLine("-------+---------------+-------+---------------------------------------------------------------------------");

            foreach (Assignment item in Assignments)
            {
                Console.WriteLine($"  {i++,-4} |   {item.SubDateTime.ToString("d/M/yyyy"),-5}    |   {item.ID}   |  {item.Description,-5}");
                Console.WriteLine("-------+---------------+-------+------------------------------------------------------------------------");
            }

            if (Assignments.Count == 0)
            {
                Console.WriteLine("No Assignments Submited Yet!");
            }
            Console.WriteLine("\n\n");

        }
        private static void OutputAssignments(Assignment assignment)
        {

            Console.WriteLine("----------------+-----+---------------------------------------------------------------------------");
            Console.WriteLine($"   {assignment.SubDateTime.ToString("dd/MM/yyyy"),-5}   |  {assignment.ID}  |  {assignment.Description,-5}");
            Console.WriteLine("----------------+-----+---------------------------------------------------------------------------");


        }








        public void OutputCoursesTrainers()
        {
            Console.WriteLine("                                            Courses To Trainers                                                            ");
            Console.WriteLine("_______________________________________________________________________________________________________________________\n");
            Console.WriteLine($"  {"No.",-4} |    {"Course Name",-8}     |  {"Trainer Name",-10} |  {"Last Name",-10}   |  {"Subject",-10} |  {"ID",+3}");
            Console.WriteLine("-------+--------------------+---------------+---------------+-------------+--------");
            int k = 1;
            for (int i = 0; i < TrainersCourses.Count; i++)
            {


                for (int j = 0; j < Courses.Count; j++)
                {
                    if (TrainersCourses[i].CourseUserData == Courses[j].ID)
                    {
                        foreach (var item in Trainers)
                        {
                            if (item.ID == TrainersCourses[i].TrainersUserData)
                            {
                                Console.WriteLine($"  {k++,-4} |   {Courses[TrainersCourses[i].CourseUserData - 1].Title,-8}   |      {item.FirstName,-8} |   {item.LastName,-10}  |  {item.Subject,-10} |  {item.ID,-5}");
                                Console.WriteLine("-------+--------------------+---------------+---------------+-------------+--------");


                            }
                        }
                    }
                }
            }
            if (TrainersCourses.Count == 0)
            {
                Console.WriteLine("No Courses Assigned yet Yet!");
            }
            Console.WriteLine("\n\n");
        }
        public void OutputCoursesStudents()
        {
            Console.WriteLine("                                            Courses To Students                                                            ");
            Console.WriteLine("_______________________________________________________________________________________________________________________\n");
            Console.WriteLine($"  {"No.",-4} |   {"Course Name",-8}    |  {"Name",-8} |  {"Last Name",-10} | {"Birthday",-10} | {"Tuition",-10} | {"ID",-10}");
            Console.WriteLine("-------+------------------+-----------+-------------+------------+------------+-----");
            int k = 1;
            for (int i = 0; i < StudentsCourses.Count; i++)
            {
                for (int j = 0; j < Courses.Count; j++)
                {
                    if (StudentsCourses[i].CourseUserData == Courses[j].ID)
                    {
                        foreach (var item in Students)
                        {
                            if (item.ID == StudentsCourses[i].StudentsUserData)
                            {
                                Console.WriteLine($"  {k++,-4} |   {Courses[StudentsCourses[i].CourseUserData - 1].Title,-10} |  {item.GetFirstName(),-8} |   {item.GetLastName(),-9} | {item.DateOfBirth.ToString("d/M/yyyy"),-10} | {item.GetTuitionFees(),-10} | {item.ID,-10}");
                                Console.WriteLine("-------+------------------+-----------+-------------+------------+------------+-----");
                            }
                        }
                    }
                }
            }
            if (StudentsCourses.Count == 0)
            {
                Console.WriteLine("No Courses Assigned yet Yet!");
            }
            Console.WriteLine("\n\n");
        }
        public void OutputAssignmentsStudents()
        {
            Console.WriteLine("                                            Assignments To Students                                                            ");
            Console.WriteLine("_______________________________________________________________________________________________________________________\n");
            Console.WriteLine($"  {"No.",-4} | {"Assignment Name",-8} |  {"Name",-8} |  {"Last Name",-10} | {"Birthday",-10} | {"Tuition",-10} | {"ID",-10}");
            Console.WriteLine("-------+-----------------+-----------+-------------+------------+------------+-----");
            int k = 1;
            for (int i = 0; i < StudentsAssignments.Count; i++)
            {
                for (int j = 0; j < Assignments.Count; j++)
                {
                    if (StudentsAssignments[i].AssignmentUserData == Assignments[j].ID)
                    {
                        foreach (var item in Students)
                        {
                            if (item.ID == StudentsAssignments[i].StudentsUserData)
                            {
                                Console.WriteLine($"  {k++,-4} |   {Assignments[StudentsAssignments[i].AssignmentUserData - 1].Title,-10}  |  {item.GetFirstName(),-8} |   {item.GetLastName(),-9} | {item.DateOfBirth.ToString("d/M/yyyy"),-10} | {item.GetTuitionFees(),-10} | {item.ID,-10}");
                                Console.WriteLine("-------+-----------------+-----------+-------------+------------+------------+-----");
                            }
                        }
                    }
                }
            }
            if (TrainersCourses.Count == 0)
            {
                Console.WriteLine("No Courses Assigned yet Yet!");
            }
            Console.WriteLine("\n\n");
        }

        public void OutputSubmitedAssignments(DateTime monday, DateTime sunday)
        {

            int k = 1;

            Console.WriteLine("_______________________________________________________________________________________________________________________\n");
            Console.WriteLine($"  {"No.",-4} | {"Submition Date",-8}  |  {"Oral Mark",-5} | {"Total Mark",-8} | {"ID",-3} |  {"Description",+30}");
            Console.WriteLine("-------+-----------------+------------+------------+-----+--------------------------------------------------------");

            for (int i = 0; i < StudentsAssignments.Count; i++)
            {
                for (int j = 0; j < Assignments.Count; j++)
                {
                    if (StudentsAssignments[i].AssignmentUserData == Assignments[j].ID)
                    {
                        if (monday <= StudentsAssignments[i].SubmitionDate && sunday > StudentsAssignments[i].SubmitionDate)
                        {
                            Console.WriteLine($"  {k++,-4} |   {Assignments[j].SubDateTime.ToString("dd/MM/yyyy"),-5}    |      {Assignments[j].OralMark,-5} |     {Assignments[j].TotalMark,-5}  |  {Assignments[j].ID}  |  {Assignments[j].Description,-5}");
                            Console.WriteLine("-------+-----------------+------------+------------+-----+--------+-----------------------------------------------");

                        }
                    }
                }
            }
            if (StudentsAssignments.Count == 0)
            {
                Console.WriteLine("No Students Assigned to Assignments Yet!");
            }
            Console.WriteLine("\n\n");
        }



        public void OutputStudentsTwoAssignments()
        {
            int[,] StudentCount = new int[Students.Count, 2];

            for (int i = 0; i < Students.Count; i++)
            {
                StudentCount[i, 0] = Students[i].ID;
                StudentCount[i, 1] = 0;
                for (int j = 0; j < StudentsAssignments.Count; j++)
                {
                    if (StudentsAssignments[j].StudentsUserData == Students[i].ID)
                    {
                        StudentCount[i, 1]++;
                    }
                }
            }

            int k = 1;
            Console.WriteLine("_______________________________________________________________________________________________________________________\n");
            Console.WriteLine($"  {"No.",-4} |      {"Name",-10} |      {"Last Name",-15} | {"Birthday",-10} | {"No. Of Assignments",-10} | {"ID",-10}");
            Console.WriteLine("-------+-----------------+----------------------+------------+--------------------+-----");
            for (int i = 0; i < Students.Count; i++)
            {
                if (StudentCount[i, 1] > 1)
                {
                    for (int j = 0; j < Students.Count; j++)
                    {
                        if (Students[j].ID == StudentCount[i, 0])
                        {
                            Console.WriteLine($"  {k++,-4} |      {Students[j].GetFirstName(),-10} |      {Students[j].GetLastName(),-15} | {Students[j].DateOfBirth.ToString("d/M/yyyy"),-10} | {StudentCount[i, 1],-18} | {Students[j].ID,-10}");
                            Console.WriteLine("-------+-----------------+----------------------+------------+--------------------+-----");
                        }
                    }
                }
            }
            if (StudentsAssignments.Count == 0)
            {
                Console.WriteLine("No Students Assigned to Assignments Yet!");
            }
            Console.WriteLine("\n\n");
        }
    }







    public class TrainersCourse
    {
        public int CourseUserData { get; set; }
        public int TrainersUserData { get; set; }

        public TrainersCourse(int course, int trainer)
        {
            CourseUserData = course;
            TrainersUserData = trainer;
        }

    }

    public class StudentsCourse
    {
        public int CourseUserData { get; set; }
        public int StudentsUserData { get; set; }

        public StudentsCourse(int course, int student)
        {
            CourseUserData = course;
            StudentsUserData = student;
        }
    }

    public class StudentsAssignment
    {
        public int AssignmentUserData { get; set; }
        public int StudentsUserData { get; set; }
        public DateTime SubmitionDate { get; set; } = new DateTime();

        public StudentsAssignment(int assignment, int student, DateTime dateTime)
        {
            AssignmentUserData = assignment;
            StudentsUserData = student;
            SubmitionDate = dateTime;
        }
    }
}

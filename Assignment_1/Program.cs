using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public class Program
    {






        static void Main(string[] args)
        {
            PrivateSchool CodingBootcamp = new PrivateSchool();
            CommonTools.SyntheticDataUserSelection(CodingBootcamp);
            UserMenuCase(CodingBootcamp);
        }







        //-----------------Intput For User------------------\\
        static void add_student(PrivateSchool CodingBootcamp)
        {

            string name = CommonTools.NameStudentInput();
            string lname = CommonTools.LastnameStudentInput();
            DateTime dateOfBirth = CommonTools.DateOfBirthStudentInput();
            double tuition_fees = CommonTools.TuitionStudentInput();


            CodingBootcamp.AddStudent(name, lname, dateOfBirth, tuition_fees);


        }

        //-----------------Intput For Trainer------------------\\
        static void add_teacher(PrivateSchool CodingBootcamp)
        {
            string name = CommonTools.NameTrainerInput();
            string lname = CommonTools.LastnameTrainerInput();
            string subject = CommonTools.SubjectTrainerInput();

            CodingBootcamp.AddTrainer(name, lname, subject);
        }
        //-----------------Intput For Course------------------\\
        static void add_course(PrivateSchool CodingBootcamp)
        {
            string title = CommonTools.TitleCourseInput();
            string stream = CommonTools.StreamCourseInput();
            string type = CommonTools.TypeCourseInput();
            DateTime StartDate = CommonTools.StartEndDateCourseInput(out DateTime EndDate);

            CodingBootcamp.AddCource(title, stream, type, StartDate, EndDate);
        }

        //-----------------Intput For Assignment------------------\\
        static void add_assignment(PrivateSchool CodingBootcamp)
        {
            string name = CommonTools.NameAssignmentInput();
            string desc = CommonTools.DescAssignmentInput();
            DateTime sub_date = CommonTools.DateAssignmentInput();
            //string oral_mark = CommonTools.OralMarkAssignmentInput();

            CodingBootcamp.AddAssignments(name, desc, sub_date);
        }

        static void set_course_trainer(PrivateSchool CodingBootcamp)
        {
            CodingBootcamp.OutputCourses();
            int user_cource_data = CommonTools.CourseUserSelection();

            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n");

            CodingBootcamp.OutputTrainer();
            int user_trainer_data = CommonTools.TrainerUserSelection();

            CodingBootcamp.TrainersCourses.Add(new TrainersCourse(user_cource_data, user_trainer_data));
        }

        static void set_course_student(PrivateSchool CodingBootcamp)
        {
            CodingBootcamp.OutputCourses();
            int user_cource_data = CommonTools.CourseUserSelection();

            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n");

            CodingBootcamp.OutputStudents();
            int user_student_data = CommonTools.StudentUserSelection();

            CodingBootcamp.StudentsCourses.Add(new StudentsCourse(user_cource_data, user_student_data));
        }

        static void set_assignment_student(PrivateSchool CodingBootcamp)
        {
            CodingBootcamp.OutputAssignments();
            int user_assignment_data = CommonTools.AssignmentUserSelection();

            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n");

            CodingBootcamp.OutputStudents();
            int user_student_data = CommonTools.StudentUserSelection();
            DateTime sub_date = CommonTools.DateAssignmentInput();

            CodingBootcamp.StudentsAssignments.Add(new StudentsAssignment(user_assignment_data, user_student_data, sub_date));
        }


        static void set_assignment_week(PrivateSchool CodingBootcamp)
        {
            string[] DaysOfWeek = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            DateTime date = CommonTools.DateSearchAssignmentInput();

            int Mon_poss, Sun_poss, Month_Possition_1, Month_Possition_2, Year_Possition_1, Year_Possition_2;
            for (int i = 0; i < 7; i++)
            {
                if (Convert.ToString(date.DayOfWeek) == DaysOfWeek[i])
                {
                    Mon_poss = i;
                    Mon_poss = Mon_poss - 6;
                    Mon_poss = Math.Abs(Mon_poss);
                    Mon_poss = Mon_poss - 6;


                    Sun_poss = i;
                    Sun_poss = 6 - Sun_poss;

                    if (date.Day + Mon_poss <= 0)
                    {
                        if ((date.Month == 4 || date.Month == 6 || date.Month == 9 || date.Month == 11))
                        {
                            Mon_poss = 30 + (date.Day + Mon_poss);
                            Month_Possition_1 = (date.Month == 1) ?  12 : date.Month - 1;
                            Year_Possition_1 = (Month_Possition_1 == 12) ? date.Year - 1 : date.Year;

                        }
                        else
                        {
                            Mon_poss = 31 + (date.Day + Mon_poss);
                            Month_Possition_1 = (date.Month == 1) ? 12 : date.Month - 1;
                            Year_Possition_1 = (Month_Possition_1 == 12) ? date.Year - 1 : date.Year;
                        }
                    }
                    else
                    {
                        Mon_poss = date.Day + Mon_poss;
                        Month_Possition_1 = date.Month ;
                        Year_Possition_1 = date.Year;
                    }


                    if ((date.Month == 4 || date.Month == 6 || date.Month == 9 || date.Month == 11))
                    {
                        if (date.Day + Sun_poss > 30)
                        {
                            Sun_poss = (date.Day + Sun_poss) - 30;
                            Month_Possition_2 = (date.Month == 12) ? 1 : date.Month + 1;
                            Year_Possition_2 = (Month_Possition_1 == 1) ? date.Year + 1 : date.Year;
                        }
                        else
                        {
                            Sun_poss = date.Day + Sun_poss;
                            Month_Possition_2 = date.Month;
                            Year_Possition_2 =  date.Year;
                        }
                    }
                    else
                    {
                        if (date.Day + Sun_poss > 31)
                        {
                            Sun_poss = (date.Day + Sun_poss) - 31;
                            Month_Possition_2 = (date.Month == 12) ? 1 : date.Month + 1;
                            Year_Possition_2 = (Month_Possition_1 == 1) ? date.Year + 1 : date.Year;
                        }
                        else
                        {
                            Sun_poss = date.Day + Sun_poss;
                            Month_Possition_2 = date.Month;
                            Year_Possition_2 = date.Year;
                        }
                    }


                    DateTime Monday = new DateTime(Year_Possition_1, Month_Possition_1, Mon_poss);
                    Console.WriteLine();
                    DateTime Sunday = new DateTime(Year_Possition_2, Month_Possition_2, Sun_poss);

                    Console.WriteLine($"\n\n\nWill Bring Assignments to be Submited on Week Days \n\n\tStrarting {Monday.ToString("dd/MM/yyyy")} throu {Sunday.ToString("dd/MM/yyyy")}");
                    Console.WriteLine("Example: 01/01/2019");
                    CodingBootcamp.OutputSubmitedAssignments(Monday, Sunday);

                }
            }
        }

        public static void PrintUserMenu()
        {
            Console.WriteLine("                 //////////////////////////////////////////////////////////////////////////////////////");
            Console.WriteLine("                 //  1.Add a new student.      /////  9.Set Courses to Trainers.                     //");
            Console.WriteLine("                 //  2.Show all students       /////  10.Set Courses to Students.                    //");
            Console.WriteLine("                 //  3.Add a new Trainer.      /////  11.Set Assignment to Students.                 //");
            Console.WriteLine("                 //  4.Show all Trainers.      /////  12.Show Courses Assigned to Trainers.          //");
            Console.WriteLine("                 //  5.Add a new Course.       /////  13.Show Courses Assigned to Sudents.           //");
            Console.WriteLine("                 //  6.Show all Courses.       /////  14.Show Assignment Assigned to Sudents.        //");
            Console.WriteLine("                 //  7.Add a new Assignment.   /////  15.Show Sudents with more than one Assignment. //");
            Console.WriteLine("                 //  8.Show all Assignments.   /////  16.Search for Assignments on Given Week.       //");
            Console.WriteLine("                 //////////////////////////////////////////////////////////////////////////////////////");
            Console.WriteLine("                                  Select an answer by the displayed number \n\n");
        }

        static void UserMenuCase(PrivateSchool CodingBootcamp)
        {
            int user_case;
            do
            {
                try
                {
                    PrintUserMenu();
                    user_case = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\n\n\n\n\n\n\n");
                    switch (user_case)
                    {
                        case 1:
                            //Add Student
                            add_student(CodingBootcamp);
                            break;
                        case 2:
                            //Print Students
                            CodingBootcamp.OutputStudents();
                            break;
                        case 3:
                            //Add Trainer
                            add_teacher(CodingBootcamp);
                            break;
                        case 4:
                            //Print Trainers
                            CodingBootcamp.OutputTrainer();
                            break;
                        case 5:
                            //Add Course
                            add_course(CodingBootcamp);
                            break;
                        case 6:
                            //Print Courses
                            CodingBootcamp.OutputCourses();
                            break;
                        case 7:
                            //Add Assignment
                            add_assignment(CodingBootcamp);
                            break;
                        case 8:
                            //Print Assignments
                            CodingBootcamp.OutputAssignments();
                            break;
                        case 9:
                            //Assign Cource to Trainers
                            set_course_trainer(CodingBootcamp);
                            break;
                        case 10:
                            //Assign Cource to Students
                            set_course_student(CodingBootcamp);
                            break;
                        case 11:
                            //Assign Assignments to Students
                            set_assignment_student(CodingBootcamp);
                            break;
                        case 12:
                            //Print Cources Assigned to Trainers
                            CodingBootcamp.OutputCoursesTrainers();
                            break;
                        case 13:
                            //Print Cources Assigned to Students
                            CodingBootcamp.OutputCoursesStudents();
                            break;
                        case 14:
                            //Print Assignments Assigned to Students
                            CodingBootcamp.OutputAssignmentsStudents();
                            break;
                        case 15:
                            //Print Students that have More than 1 assignment
                            CodingBootcamp.OutputStudentsTwoAssignments();
                            break;
                        case 16:
                            //Print Assignments that have to be submited on day
                            set_assignment_week(CodingBootcamp);
                            break;
                        default:
                            Console.WriteLine("Please select a correct option!Please try again");
                            continue;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    Console.WriteLine("\nUse Input Fields Correctly Please!\n\n\n");
                    continue;
                }

            } while (true);
        }  
    }
}

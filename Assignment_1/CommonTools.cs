using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class CommonTools
    {
        private const string V = "";
        private const string DefaultDate = "01/01/2001";

        //-------------Common--------------\\
        public static void SyntheticDataUserSelection(PrivateSchool CodingBootcamp)
        {

            SyntheticDataMenu();
            int a = Convert.ToInt32(Console.ReadLine());
            switch (a)
            {
                case 1://Default Synthetic
                    SyntheticData.SyntheticStudents(CodingBootcamp);
                    SyntheticData.SyntheticAssignments(CodingBootcamp);
                    SyntheticData.SyntheticTeachers(CodingBootcamp);
                    SyntheticData.SyntheticCourses(CodingBootcamp);
                    SyntheticData.SyntheticStudentsAssignments(CodingBootcamp);
                    SyntheticData.SyntheticStudentsCourses(CodingBootcamp);
                    SyntheticData.SyntheticTrainersCourses(CodingBootcamp);
                    break;

                case 2://Manual Synthrtic
                    Console.WriteLine("Set Number Of Students: ");
                    SyntheticData.SyntheticStudents(CodingBootcamp, Convert.ToInt32(Console.ReadLine()));
                    Console.WriteLine("Set Number Of Trainers: ");
                    SyntheticData.SyntheticTeachers(CodingBootcamp, Convert.ToInt32(Console.ReadLine()));
                    Console.WriteLine("Set Number Of Courses: ");
                    SyntheticData.SyntheticCourses(CodingBootcamp, Convert.ToInt32(Console.ReadLine()));
                    Console.WriteLine("Set Number Of Assigments: ");
                    SyntheticData.SyntheticAssignments(CodingBootcamp, Convert.ToInt32(Console.ReadLine()));
                    break;

                case 3://Continue to Programm
                    break;
                default:
                    Console.Write("Please Use The Correct # From Menu: ");
                    break;
            }



        }



        private static void SyntheticDataMenu()
        {
            Console.WriteLine("                             //////////////////////////////////////");
            Console.WriteLine("                             //   1.Input Synthetic Data         //");
            Console.WriteLine("                             //   2.Input Synthetic Data x Times //");
            Console.WriteLine("                             //   3.Contiue To Programm          //");
            Console.WriteLine("                             //////////////////////////////////////");
            Console.WriteLine("                             Select an answer by the displayed number \n\n\n\n\n\n\n\n");
        }



        //-------------Trainers--------------\\
        public static string NameTrainerInput()
        {
            Console.Write("Set Trainers name: ");
            return Console.ReadLine();
        }
        public static string LastnameTrainerInput()
        {
            Console.Write("Set Trainers lastname: ");
            return Console.ReadLine();
        }
        public static string SubjectTrainerInput()
        {
            Console.Write("Set Trainers Subject: ");
            return Console.ReadLine();
        }



        //-------------Students--------------\\
        public static string NameStudentInput()
        {
            Console.Write("Set Student Name: ");
            return Console.ReadLine();
        }
        public static string LastnameStudentInput()
        {
            Console.Write("Set Student Lastname: ");
            return Console.ReadLine();
        }
        public static DateTime DateOfBirthStudentInput()
        {
            Console.Write("Set Student DateOfBirth: ");
            return CommonTools.DateTimeUserInput(); ;
        }
        public static double TuitionStudentInput()
        {
            Console.Write("Set student total tuition fees: ");
            string tuition = Console.ReadLine();
            if (tuition == V)
            {
                tuition = "2500";
            }

            return Convert.ToDouble(tuition);
        }






        //-----------Courses--------------\\
        public static string TitleCourseInput()
        {
            Console.Write("Set Course Title: ");
            return Console.ReadLine();
        }
        public static string StreamCourseInput()
        {
            Console.Write("Set Course Stream: ");
            return Console.ReadLine();
        }
        public static string TypeCourseInput()
        {
            Console.Write("Set Course Type: ");
            return Console.ReadLine();
        }
        public static DateTime StartEndDateCourseInput(out DateTime EndDate)
        {
            DateTime StartDate;
            do
            {

                Console.Write("Set Course Start Date: ");
                StartDate = DateTimeUserInput();

                Console.Write("Set Course End Date: ");
                EndDate = DateTimeUserInput();

                if (StartDate == EndDate)
                {
                    return StartDate;
                }
                if (StartDate < EndDate)
                {

                    return StartDate;

                }
                else
                {
                    Console.WriteLine("Starting Day Must Be Greater Than End Day");
                }
            } while (true);


        }


        //-----------Assignment--------------\\
        public static string NameAssignmentInput()
        {
            Console.Write("Set Assignment name: ");
            return Console.ReadLine();
        }
        public static string DescAssignmentInput()
        {
            Console.Write("Set Assignment Desctription: ");
            return Console.ReadLine();
        }
        public static string OralMarkAssignmentInput()
        {
            Console.Write("Set Oral Mark: ");
            return Console.ReadLine();
        }
        public static DateTime DateAssignmentInput()
        {
            Console.Write("Set Assignment Submit Date: ");
            return DateTimeUserInput();
        }
        public static DateTime DateSearchAssignmentInput()
        {

            Console.Write("Set Date to be Checked:  ");
            return DateTimeUserInput();
        }



        //-----------Options--------------\\
        public static int CourseUserSelection()
        {
            Console.WriteLine("Select Course by Number.");
            return Convert.ToInt32(Console.ReadLine());
        }
        public static int TrainerUserSelection()
        {
            Console.WriteLine("Select Trainer by Number.");
            return Convert.ToInt32(Console.ReadLine());
        }
        public static int StudentUserSelection()
        {
            Console.WriteLine("Select Student by Number.");
            return Convert.ToInt32(Console.ReadLine());
        }
        public static int AssignmentUserSelection()
        {
            Console.WriteLine("Select Assignment by Number.");
            return Convert.ToInt32(Console.ReadLine());
        }




        private static DateTime DateTimeUserInput()
        {

 
            string Date = Console.ReadLine();
            DateTime Datedt;
            while (!DateTime.TryParseExact(Date, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.AdjustToUniversal, out Datedt))
            {
                if (Date == V)
                {
                    DateTime.TryParseExact(DefaultDate, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.AdjustToUniversal, out Datedt);
                   // DateTime.TryParse(DefaultDate, out Datedt);
                    return Datedt;
                }
                Console.WriteLine("Invalid date, please retry(DD/MM/YYYY)");
                Date = Console.ReadLine();

            }

            return Datedt;
        }
    }
}



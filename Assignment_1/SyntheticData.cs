using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class SyntheticData
    {
        public static void SyntheticStudents(PrivateSchool CodingBootcamp, int times)
        {
            for (int i = 0; i < times; i++)
            {
                CodingBootcamp.AddStudent("Alex", "Psychoson", new DateTime(1995, 2, 1), 2500);
            }
        }
        public static void SyntheticStudents(PrivateSchool CodingBootcamp)
        {
            CodingBootcamp.AddStudent("Alex", "Psychoson", new DateTime(1995, 12, 10), 2500);
            CodingBootcamp.AddStudent("Nikos", "Papas", new DateTime(1997, 7, 10), 2500);
            CodingBootcamp.AddStudent("Dimitris", "Doykas", new DateTime(1990, 8, 20), 2500);
            CodingBootcamp.AddStudent("Stelios", "Pyrgaki", new DateTime(1985, 2, 10), 2500);
            CodingBootcamp.AddStudent("Hektor", "Kontoes", new DateTime(1975, 9, 1), 2500);
            CodingBootcamp.AddStudent("Argyris", "Koukounasoulis", new DateTime(1965, 2, 12), 2500);
            CodingBootcamp.AddStudent("Manos", "papadakakis", new DateTime(1955, 3, 21), 2500);
            CodingBootcamp.AddStudent("Kwstas", "gkikas", new DateTime(1987, 4, 12), 2500);
            CodingBootcamp.AddStudent("Mpampis", "panago", new DateTime(1987, 1, 16), 2500);
            CodingBootcamp.AddStudent("Artemis", "psycho", new DateTime(1967, 2, 19), 2500);
        }




        public static void SyntheticTeachers(PrivateSchool CodingBootcamp, int times)
        {
            for (int i = 0; i < times; i++)
            {
                CodingBootcamp.AddTrainer("Fwtini", "Psychogiou", "C#");
            }
        }
        public static void SyntheticTeachers(PrivateSchool CodingBootcamp)
        {
            CodingBootcamp.AddTrainer("Fwtini", "Psychogiou", "C#");
            CodingBootcamp.AddTrainer("Amalia", "Papa", "JAVA");
            CodingBootcamp.AddTrainer("Dimitra", "Doyka", "C#");
            CodingBootcamp.AddTrainer("Stela", "Pyrgaki", "JAVA");
        }



        public static void SyntheticCourses(PrivateSchool CodingBootcamp, int times)
        {
            for (int i = 0; i < times; i++)
            {
                CodingBootcamp.AddCource("C# - Full Time", "Full Time", "C#", new DateTime(2019, 1, 1), new DateTime(2019, 3, 1));
            }
        }
        public static void SyntheticCourses(PrivateSchool CodingBootcamp)
        {
            CodingBootcamp.AddCource("C# - Full Time", "Full Time", "C#", new DateTime(2019, 1, 1), new DateTime(2019, 3, 1));
            CodingBootcamp.AddCource("C# - Part Time", "Part Time", "C#", new DateTime(2019, 1, 1), new DateTime(2019, 6, 1));
            CodingBootcamp.AddCource("JAVA - Full Time", "Full Time", "JAVA", new DateTime(2019, 1, 1), new DateTime(2019, 3, 1));
            CodingBootcamp.AddCource("JAVA - Full Time", "Part Time", "JAVA", new DateTime(2019, 1, 1), new DateTime(2019, 6, 1));
        }



        public static void SyntheticAssignments(PrivateSchool CodingBootcamp, int times)
        {
            for (int i = 0; i < times; i++)
            {
                CodingBootcamp.AddAssignments("Assignment 1", "This is a test assingment - 1", new DateTime(2019, 1, 1));
            }
        }
        public static void SyntheticAssignments(PrivateSchool CodingBootcamp)
        {
            CodingBootcamp.AddAssignments("Assignment 1", "This is a test assingment - 1", new DateTime(2019, 1, 1));
            CodingBootcamp.AddAssignments("Assignment 2", "This is a test assingment - 2", new DateTime(2019, 2, 1));
            CodingBootcamp.AddAssignments("Assignment 3", "This is a test assingment - 3", new DateTime(2019, 3, 1));
            CodingBootcamp.AddAssignments("Assignment 4", "This is a test assingment - 4", new DateTime(2019, 4, 1));
            CodingBootcamp.AddAssignments("Assignment 5", "This is a test assingment - 5", new DateTime(2019, 5, 1));
            CodingBootcamp.AddAssignments("Assignment 6", "This is a test assingment - 6", new DateTime(2019, 6, 1));
        }

        public static void SyntheticTrainersCourses(PrivateSchool CodingBootcamp)
        {
            CodingBootcamp.StudentsCourses.Add(new StudentsCourse(1, 1));
            CodingBootcamp.StudentsCourses.Add(new StudentsCourse(2, 2));
        }
        public static void SyntheticStudentsCourses(PrivateSchool CodingBootcamp)
        {
            CodingBootcamp.TrainersCourses.Add(new TrainersCourse(1, 1));
            CodingBootcamp.TrainersCourses.Add(new TrainersCourse(2, 2));
        }
        public static void SyntheticStudentsAssignments(PrivateSchool CodingBootcamp)
        {
            CodingBootcamp.StudentsAssignments.Add(new StudentsAssignment(1, 1, new DateTime(2019, 1, 2)));
            CodingBootcamp.StudentsAssignments.Add(new StudentsAssignment(2, 2, new DateTime(2019, 1, 7)));
            CodingBootcamp.StudentsAssignments.Add(new StudentsAssignment(1, 1, new DateTime(2019, 1, 2)));
            CodingBootcamp.StudentsAssignments.Add(new StudentsAssignment(2, 2, new DateTime(2019, 1, 7)));
        }

    }
}

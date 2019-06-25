using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Course : PrivateSchool
    {
        public int ID { get; set; } = 0;
        public string Title { get; set; }
        public string Stream { get; set; }
        public string Type { get; set; }
        public DateTime StartDate { get; set; } = new DateTime();
        public DateTime EndDate { get; set; } = new DateTime();


        //Default Constructor
        public Course()
        {
            ID = ID++;
            Title = "";
            Type = "";
        }

        //Overloaded Constructor
        public Course(int id ,string title ,string srteam, string type , DateTime sdate , DateTime fdate)
        {
            ID = id;
            Title = title;
            Stream = srteam;
            Type = type;
            StartDate = sdate;
            EndDate = fdate;
        }

    }

    class Assignment : Course
    {
        public string Description { get; set; }
        public DateTime SubDateTime { get; set; } = new DateTime();
        public int OralMark { get; set; }
        public int TotalMark { get; set; }

        
        public Assignment(int id, string title,string desc, DateTime sub_date)
        {
            ID = id;
            Title = title;
            Description = desc;
            SubDateTime = sub_date;
        }

        //INPUT

        public void SetDescription(string desc) { Description = desc; }
        public void SetOralMark(int oral) { OralMark = oral; }
        public void SetSubDateTime(DateTime sub) { SubDateTime = sub; }
        public void SetTotalMark(int total) { TotalMark = total; }



        //OUTPUT
        public int GetOralMark() { return OralMark; }
        public int GetTotalMark(){ return  TotalMark; }      
        public string GetDescription() { return Description; }
        public DateTime GetSubDateTime() { return SubDateTime; }

    }
}

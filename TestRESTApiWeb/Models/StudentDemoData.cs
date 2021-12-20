using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestRESTApiWeb.Models
{
    public class StudentDemoData
    {
        public int RollNum { get; set; }
        public string Name { get; set; }

        public string Course { get; set; }

   

    }

    public class StudentDataList
    {
        public List<StudentDemoData> studentDemoDatas { get; set; } = null;
        
        public StudentDataList()
        {
            studentDemoDatas = new List<StudentDemoData>();
            StudentDemoData sd = new StudentDemoData();
            sd.RollNum = 1001;
            sd.Name = "Alex";
            sd.Course = "ComputerScience";
            studentDemoDatas.Add(sd);

            sd = new StudentDemoData();
            sd.RollNum = 1002;
            sd.Name = "Bob";
            sd.Course = "Civil";
            studentDemoDatas.Add(sd);

            sd = new StudentDemoData();
            sd.RollNum = 1003;
            sd.Name = "Carry";
            sd.Course = "Mechanical";
            studentDemoDatas.Add(sd);

            sd = new StudentDemoData();
            sd.RollNum = 1004;
            sd.Name = "Derek";
            sd.Course = "Software";
            studentDemoDatas.Add(sd);

            sd = new StudentDemoData();
            sd.RollNum = 1005;
            sd.Name = "Elisa";
            sd.Course = "Electrical";
            studentDemoDatas.Add(sd);

            sd = new StudentDemoData();
            sd.RollNum = 1006;
            sd.Name = "Felix";
            sd.Course = "Electronics";
            studentDemoDatas.Add(sd);

            sd = new StudentDemoData();
            sd.RollNum = 1007;
            sd.Name = "Gorge";
            sd.Course = "Electrical";
            studentDemoDatas.Add(sd);

            sd = new StudentDemoData();
            sd.RollNum = 1008;
            sd.Name = "Harry";
            sd.Course = "Physics";
            studentDemoDatas.Add(sd);

            sd = new StudentDemoData();
            sd.RollNum = 1009;
            sd.Name = "Ian";
            sd.Course = "Chemical";
            studentDemoDatas.Add(sd);

            sd = new StudentDemoData();
            sd.RollNum = 1010;
            sd.Name = "John";
            sd.Course = "Electrical";
            studentDemoDatas.Add(sd);
        }
    }
}
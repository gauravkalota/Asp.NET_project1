using System;
using System.Collections.Generic;
using System.Web.Http;
using TestRESTApiWeb.Models;
using TestRESTApiWeb.Responseclass;


namespace TestRESTApiWeb.Controllers
{
    public class StudentDataController : ApiController
    {
        public bool isValid { get; private set; }

        // GET: api/StudentData
        [Route("api/StudentData/MyData")]
        public List<StudentDemoData> Get()
        {
            StudentDataList sdList = new StudentDataList();
            return sdList.studentDemoDatas;
        }

        // GET: api/StudentData/5

        [Route("api/StudentData/MyData/{id}")]
        public Response Get([FromBody]StudentDemoData value,int id)
        {
            Response obj = new Response();   //object of class
            StudentDataList sdList = new StudentDataList();
            bool isvalid = false;
            foreach (StudentDemoData sd in sdList.studentDemoDatas)
            {
                if (sd.RollNum == id)
                {
                    obj.Data = sd;
                    isvalid = true;
                    break;
                }
            }
            if (isvalid)
            {
                obj.Errors = "No Error!";
                obj.Message = "Data";
            }
            else
            {
                obj.Errors = "No Data!";
                obj.Message = "Invalid Credentials";
            }
            return obj;
  



        }

        // POST: api/StudentData/id
        [Route("api/StudentData/MyData/{id}")]
        public Response Post(int id, [FromBody]StudentDemoData value)
        {

            Response obj = new Response();   //object of class
            StudentDataList sdList = new StudentDataList();

            bool isvalid = false;
            foreach (StudentDemoData sd in sdList.studentDemoDatas)
            {
                if (sd.RollNum == id)
                {
                    obj.Data = sd;
                    isvalid = true;
                    break;
                }
            }
            if (isvalid)
            {
                obj.Errors = "No Error!";
                obj.Message = "Data Updated Successfully";
            }
            else
            {
                obj.Errors = "No Record Found!";
            }
            return obj;



            /////////////////////////
            

        }

        // PUT: api/StudentData
        [Route("api/StudentData/MyData")]

        public Response Put([FromBody]StudentDemoData value)
        {
            ////update the record
            Response obj = new Response();
            StudentDataList sdList = new StudentDataList();
            bool isvalid = false;
            foreach (StudentDemoData sd in sdList.studentDemoDatas)
            {
                if (sd.RollNum == value.RollNum)
                {
                    sd.Name = sd.Name.Insert(sd.Name.Length, "!");
                    sd.Course = sd.Course.Insert(sd.Course.Length, "!");
                    obj.Data = sd;
                    isvalid = true;
                    break;
                }
            }
            if (isvalid)
            {
                obj.Errors = "No Error!";
                obj.Message = "Data Added Successfully";
            }
            else
            {
                obj.Errors = "Data Not Added Error- Invalid Credentials";
            }
            return obj;


        }

        // DELETE: api/StudentData/5
        [Route("api/StudentData/MyData/{id}")]
        public Response Delete(int id, [FromBody]StudentDemoData value)
        {
            Response obj = new Response();   //object of class
            StudentDataList sdList = new StudentDataList();
            bool isvalid = false;
            foreach (StudentDemoData sd in sdList.studentDemoDatas)
                {
                 if (sd.RollNum == id)
                    {
                        obj.Data = sd;
                        isvalid = true;
                        break;   
                    }
                }     
            if(isvalid)
            {
                obj.Errors = "No Error!";
                obj.Message = "Data Deleted Successfully";
            }
            else
            {
                obj.Errors = "No Record Found!";
            }
            return obj;
            
        }
    }
}

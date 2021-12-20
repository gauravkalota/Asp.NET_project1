using TestRESTApiWeb.Models;

namespace TestRESTApiWeb.Responseclass
{
    public class Response 

    {
        public StudentDemoData Data { get; set; }
        
           public string Message { get; set; }

           public string Errors { get; set; }

    }
}
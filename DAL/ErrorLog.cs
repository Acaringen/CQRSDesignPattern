using System;

namespace DesignPattern.CQRS.DAL
{
    public class ErrorLog
    {
        public int Id { get; set; }
        public string ErrorMessage { get; set; }  
        public string ControllerName { get; set; } 
        public string ActionName { get; set; }
        public DateTime ErrorDate { get; set; } = DateTime.Now; 
    }
}

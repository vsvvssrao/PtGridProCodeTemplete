using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Sample
    {
        [customAttr(DisplayName= "Control Number", Type ="text",width ="10")]
        public string ControlNumber { get; set; }
        public string FileName { get; set; }
        public string Sender { get; set; }
        public string Receiver { get; set; }
        public string FilePath { get; set; }
        public DateTime? DateOfCreation { get; set; }
        public int? AgeInDays { get; set; }
        public string Status { get; set; }
        public int? IncomeFileLoggerID { get; set; }
        public string FileKey { get; set; }
        public string ApplicaionOrGroupName { get; set; }
        public string RegisterUserName { get; set; }
        public string FileType { get; set; }
    }
}
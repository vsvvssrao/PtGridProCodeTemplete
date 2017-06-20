using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class customAttr : Attribute
    {
        //public customAttr(string expression) : base(expression) { }

        public string DisplayName { get; set; }
        public string width { get; set; }
        public string Type { get; set; }


    }
    
}
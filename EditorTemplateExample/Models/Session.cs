using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EditorTemplateExample.Models
{
    public class Session
    {
        public int SessionID { get; set; }
        public bool IsSignedUp { get; set; }
        public string Name { get; set; }
        public decimal Cost { get; set; }
    }
}
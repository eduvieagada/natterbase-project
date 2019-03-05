using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NatterbaseProject.Models
{
    public class Activity
    {
        public int Id { get; set; }
        public string Action { get; set; }
        public string DatePerformed { get; set; }
    }
}
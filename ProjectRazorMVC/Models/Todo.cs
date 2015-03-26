using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectRazorMVC.Models
{
    public class Todo
    {
        public int Id { get; set; }
        public string Task{ get; set; }
        public DateTime Datecreated { get; set; }
        public bool IsCompleted { get; set; }
    }

}
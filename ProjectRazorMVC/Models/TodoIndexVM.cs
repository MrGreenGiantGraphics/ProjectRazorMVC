using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectRazorMVC.Models
{
    public class TodoIndexVM
    {
        // Todos Page ViewModel
        public string Greeting { get; set; }
        public List<Todo> MyChores { get; set; }
    }
}
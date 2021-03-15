using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EyeDoctor.Models
{
    public class StudentModel
    {
        public int Studenet_Id { get; set; }
        public string Student_Name { get; set; }
        public string Student_Email { get; set; }
        public Adress Adress { get; set; }
    }
}
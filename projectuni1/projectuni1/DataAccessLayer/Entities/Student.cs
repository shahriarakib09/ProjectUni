using System;
using System.Collections.Generic;
using System.Text;

namespace projectuni.DataAccesslayer.Entities
{
    class Student
    {
        public int student_id { get; set; }
        public string student_name { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public string date_of_birth { get; set; }
        public string gender { get; set; }
        public string blood_group { get; set; }
        public string address { get; set; }
        public int phone_number { get; set; }
        public int gurdian_contact { get; set; }
        public int admission_year { get; set; }
        public int department_id { get; set; }
        
    }
}

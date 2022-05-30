using System;
using System.Collections.Generic;
using System.Text;

namespace projectuni.DataAccesslayer.Entities
{
    class Admin
    {
        public int admin_id { get; set; }
        public string admin_name { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public string date_of_birth { get; set; }
        public string gender { get; set; }
        public string blood_group { get; set; }
        public string hiredate { get; set; }
        public int salary { get; set; }
        public string address { get; set; }
        public int phone_number { get; set; }

    }
}

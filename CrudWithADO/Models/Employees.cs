using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudWithADO.Models
{
    public class Employees
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Gender { get; set; }

        public string Dname { get; set; }
        //public int Department_Id { get; set; }
        //public string Department_Name { get; set; }

    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp_BusinessLayer.Entities
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Role(int id , string name)
        {
            Id = id; Name = name;

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp_BusinessLayer.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int? ManagerId { get; set; }
        public Employee(int id , string firstName , string lastName , int? managerId) 
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            ManagerId = managerId;
        }
        public override string ToString()
        {
            return string.Format("ID: {0} ,FirstName: {1} , LastName:{2}", this.Id, this.FirstName, this.LastName);

        }
    }
}

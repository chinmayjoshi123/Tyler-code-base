using EmployeeApp_BusinessLayer.Entities;
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;

namespace EmployeeApp_BusinessLayer
{
    public class EmployeeDetails
    {
        public MySqlConnection Connection { get; set; }
        public List<Employee> Employees { get; set; }
        public List<Role> roles { get; set; }
        public EmployeeDetails()
        {
            MySqlConnectionStringBuilder builder= new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "mydb";
            builder.SslMode = MySqlSslMode.Disabled;
            Connection = new MySqlConnection(builder.ToString());
            Employees = new List<Employee>();
            roles = new List<Role>();
            InitalizeEmployees();
            InitalizeRoles();
        }

        private void InitalizeEmployees()
        {
            using (Connection)
            {
                var sqlcommand = new MySqlCommand("SELECT * FROM EMPLOYEE", Connection);
                Connection.Open();
                var reader = sqlcommand.ExecuteReader();
                while (reader.Read())
                {
                    var Id = reader.GetInt32(0);
                    var firstName = reader.GetString(1);
                    var lastName = reader.GetString(2);
                    var managerId = reader.IsDBNull(3) ? 0 : reader.GetInt32(3);
                    var employee = new Employee(Id, firstName, lastName,managerId);
                    Employees.Add(employee);

                }
                reader.Close();
            }
        }

        private void InitalizeRoles()
        {
            using (Connection)
            {
                var sqlcommand = new MySqlCommand("SELECT * FROM ROLES", Connection);
                Connection.Open();
                var reader = sqlcommand.ExecuteReader();
                while (reader.Read())
                {
                    var Id = reader.GetInt32(0);
                    var name = reader.GetString(1);
                    var role = new Role(Id, name);
                    roles.Add(role);
                }
                reader.Close();
            }
        }
        public List<Employee> getSubordinates(int managerId)
        {
           return Employees.FindAll(e  => e.ManagerId == managerId);
        }
        public List<Employee> getManagers()
        {
            return Employees.Join(roles, e => e.Id, r => r.Id, (e, r) => new {e.Id, e.FirstName ,e.LastName , r.Name}).
                Where(d => string.Equals(d.Name, "Director" , StringComparison.OrdinalIgnoreCase)).
                Select(d => new Employee(d.Id ,d.FirstName , d.LastName , -1))
                .DistinctBy(e => e.Id).ToList();
        }
        private void addEmployee(Employee employee)
        {
            using (Connection)
            {
                var sqlcommand = new MySqlCommand("INSERT INTO EMPLOYEE VALUES (@Id , @FirstName, @LastName ,@ManagerId)", Connection);
                MySqlParameter idParam = new MySqlParameter{ DbType = System.Data.DbType.Int32, ParameterName = "@Id", Direction = System.Data.ParameterDirection.Input };
                sqlcommand.Parameters.Add(idParam);
                MySqlParameter firstNameParam = new MySqlParameter { DbType = System.Data.DbType.String, ParameterName = "@FirstName", Direction = System.Data.ParameterDirection.Input };
                sqlcommand.Parameters.Add(firstNameParam);
                MySqlParameter lastNameParam = new MySqlParameter { DbType = System.Data.DbType.String, ParameterName = "@LastName", Direction = System.Data.ParameterDirection.Input };
                sqlcommand.Parameters.Add(lastNameParam);
                MySqlParameter managerIdParam = new MySqlParameter { DbType = System.Data.DbType.Int32 , ParameterName = "@ManagerId" , Direction = System.Data.ParameterDirection.Input };
                sqlcommand.Parameters.Add(managerIdParam);
                Connection.Open();
                idParam.Value = employee.Id;
                firstNameParam.Value = employee.FirstName;
                lastNameParam.Value = employee.LastName;
                managerIdParam.Value = employee.ManagerId;
                sqlcommand.ExecuteNonQuery();
                
            }
        }
        public void AddDetails(Employee emp , List<Role> roles)
        {
            addEmployee(emp);
            roles.ForEach(addRole);
        }

        private void addRole(Role role)
        {
            using(Connection)
            {
                var insertCommand = new MySqlCommand("INSERT INTO ROLES VALUES (@Id , @Name)",Connection);
                var idParam = new MySqlParameter
                {
                    DbType = DbType.Int32,
                    ParameterName = "@Id",
                    Direction = ParameterDirection.Input
                };
                insertCommand.Parameters.Add(idParam);
                MySqlParameter roleParam = new MySqlParameter
                {
                    DbType = DbType.String,
                    ParameterName = "@Name",
                    Direction = ParameterDirection.Input
                };
                Connection.Open();
                insertCommand.Parameters.Add(roleParam);
                idParam.Value = role.Id;
                roleParam.Value = role.Name;
                insertCommand.ExecuteNonQuery();
            }
            
        }

        public void refresh()
        {
            Employees.Clear();
            roles.Clear();
            InitalizeEmployees();
            InitalizeRoles();
            
        }
    }
}
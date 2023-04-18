using EmployeeApp_BusinessLayer;
using EmployeeApp_BusinessLayer.Entities;
using System.Data;
using System.Transactions;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private EmployeeDetails empDetails;
        public Form1()
        {
            InitializeComponent();
            empDetails = new EmployeeDetails();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateControlValues();

        }

        private void UpdateControlValues()
        {
            var managers = empDetails.getManagers();
            comboBoxManager.Items.Clear();
            addEmployees_Managercmbox.Items.Clear();
            managers.ForEach(manager => {
                comboBoxManager.Items.Add(manager);
                addEmployees_Managercmbox.Items.Add(manager);
            });
        }

        private void comboBoxManager_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDataGridView(sender);

        }

        private void UpdateDataGridView(object sender)
        {
            var comboBox = sender as ComboBox;
            Employee? manager = comboBox?.SelectedItem as Employee;
            if (manager != null)
            {
                var subordinates = empDetails.getSubordinates(manager.Id);
                var datatable = new DataTable();
                var column1 = new DataColumn("Id", typeof(int));
                var column2 = new DataColumn("FirstName", typeof(string));
                var column3 = new DataColumn("LastName", typeof(string));
                datatable.Columns.Add(column1);
                datatable.Columns.Add(column2);
                datatable.Columns.Add(column3);
                foreach (var subordinate in subordinates)
                {
                    datatable.Rows.Add(subordinate.Id, subordinate.FirstName, subordinate.LastName);
                }
                dataGridView1.DataSource = datatable.DefaultView;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addEmployeesPanel.Visible = true;
            viewEmployeesPanel.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            addEmployeesPanel.Visible = false;
            viewEmployeesPanel.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var managerID = (addEmployees_Managercmbox.SelectedItem as Employee)?.Id;
                var id =Convert.ToInt32(empIDTextBox.Text.Trim());
                var firstName = firstNameTextBox.Text.Trim();
                var lastName = lastNameTextBox.Text.Trim();
                var roles_array = rolesrichTextBox.Text.Split("\v");
                var roles_list = roles_array.Select(x => new Role(id , x)).ToList();

                var employee = new Employee(id, firstName, lastName, managerID);

                empDetails.AddDetails(employee ,roles_list);
                empDetails.refresh();
                UpdateControlValues();
                MessageBox.Show("Employee Added Successfully to DB");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
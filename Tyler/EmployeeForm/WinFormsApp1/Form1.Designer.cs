namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBoxManager = new ComboBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            viewEmployeesPanel = new Panel();
            button1 = new Button();
            addEmployeesPanel = new Panel();
            label7 = new Label();
            cancelButton = new Button();
            rolesrichTextBox = new RichTextBox();
            saveButton = new Button();
            lastNameTextBox = new TextBox();
            label6 = new Label();
            firstNameTextBox = new TextBox();
            label5 = new Label();
            empIDTextBox = new TextBox();
            label4 = new Label();
            label3 = new Label();
            addEmployees_Managercmbox = new ComboBox();
            label2 = new Label();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            viewEmployeesPanel.SuspendLayout();
            addEmployeesPanel.SuspendLayout();
            SuspendLayout();
            // 
            // comboBoxManager
            // 
            comboBoxManager.FormattingEnabled = true;
            comboBoxManager.Location = new Point(128, 15);
            comboBoxManager.Name = "comboBoxManager";
            comboBoxManager.Size = new Size(178, 28);
            comboBoxManager.TabIndex = 0;
            comboBoxManager.SelectedIndexChanged += comboBoxManager_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 18);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 1;
            label1.Text = "Manager";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 49);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(495, 289);
            dataGridView1.TabIndex = 2;
            // 
            // viewEmployeesPanel
            // 
            viewEmployeesPanel.Controls.Add(button1);
            viewEmployeesPanel.Controls.Add(comboBoxManager);
            viewEmployeesPanel.Controls.Add(label1);
            viewEmployeesPanel.Controls.Add(dataGridView1);
            viewEmployeesPanel.Location = new Point(26, 22);
            viewEmployeesPanel.Name = "viewEmployeesPanel";
            viewEmployeesPanel.Size = new Size(615, 485);
            viewEmployeesPanel.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(139, 344);
            button1.Name = "button1";
            button1.Size = new Size(151, 29);
            button1.TabIndex = 3;
            button1.Text = "Add Employee";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // addEmployeesPanel
            // 
            addEmployeesPanel.Controls.Add(label7);
            addEmployeesPanel.Controls.Add(cancelButton);
            addEmployeesPanel.Controls.Add(rolesrichTextBox);
            addEmployeesPanel.Controls.Add(saveButton);
            addEmployeesPanel.Controls.Add(lastNameTextBox);
            addEmployeesPanel.Controls.Add(label6);
            addEmployeesPanel.Controls.Add(firstNameTextBox);
            addEmployeesPanel.Controls.Add(label5);
            addEmployeesPanel.Controls.Add(empIDTextBox);
            addEmployeesPanel.Controls.Add(label4);
            addEmployeesPanel.Controls.Add(label3);
            addEmployeesPanel.Controls.Add(addEmployees_Managercmbox);
            addEmployeesPanel.Controls.Add(label2);
            addEmployeesPanel.Location = new Point(29, 22);
            addEmployeesPanel.Name = "addEmployeesPanel";
            addEmployeesPanel.Size = new Size(615, 488);
            addEmployeesPanel.TabIndex = 4;
            addEmployeesPanel.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(147, 341);
            label7.Name = "label7";
            label7.Size = new Size(45, 20);
            label7.TabIndex = 10;
            label7.Text = "Roles";
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(321, 426);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(94, 29);
            cancelButton.TabIndex = 5;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += button3_Click;
            // 
            // rolesrichTextBox
            // 
            rolesrichTextBox.Location = new Point(213, 285);
            rolesrichTextBox.Name = "rolesrichTextBox";
            rolesrichTextBox.Size = new Size(151, 120);
            rolesrichTextBox.TabIndex = 9;
            rolesrichTextBox.Text = "";
            // 
            // saveButton
            // 
            saveButton.Location = new Point(209, 426);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(94, 29);
            saveButton.TabIndex = 4;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += button2_Click;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(213, 242);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(151, 27);
            lastNameTextBox.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(128, 245);
            label6.Name = "label6";
            label6.Size = new Size(79, 20);
            label6.TabIndex = 7;
            label6.Text = "Last Name";
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(213, 185);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(151, 27);
            firstNameTextBox.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(127, 185);
            label5.Name = "label5";
            label5.Size = new Size(80, 20);
            label5.TabIndex = 5;
            label5.Text = "First Name";
            // 
            // empIDTextBox
            // 
            empIDTextBox.Location = new Point(213, 135);
            empIDTextBox.Name = "empIDTextBox";
            empIDTextBox.Size = new Size(151, 27);
            empIDTextBox.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(119, 138);
            label4.Name = "label4";
            label4.Size = new Size(88, 20);
            label4.TabIndex = 3;
            label4.Text = "EmployeeId";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(196, 3);
            label3.Name = "label3";
            label3.Size = new Size(237, 32);
            label3.TabIndex = 2;
            label3.Text = "Add New Employee";
            // 
            // addEmployees_Managercmbox
            // 
            addEmployees_Managercmbox.FormattingEnabled = true;
            addEmployees_Managercmbox.Location = new Point(213, 69);
            addEmployees_Managercmbox.Name = "addEmployees_Managercmbox";
            addEmployees_Managercmbox.Size = new Size(151, 28);
            addEmployees_Managercmbox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(139, 72);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 0;
            label2.Text = "Manager";
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(692, 513);
            Controls.Add(addEmployeesPanel);
            Controls.Add(viewEmployeesPanel);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            viewEmployeesPanel.ResumeLayout(false);
            viewEmployeesPanel.PerformLayout();
            addEmployeesPanel.ResumeLayout(false);
            addEmployeesPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBoxManager;
        private Label label1;
        private DataGridView dataGridView1;
        private Panel viewEmployeesPanel;
        private Panel addEmployeesPanel;
        private Label label3;
        private ComboBox addEmployees_Managercmbox;
        private Label label2;
        private Button button1;
        private Label label4;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private Label label7;
        private RichTextBox rolesrichTextBox;
        private TextBox lastNameTextBox;
        private Label label6;
        private TextBox firstNameTextBox;
        private Label label5;
        private TextBox empIDTextBox;
        private Button saveButton;
        private Button cancelButton;
    }
}
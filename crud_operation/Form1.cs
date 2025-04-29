using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace crud_operation
{
    public partial class Form1 : Form
    {
        Employee emp = new Employee();
        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = emp.Getemploye();
        }

        //private void Form1_Load(object sender, EventArgs e)
        //{
        //    // TODO: This line of code loads data into the 'employeeDataSet.employe' table. You can move, or remove it, as needed.
        //    this.employeTableAdapter.Fill(this.employeeDataSet.employe);

        //}

        class Employee
        {
            private static String mycon = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
            public int id { get; set; }
            public string name { get; set; }
            public int age { get; set; }
            public int salary { get; set; }
            public string department { get; set; }

            private const string SelectQuery = "select * from employe";
            private const string InsertQuery = "insert into employe(id,name,age,salary,department)values(@id,@name,@age,@salary,@department)";
            private const string UpadteQuery = "update employe set name=@name,age=@age,salary=@salary,department=@department where id=@id";
            private const string DeleteQuery = "delete from employe where id=@id";

            public DataTable Getemploye()
            {
                var datatable = new DataTable();
                using (SqlConnection con = new SqlConnection(mycon))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(SelectQuery, con))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(datatable);
                        }

                    }
                }
                return datatable;
            }

            public bool InsertEmployeDetails(Employee emp)
            {
                int rows;
                using (SqlConnection con = new SqlConnection(mycon))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(InsertQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@id", emp.id);
                        cmd.Parameters.AddWithValue("@name", emp.name);
                        cmd.Parameters.AddWithValue("@age", emp.age);
                        cmd.Parameters.AddWithValue("@salary", emp.salary);
                        cmd.Parameters.AddWithValue("@department", emp.department);
                        rows = cmd.ExecuteNonQuery();


                    }
                   
                }

                return (rows > 0) ? true : false;
            }

            public bool UpdateEmployeDetails(Employee emp)
            {
                int rows;
                using (SqlConnection con = new SqlConnection (mycon))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(UpadteQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@id",emp.id);
                        cmd.Parameters.AddWithValue("@name", emp.name);
                        cmd.Parameters.AddWithValue("@age", emp.age);
                        cmd.Parameters.AddWithValue("@salary", emp.salary);
                        cmd.Parameters.AddWithValue("@department", emp.department);
                        rows = cmd.ExecuteNonQuery();
                    }
                }
                return (rows>0) ? true : false;
            }

            public bool DeleteEmployeDetails(Employee emp)
            {
                int rows;
                using (SqlConnection con = new SqlConnection(mycon))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(DeleteQuery,con))
                    {
                        cmd.Parameters.AddWithValue("@id", emp.id);
                        rows = cmd.ExecuteNonQuery();
                    }

                }
                return(rows > 0)? true:false;
            }
            
        }

        private void insert_Click(object sender, EventArgs e)//insert
        {
            if (int.TryParse(id_txt.Text, out int id) &&
                int.TryParse(age_txt.Text, out int age) &&
                 int.TryParse(salary_txt.Text, out int salary))
            {
                emp.id = id;
                emp.name = name_txt.Text;
                emp.age = age;
                emp.salary = salary;
                emp.department = department_txt.Text;

                var success = emp.InsertEmployeDetails(emp);
                dataGridView1.DataSource = emp.Getemploye();

                if (success)
                {
                    id_txt.Text = "";
                    name_txt.Text = "";
                    age_txt.Text = "";
                    salary_txt.Text = "";
                    department_txt.Text = "";
                    MessageBox.Show("Data inserted successfully");
                }
                else
                {
                    MessageBox.Show("Data is not inserted");
                }
            }
            else
            {
                MessageBox.Show("Please enter valid numeric values for ID, Age, and Salary.");
            }


        }

        private void delete_Click(object sender, EventArgs e)//delete
        {
            if (int.TryParse(id_txt.Text, out int id))
            {
                emp.id = id;
                var success = emp.DeleteEmployeDetails(emp);
                dataGridView1.DataSource = emp.Getemploye();

                if (success)
                {
                    id_txt.Text = "";
                    name_txt.Text = "";
                    age_txt.Text = "";
                    salary_txt.Text = "";
                    department_txt.Text = "";
                    MessageBox.Show("Employee deleted");
                }
                else
                {
                    MessageBox.Show("Employee not deleted");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid numeric value for ID.");
            }

        }

        private void update_Click(object sender, EventArgs e)//update
        {
            if (int.TryParse(id_txt.Text, out int id) &&
    int.TryParse(age_txt.Text, out int age) &&
    int.TryParse(salary_txt.Text, out int salary))
            {
                emp.id = id;
                emp.name = name_txt.Text;
                emp.age = age;
                emp.salary = salary;
                emp.department = department_txt.Text;

                var success = emp.UpdateEmployeDetails(emp);
                dataGridView1.DataSource = emp.Getemploye();

                if (success)
                {
                    MessageBox.Show("Employee has been updated");
                }
                else
                {
                    MessageBox.Show("Employee details have not been updated");
                }
            }
            else
            {
                MessageBox.Show("Please enter valid numeric values for ID, Age, and Salary.");
            }



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)//grid
        {
            var index = e.RowIndex;
            id_txt.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
            name_txt.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            age_txt.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
            salary_txt.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
            department_txt.Text = dataGridView1.Rows[index].Cells[4].Value.ToString();
        }
    }
}
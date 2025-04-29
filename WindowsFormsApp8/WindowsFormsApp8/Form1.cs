using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        student stud = new student();
        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = stud.GetStudent();


        }

        //private void Form1_Load(object sender, EventArgs e)
       // {
            //SqlDataAdapter da = new SqlDataAdapter("select * from stu", "Data Source = DESKTOP - 9BKCGLF\\SQLEXPRESS; Initial Catalog = studentdb; Integrated Security = True");
            //DataSet ds = new DataSet();
            //da.Fill(ds, "stu");
            //dataGridView1.DataSource = ds.Tables["stu"].DefaultView;
        
       // }

        class student
        {
            private static string myConn = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;

            public int StudentId { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            private const string SelectQuery = "Select * from stu";
            private const string InsertQuery = "Insert Into stu(StudentId, FirstName, LastName) Values (@StudentId, @FirstName, @LastName)";
            private const string UpdateQuery = "Update stu set FirstName = @FirstName, LastName = @Lastname where StudentId = @StudentId";
            private const string DeleteQuery = "Delete from stu where StudentId= @StudentId";
           public DataTable GetStudent()
            {
               var datatable = new DataTable();
               using (SqlConnection con = new SqlConnection(myConn))
                {
                   con.Open();
                    using (SqlCommand com = new SqlCommand(SelectQuery, con))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(com))
                        {
                            adapter.Fill(datatable);
                        }
                    }
                }
                return datatable;
            }
            public bool InsertStudentDetails(student stud)
            {
                int rows;
                using (SqlConnection con = new SqlConnection(myConn))
                {
                    con.Open();
                    using (SqlCommand com = new SqlCommand(InsertQuery, con))
                    {
                        com.Parameters.AddWithValue("@StudentId", stud.StudentId);
                        com.Parameters.AddWithValue("@FirstName", stud.FirstName);
                        com.Parameters.AddWithValue("@LastName", stud.LastName);
                        rows = com.ExecuteNonQuery();
                    }
                }
                return (rows > 0) ? true : false;
            }
         
            public bool UpdateStudentDetails(student stud)
            {
                int rows;
                using (SqlConnection con = new SqlConnection(myConn))
                {
                    con.Open();
                    using (SqlCommand com = new SqlCommand(UpdateQuery, con))
                    {
                        //com.Parameters.AddWithValue("@StudentId", stud.StudentId);
                        //com.Parameters.AddWithValue("@FirstName", stud.FirstName);
                        //com.Parameters.AddWithValue("@LastName", stud.LastName);
                        com.Parameters.AddWithValue("@StudentId", StudentId);
                        com.Parameters.AddWithValue("@FirstName", FirstName);
                        com.Parameters.AddWithValue("@LastName", LastName);
                        rows = com.ExecuteNonQuery();
                    }
                }
                return (rows > 0) ? true : false;
            }
            public bool DeleteStudentDetails(student stud)
            {
                int rows;
                using (SqlConnection con = new SqlConnection(myConn))
                {
                    con.Open();
                    using (SqlCommand com = new SqlCommand(DeleteQuery, con))
                    {
                        com.Parameters.AddWithValue("@StudentId", stud.StudentId);
                        rows = com.ExecuteNonQuery();
                    }
                }
                return (rows > 0) ? true : false;
            }
 }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            {
                ClearControls();
            }

             void ClearControls()
            {
                id_txt.Text = " ";
                fname_txt.Text = " ";
                lname_txt.Text = " ";

            }

        }

        private void Btn_Insert_Click(object sender, EventArgs e)
        {
            {
                stud.StudentId = Convert.ToInt16(id_txt.Text);
                stud.FirstName = fname_txt.Text;
                stud.LastName = lname_txt.Text;
              
                // Call Insert Employee method to insert the employee details to database
                var success = stud.InsertStudentDetails(stud);
                // Refresh the grid to show the updated employee details
                
                dataGridView1.DataSource = stud.GetStudent();
                if (success)
                {
                    //SqlDataAdapter da = new SqlDataAdapter("select * from stu", "server = DESKTOP-9BKCGLF\\SQLEXPRESS;database = studentdb");
                    //DataSet ds = new DataSet();
                    //da.Fill(ds, "stu");
                    // dataGridView1.DataSource = ds.Tables["stu"].DefaultView;
                    // Clear controls once the student is inserted successfully
                    id_txt.Text = " ";
                    fname_txt.Text = " ";
                    lname_txt.Text = " ";
                    MessageBox.Show("Student has been added successfully");
                }
                else
                    MessageBox.Show("Error occured. Please try again...");
            }

        }

      
           // private void btn_Update_Click(object sender, EventArgs e)
            
        private void btn_delete_Click(object sender, EventArgs e)
        {
            //stud.StudentId = int.Parse(id_txt.Text);
            stud.StudentId =Convert.ToInt16(id_txt.Text);

            // Call DeleteEmployee method to delete the selected employee from database
            var success = stud.DeleteStudentDetails(stud);
            // Refresh the grid to show the updated employee details
            //SqlDataAdapter da = new SqlDataAdapter("select * from stu", "server = DESKTOP-9BKCGLF\\SQLEXPRESS;database = studentdb");
            //DataSet ds = new DataSet();
            //da.Fill(ds, "stu");
            //dataGridView1.DataSource = ds.Tables["stu"].DefaultView;
            //dataGridView1.DataSource = stud.GetStudent();
            dataGridView1.DataSource = stud.GetStudent();
            if (success)
            {
                // Clear controls once the employee is inserted successfully
                id_txt.Text = " ";
                fname_txt.Text = " ";
                lname_txt.Text = " ";

                MessageBox.Show("Student has been deleted successfully");
            }
            else
                MessageBox.Show("Error occured. Please try again...");
        }
        // Clear all controls when clicks clear button
       
        //private void dgvStudentDetails_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
       
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            {
                var index = e.RowIndex;
                id_txt.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
                fname_txt.Text = dataGridView1.Rows[index].Cells[1].Value.ToString(); 
                lname_txt.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();

            }

        }

        private void btn_update_Click_1(object sender, EventArgs e)
        {
            {
                //stud.StudentId = id_txt.Text.ToString();
                stud.StudentId = int.Parse(id_txt.Text);
                stud.FirstName = fname_txt.Text;
                stud.LastName = lname_txt.Text;

                // Call Update Employee method to update the selected employee details to database
                var success = stud.UpdateStudentDetails(stud);
                // Refresh the grid to show the updated employee details
                dataGridView1.DataSource = stud.GetStudent();
                if (success)
                {
                    // Clear controls once the employee is inserted successfully
                    //SqlDataAdapter da = new SqlDataAdapter("select * from stu", "server = DESKTOP-9BKCGLF\\SQLEXPRESS;database = studentdb");
                    //DataSet ds = new DataSet();
                    //da.Fill(ds, "stu");
                    //dataGridView1.DataSource = ds.Tables["stu"].DefaultView;

                    //ClearControls();

                    MessageBox.Show("Student has been updated successfully");
                }
                else
                    MessageBox.Show("Error occured. Please try again...");
            }

       }

      
    }
    }






        

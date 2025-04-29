using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CRUD_practiceexample
{
    public partial class Form1 : Form
    {
        Student stu = new Student();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbDataSet1.ST' table. You can move, or remove it, as needed.
            this.sTTableAdapter1.Fill(this.dbDataSet1.ST);
            // TODO: This line of code loads data into the 'dbDataSet.ST' table. You can move, or remove it, as needed.
            this.sTTableAdapter.Fill(this.dbDataSet.ST);

        }
        class Student
        {
            private static string mycon = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;

            public int StudentId { get; set; }

            public string FirstName { get; set; }

            public string LastName {  get; set; }
        }
        private const string SelectQuery = "Select * from db";
        private const string InsertQuery = " insert into db(StudentId,FirstName,LastName)";
        private const string UpdateQuery = "update db set FirstName=@Firstname,LastName = Lastname where StudentID=@Studentid";
        
        private readonly string mycon;

        public DataTable GetStudent()
        {
            var datatable = new DataTable();
            using (SqlConnection conn = new SqlConnection(mycon))
            {
                conn.Open();
                using(SqlCommand cmd= new SqlCommand(SelectQuery, conn))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(datatable);
                    }

                }
                
            }
            return datatable;
        }
        public bool InsertStudentDetails(Student stu)
        {
            int rows;
            using (SqlConnection conn = new SqlConnection())
            {
                cmd.Parameters.AddWithValue("@StudentId",stu.StudentId);
                cmd.Parameters.AddWithValue("@FirstName", stu.FirstName);
                cmd.Parameters.AddWithValue("@LastName", stu.LastName);
                rows = cmd.ExecuteNonQuery();

            }
        }
        Return (RowStyle > 0) ? true:false;

    }
private void btn_insert_Click(object sender, EventArgs e)
    {
        Stu.StudentId = Convert.ToInt16(id_txt);
        StringUnit.FirstName = fname_txt.Text;
        StringUnit.LastName = lname_txt.Text;

        var sucess = stu.InsertStudentDetails(stu);

        DataGridView.DataSource = stu.GetStudent();
        if(sucess)
        {
            id_txt.Text = " ";
            fname_txt.Text = " ";
            lname_txt.Text = " ";

            MessageBox.Show("Student has been sucessfully added");
        }
    }

}

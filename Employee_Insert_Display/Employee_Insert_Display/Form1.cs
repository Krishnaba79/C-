using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Employee_Insert_Display
{
    public partial class Form1 : Form
    {

        string connectionString = @"Data Source=DESKTOP-F5LH3NF\SQLEXPRESS;Initial Catalog=winformemp;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";
        public Form1()
        {
            InitializeComponent();
        }

        // display employee data in the DataGridView when the form loads
        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayEmployees();
        }

        // Button click event to add a new employee to the database
        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            // insert query
            string query = "INSERT INTO Employees (Name, Position, Salary) VALUES (@Name, @Position, @Salary)";

            //SQL connection 
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", txtEmployeeName.Text);
                    cmd.Parameters.AddWithValue("@Position", txtPosition.Text);
                    cmd.Parameters.AddWithValue("@Salary", decimal.Parse(txtSalary.Text));

                    // Open Connection
                    conn.Open();

                    // execute query
                    cmd.ExecuteNonQuery();

                    // close the connection
                    conn.Close();
                }
            }

            // clear input field after insering data
            txtEmployeeName.Clear();
            txtPosition.Clear();
            txtSalary.Clear();

            // Refresh the Data Grid to display new data
            DisplayEmployees();

        }

        // Method to display employee data in Grid
        private void DisplayEmployees()
        {
            //Select * query
            string query = "SELECT * FROM Employees";

            // SQL Connection
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridViewEmployees.DataSource = dt;
            }
        }
    }
}

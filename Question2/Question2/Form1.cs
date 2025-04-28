using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void insert_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=KRISHNA\\SQLEXPRESS02;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);

            con.Open();

            string name = text1.Text;
            string rollno = text2.Text;
            string course = text3.Text;
            string Query = "INSERT INTO exam1 (NAME, ROLLNO, COURSE) VALUES('" + name + "' , '" + rollno + "', '" + course +"')";
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data insert Successfully");

        }
    }
}

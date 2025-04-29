
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Registration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
             string ConnectionString = "Data Source=DESKTOP-9BKCGLF\\SQLEXPRESS;Initial Catalog=myDB1;Integrated Security = True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string firstname = Firstname_txt.Text;
            string lastname = Lastname_txt.Text;
            string Query = "INSERT INTO DETAILS1(FIRSTNAME, LASTNAME) VALUES('" + firstname + "', '" + lastname + "')";
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Saved Successfully");

        }
    }
}

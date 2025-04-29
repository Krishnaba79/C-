using Antlr.Runtime.Misc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) 
            {
                if (Session["number1"]!=null && Session["number2"]!=null)
                {
                    txtName.Text = Session["number1"].ToString();   
                    txtName.ReadOnly = true;

                    txtName1.Text = Session["number1"].ToString();
                    txtName1.ReadOnly = true;
                }
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            int result = 0;
            Session["number1"]=txtName.Text;
            Session["number2"]=txtName1.Text;

            txtName.Enabled = false;
            txtName1.Enabled = false;
            ddl.Enabled = false;
            btnSubmit.Enabled = false;

            int number1 = Convert.ToInt32(txtName.Text);
            int number2 = Convert.ToInt32(txtName1.Text);

            string option = ddl.SelectedValue;
            switch (option)
            {
                case "1":
                    result = number1 + number2;
                    Console.WriteLine(result);
                    break;
                case "2":
                    result = number1 - number2;
                    Console.WriteLine(result);
                    break;
                case "3":
                    result = number1 / number2;
                    Console.WriteLine(result);
                    break;
                case "4":
                    result = number1 * number2;
                    Console.WriteLine(result);
                    break;
                default:
                    lblResult.Text = "InvalidcOperation";
                    return;
            }
            lblResult.Text = "Result : " + result.ToString();


        }

    }
}
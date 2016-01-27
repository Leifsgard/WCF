using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Client.ServiceReference1;

namespace Client
{
    public partial class AddThreeNumbersWebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.WebService1SoapClient client = new WebService1SoapClient();
            Label1.Text = client.AddThreeNumbers(TextBox1.Text, TextBox2.Text, TextBox3.Text).ToString();

        }
    }
}
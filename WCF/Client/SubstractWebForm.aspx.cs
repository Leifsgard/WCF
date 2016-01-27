using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Client.SubstractService;

namespace Client
{
    public partial class SubstractWebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SubstractService.SubstractServiceSoapClient client = new SubstractServiceSoapClient();
            Label1.Text = client.SubstractTwo(TextBox1.Text, TextBox2.Text).ToString();
        }
    }
}
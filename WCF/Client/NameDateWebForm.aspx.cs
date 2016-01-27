using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Client.NameDateService;

namespace Client
{
    public partial class NameDateWebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           
            NameDateService.NameDateSoapClient client = new NameDateSoapClient();
            Label1.Text = client.PrintDateForName(TextBox1.Text);
        
    }
    }
}
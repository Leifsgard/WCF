﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Client.ServiceReference2;

namespace Client
{
    public partial class AddTwoNumbersWebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            ServiceReference2.AddTwoServiceSoapClient client = new AddTwoServiceSoapClient();
            Label1.Text = client.AddTwo(TextBox1.Text, TextBox2.Text).ToString();

        }
    }
}
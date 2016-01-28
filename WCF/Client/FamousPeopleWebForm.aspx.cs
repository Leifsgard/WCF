using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using Client.FamousPeopleService;

namespace Client
{
    public partial class FamousPeopleWebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var text = File.ReadAllLines($"C:/Users/Rasmus/Desktop/WCF/WCF/WCF/Resources/FamousPeopleDiedInPlaneCrash.txt");
            foreach (var item in text)
            {
                var yearList = item.Split(';');
                TextBox2.Text += yearList[0] + "\r\n";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           FamousPeopleService.FamousPeopleDiedInPlanecrashSoapClient client = new FamousPeopleDiedInPlanecrashSoapClient();
            Label1.Text = client.GetPersonFromList(TextBox1.Text);
        }

    }
}
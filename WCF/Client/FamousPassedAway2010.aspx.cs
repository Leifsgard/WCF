using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using Client.PeoplePassedAway2010Service;

namespace Client
{
    public partial class FamousPassedAway2010 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var text = File.ReadAllLines($"C:/Users/Rasmus/Desktop/WCF/WCF/WCF/Resources/PeopleThatPassedAway2010.txt");
            foreach (var item in text)
            {
                var yearList = item.Split(':');
                TextBox2.Text += yearList[0] + "\r\n";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            PeoplePassedAway2010Service.PeopleWhoPassedAway2010SoapClient client = new PeopleWhoPassedAway2010SoapClient();
            Label1.Text = client.PersonWhoPassedAway(TextBox1.Text);
    }
    }
}
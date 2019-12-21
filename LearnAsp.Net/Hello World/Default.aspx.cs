using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Hello_World
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HelloWorldLabel.Text = "Hello World!";

        }

        protected void GreetButton_Click(object sender, EventArgs e)
        {
            HelloWorldLabel.Text = "Hello " + TextInput.Text;
        }

        protected void GreetList_SelectedIndexChanged(object sender, EventArgs e)
        {
            HelloWorldLabel.Text = "Hello, " + GreetList.SelectedValue;
        }

        protected void btnSubmitForm_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                btnSubmitForm.Text = "My form is valid!";
            }
        }
    }
}
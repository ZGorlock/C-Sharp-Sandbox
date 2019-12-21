using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace State
{
    ////Cookies
    //public partial class _Default : Page
    //{
    //    protected void Page_Load(object sender, EventArgs e)
    //    {
    //        if (Request.Cookies["BackgroundColor"] != null)
    //        {
    //            ColorSelector.SelectedValue = Request.Cookies["BackgroundColor"].Value;
    //            BodyTag.Style["background-color"] = ColorSelector.SelectedValue;
    //        }
    //        if (ViewState["NameOfUser"] != null)
    //            NameLabel.Text = ViewState["NameOfUser"].ToString();
    //        else
    //            NameLabel.Text = "Not set yet...";
    //    }

    //    protected void ColorSelector_IndexChanged(object sender, EventArgs e)
    //    {
    //        BodyTag.Style["background-color"] = ColorSelector.SelectedValue;
    //        HttpCookie cookie = new HttpCookie("BackgroundColor");
    //        cookie.Value = ColorSelector.SelectedValue;
    //        cookie.Expires = DateTime.Now.AddHours(1);
    //        Response.SetCookie(cookie);
    //    }
    //}

    //Sessions
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["BackgroundColor"] != null)
            {
                ColorSelector.SelectedValue = Session["BackgroundColor"].ToString();
                BodyTag.Style["background-color"] = ColorSelector.SelectedValue;
            }

            if (ViewState["NameOfUser"] != null)
                NameLabel.Text = ViewState["NameOfUser"].ToString();
            else
                NameLabel.Text = "Not set yet...";
        }

        protected void ColorSelector_IndexChanged(object sender, EventArgs e)
        {
            BodyTag.Style["background-color"] = ColorSelector.SelectedValue;
            Session["BackgroundColor"] = ColorSelector.SelectedValue;
        }




        protected void SubmitForm_Click(object sender, EventArgs e)
        {
            ViewState["NameOfUser"] = NameField.Text;
            NameLabel.Text = NameField.Text;
        }
    }


}
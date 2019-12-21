using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Validation
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void cusCustom_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if (args.Value.Length == 8)
                args.IsValid = true;
            else
                args.IsValid = false;
        }

    }
}
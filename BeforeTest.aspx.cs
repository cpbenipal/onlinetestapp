using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class BeforeTest : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.ExpiresAbsolute = DateTime.Now.Subtract(new TimeSpan(1, 0, 0, 0));
        Response.Expires = 0;
        Response.CacheControl = "no-cache";

    }
    protected void btnyes_Click(object sender, EventArgs e)
    {
        Response.Redirect("DisplayTest.aspx");
    }
    protected void btnno_Click(object sender, EventArgs e)
    {
        Response.Redirect("Instruction.aspx");
    }
}
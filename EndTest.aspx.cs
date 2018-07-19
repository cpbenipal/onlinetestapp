using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class EndTest : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["StudentId"] == null)
        {
            Response.Write("<script>window.close()</script>");
            //Response.Redirect("Login.aspx");
            
        }
       Response.Cache.SetNoStore();
       if (!IsPostBack)
       {
           Result();
          //
           Session.Abandon();
       }

    }
   

    protected void btnendtest_Click(object sender, EventArgs e)
    {
        Response.Write("<script>window.close()</script>");
       // Response.Redirect("Login.aspx");
    }

    protected void Result()
    {
        ClsResult obj = new ClsResult();
        obj.StudentId = Session["StudentId"].ToString();
        obj.Testid = Session["TestId"].ToString();
        DataSet ds = new DataSet();
        ds = obj.Result();
        obj.result = ds.Tables[0].Rows.Count;
        obj.InsertResult();
    }
}
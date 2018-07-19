using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class DisplayTest : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            displaytest();
        }
    }

    //private void ddlshowcollege()
    //{
    //    clstestdetail obj = new clstestdetail();
    //    DataSet ds = obj.ddlcollege();
    //    clsCommon.FillBoundControl(ddlcollege, ds, "COLLEGENAME", "COLLEGEID", "Select College", false);
    //}



    //[System.Web.Script.Services.ScriptMethod()]
    //[System.Web.Services.WebMethod]
    //public static List<string> Getitem(string prefixText)
    //{
    //    clstestdetail obj = new clstestdetail();
    //    obj.Perfix = prefixText;
    //    DataSet ds = obj.auto_complete();

    //    List<string> item_name = new List<string>();
    //    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
    //    {
    //        item_name.Add(ds.Tables[0].Rows[i][0].ToString());
    //    }
    //    return item_name;

    //}


    private void displaytest()
    {
        ClsResult obj = new ClsResult();
        obj.StudentId = Session["StudentId"].ToString();
        DataSet ds = new DataSet();
        ds = obj.Showtest();
        grddisplaytest.DataSource = ds;
        grddisplaytest.DataBind();
    }
    protected void ddlcollege_SelectedIndexChanged(object sender, EventArgs e)
    {
        displaytest();
    }
    protected void grddisplaytest_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        Session["TestId"] = grddisplaytest.DataKeys[e.RowIndex].Values[0].ToString();
        string testname = ((Label)(grddisplaytest.Rows[e.RowIndex].FindControl("lbltestname"))).Text;
        Response.Redirect("TakeTest.aspx?TestName="+testname);

        //ScriptManager.RegisterStartupScript(this, typeof(string), "OPEN_WINDOW",
        //    "var Mleft = (screen.width/2)-(760/2);var Mtop = (screen.height/2)-(700/2);window.open( 'TakeTest.aspx', null, 'height=700,width=760,status=yes,toolbar=no,scrollbars=yes,menubar=no,location=no,top=\'+Mtop+\', left=\'+Mleft+\'' );", true);
    }
    protected void grddisplaytest_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        //string id = grddisplaytest.DataKeys[e.RowIndex].Values[0].ToString();
        //clstestdetail obj = new clstestdetail();
        //obj.TestId = id;
        //obj.Deletetest();
        //displaytest();
    }
    protected void grddisplaytest_RowEditing(object sender, GridViewEditEventArgs e)
    {
        grddisplaytest.EditIndex = e.NewEditIndex;
        displaytest();
    }
    protected void grddisplaytest_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        //clstestdetail obj = null;
        //try
        //{
        //    obj = new clstestdetail();

        //    int index = grddisplaytest.EditIndex;
        //    GridViewRow row = grddisplaytest.Rows[index];
        //    obj.TestId = grddisplaytest.DataKeys[e.RowIndex].Values[0].ToString();
        //    obj.TestPurpose = ((TextBox)row.Cells[1].FindControl("txttestname")).Text.ToString();
        //    obj.NoOfStudent = Convert.ToInt32(((TextBox)row.Cells[2].FindControl("txttotalstu")).Text);
        //    obj.Duration = Convert.ToInt32(((TextBox)row.Cells[3].FindControl("txtduration")).Text);
        //    obj.NoOfQuestion = Convert.ToInt32(((TextBox)row.Cells[4].FindControl("txttotalquestion")).Text);
        //    obj.Updatetestdetail();
        //    grddisplaytest.EditIndex = -1;
        //    displaytest();
        //}
        //catch (Exception ex)
        //{
        //    throw ex;
        //}
        //finally
        //{
        //    obj = null;
        //}

    }
    protected void btnsearch_Click(object sender, EventArgs e)
    {
        //displaytest();
        //txtsearch.Text = string.Empty;
    }
}
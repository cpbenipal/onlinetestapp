using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EncryptDecrypt;
using System.Data.SqlClient;
public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       

        Control c = this.Master.FindControl("NavigationMenu");
        c.Visible = false;
        if (Page.IsPostBack == false)
        {
            //chklist();
        }
    }

    //private void chklist()
    //{

    //    DataSet ds = null;
    //    ClsStudentDetail obj = null;
    //    try
    //    {
    //        obj = new ClsStudentDetail();
    //        ds = obj.dropdown();
    //        clsCommon.FillBoundControl(DDlGroup, ds, "GRPNAM", "GRPID", "Select Group", false);
    //    }
    //    catch (Exception ex)
    //    {
    //        throw ex;
    //    }
    //    finally
    //    {
    //        ds = null;
    //        obj = null;
    //    }

    //}
 


    protected void btnlogin_Click(object sender, EventArgs e)
    {
        ClsStudentDetail obj = new ClsStudentDetail();       
        bool status = false;
        if (Txtusername.Text != string.Empty && Txtpassword .Text != string.Empty)
        {
            SqlDataReader dr = null;
            SqlDataReader dr1 = null;
            obj.UserName = Txtusername.Text.Trim();
            obj.Password = Txtpassword.Text.Trim();//clsEncryptDecrypt.EncryptText(Txtpassword.Text.Trim());
            //obj.Role = DDlGroup.SelectedValue.ToString();
            dr = obj.CheckExistUser();
            dr1 = obj.CheckExistUser1();
            if (dr.HasRows || dr1.HasRows)
            {
                lblmsg.Text = "Sorry ! You Can Give Test Only Once";
            }
            else
            {

                status = obj.LoginCheck();
                if (status == true)
                {
                    //Response.Redirect("Instruction.aspx");
                    //lblmsg.Text = "Login";
                    ScriptManager.RegisterStartupScript(this, typeof(string), "OPEN_WINDOW",
                     "var Mleft = (screen.width/2)-(760/2);var Mtop = (screen.height/2)-(700/2);window.open( 'Instruction.aspx', null, 'height=1000,width=1200,status=no,toolbar=no,scrollbars=yes,resizable=no,titlebar=no,menubar=no,location=center,top=\'+Mtop+\', left=\'+Mleft+\'' );", true);
                    lblmsg.Text = string.Empty;
                }
                else
                {
                    lblmsg.Text = "Check your UserName or Password";
                }
            }
        }
        else
        {
            lblmsg.Text = "Enter username and password";
        } 
                   
    }
    protected void lnbforgetpwd_Click(object sender, EventArgs e)
    {
        Response.Redirect("PasswordRecovery.aspx");
    }
    protected void lnbnewaccount_Click(object sender, EventArgs e)
    {
        Response.Redirect("StudentRegistration.aspx");
    }
    protected void DDlGroup_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
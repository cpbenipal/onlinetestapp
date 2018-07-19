using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
//using System.Windows.Forms;
using System.Text;

public partial class TakeTest : System.Web.UI.Page
{
    public static Int32 totalQs;
    public static bool IsLastQs;

    static DataSet ds;

    long timerStartValue = 1800;
    protected void Page_Load(object sender, EventArgs e)
    {



        if (Session["StudentId"] == null)
        {
            //Response.Write("<script>alert('Your Session Timer has Expired! We are Sorry!')</script>");
            Response.Redirect("Login.aspx");
        }
        if (!IsPostBack)
        {

            //ClsTakeTest obj = new ClsTakeTest();
            // obj.Testid = "BA8C31B9-F1E5-483A-AF3F-A8D867372E80";
            //obj.TestSet = "A";
            ClsTakeTest obj = new ClsTakeTest();
            // gettestduration();
            obj.Testid = Session["TestId"].ToString();
            ds = obj.DisplayQuestionSet();
            totalQs = ds.Tables[0].Rows.Count;
            lbltotalquestion.Text = totalQs.ToString();
            Question.Text = "1";
            Label5.Text = "Q:" + " " + Question.Text;
            LoadQuestion();
            DataSet questions = new DataSet("Questions");
            questions.Tables.Add();
            //Response.Cache.SetNoStore();
            //Response.Cache.SetExpires(DateTime.UtcNow.AddMinutes(-1));
            //Response.Cache.SetCacheability(HttpCacheability.NoCache);
            //Response.Cache.SetNoStore();
            //lbltestname.Text = Request.QueryString["TestName"];

        }

    }






    protected int gettestduration()
    {
        ClsTakeTest obj = new ClsTakeTest();
        SqlDataReader dr = null;
        obj.Testid = Session["TestId"].ToString();
        dr = obj.Gettestduration();
        int duration = 0;
        if (dr.HasRows)
        {
            dr.Read();
            duration = Convert.ToInt32(dr["DURATION"]);
        //    return duration;
        }
        dr.Close();
        return duration;       

    }





    protected void Page_Init(object Sender, EventArgs e)
    {
        Response.Cache.SetCacheability(HttpCacheability.NoCache);
        Response.Cache.SetExpires(DateTime.Now.AddDays(-1));
    }


    void Page_PreInit(object sender, EventArgs e)
    {
        string timerVal = Request.Form["timerData"];
        if (timerVal != null || timerVal == "")
        {
            timerVal = timerVal.Replace(",", String.Empty);
            timerStartValue = long.Parse(timerVal);
        }
    }



    private Int32 TimerInterval
    {
        get
        {
            object o = ViewState["timerInterval"];
            if (o != null) { return Int32.Parse(o.ToString()); }
            return 50;
        }
        set
        {
            ViewState["timerInterval"] = value;
        }
    }

    void RedirectToResults()
    {


        //string mystring = " Test Finish ";
        //ClientScript.RegisterStartupScript(this.GetType(), "show_alert", "alert('" + mystring + "');", true);
        Response.Redirect("EndTest.aspx");




    }

    protected void LoadQuestion()
    {
        if (ds.Tables[0].Rows.Count > 0)
        {
            //Load Question;
            DataRow DR = ds.Tables[0].Rows[0];

            lblquestionid.Text = DR[0].ToString();
            lblquestion.Text = DR[1].ToString();
            ClsTakeTest obj1 = new ClsTakeTest();
            obj1.Testid = Session["TestId"].ToString();
            obj1.TestSet = "A";
            obj1.QuestionId = lblquestionid.Text.ToString();
            DataSet dsoption = obj1.TestAnswer();
            if (DR[2].ToString() == "1")
            {
                btnnext.Visible = true;
                btnnext1.Visible = false;
                rdoquestionoption.Visible = true;
                chkquestionoption.Visible = false;
                rdoquestionoption.DataTextField = "ANSWEROPTION";
                rdoquestionoption.DataValueField = "INTOPTIONID";
                rdoquestionoption.DataSource = dsoption;
                rdoquestionoption.DataBind();
            }
            else
            {
                btnnext.Visible = false;
                btnnext1.Visible = true;
                rdoquestionoption.Visible = false;
                chkquestionoption.Visible = true;
                chkquestionoption.DataTextField = "ANSWEROPTION";
                chkquestionoption.DataValueField = "INTOPTIONID";
                chkquestionoption.DataSource = dsoption;
                chkquestionoption.DataBind();
            }






            ds.Tables[0].Rows.Remove(DR);

            if (Question.Text.Equals(totalQs.ToString()))
            {
                IsLastQs = true;
            }
        }
        else
        {
            //End Of File;
            //Response.Write("<script>alert('Thanks For Your Presence! You Can Leave Now.')</script>");
            //Session.Abandon();
            // RedirectToResults();     
            Response.Redirect("EndTest.aspx");

        }
    }

    protected void btnskip_Click(object sender, EventArgs e)
    {
        LoadQuestion();
        Question.Text = ((Convert.ToInt32(Question.Text)) + 1).ToString();
        Label5.Text = "Q:" + " " + Question.Text;
    }
    protected void btnnext_Click(object sender, EventArgs e)
    {



        //Write your code here to save the question
        ClsTakeTest obj = new ClsTakeTest();
        obj.QuestionId = lblquestionid.Text;
        obj.Testid = Session["TestId"].ToString();
        obj.StudentId = Session["StudentId"].ToString();
        if (rdoquestionoption.Visible == true)
        {
            obj.Studentanswer = clsCommon.GetListSelectValues(rdoquestionoption);
        }
        else
        {
            obj.Studentanswer = clsCommon.GetListSelectValues(chkquestionoption);
        }
        obj.StudentAnswer();

        //Displays the Next Question

        LoadQuestion();
        Question.Text = ((Convert.ToInt32(Question.Text)) + 1).ToString();
        Label5.Text = "Q:" + " " + Question.Text;



    }


    protected void btnnext1_Click(object sender, EventArgs e)
    {
        try
        {


            //Write your code here to save the question
            ClsTakeTest obj = new ClsTakeTest();
            obj.QuestionId = lblquestionid.Text;
            obj.Testid = Session["TestId"].ToString();
            obj.StudentId = Session["StudentId"].ToString();
            if (rdoquestionoption.Visible == true)
            {
                obj.Studentanswer = clsCommon.GetListSelectValues(rdoquestionoption);
            }
            else
            {
                obj.Studentanswer = clsCommon.GetListSelectValues(chkquestionoption);
            }
            obj.StudentAnswer();

            //Displays the Next Question

            LoadQuestion();
            Question.Text = ((Convert.ToInt32(Question.Text)) + 1).ToString();
            Label5.Text = "Q:" + " " + Question.Text;
        }

        catch (Exception ex)
        {
            Response.Write("<script>alert(''" + ex.Message + "'')</script>");
        }

    }



}
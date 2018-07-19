using System;
using System.Collections.Generic;
using System.Web;
using Microsoft.ApplicationBlocks.Data;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web.Caching;


public class ClsTakeTest
{
    private static string s_sqlcon = System.Configuration.ConfigurationManager.ConnectionStrings["cn"].ConnectionString;

    private string _Testid;
    public string Testid
    {
        get
        {
            return _Testid;
        }
        set
        {
            _Testid = value;
        }
    }

    private string _TestSet;
    public string TestSet
    {
        get
        {
            return _TestSet;
        }
        set
        {
            _TestSet = value;
        }
    }

    private string _QuestionId;
    public string QuestionId
    {
        get
        {
            return _QuestionId;
        }
        set
        {
            _QuestionId = value;
        }
    }

    private string _studentanswer;
    public string Studentanswer
    {
        get
        {
            return _studentanswer;
        }
        set
        {
            _studentanswer = value;
        }
    }


    private string _studentid;
    public string StudentId
    {
        get
        {
            return _studentid;
        }
        set
        {
            _studentid = value;
        }
    }


    public DataSet TestQuestion()
    {
        SqlParameter[] param = null;
        try
        {
            param = new SqlParameter[2];
            param[0] = new SqlParameter("@TESTID", Testid);
            param[1] = new SqlParameter("@SET", TestSet);
            return SqlHelper.ExecuteDataset(s_sqlcon, CommandType.StoredProcedure, "[dbo].[TESTQUESTION]", param);
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            param = null;
        }
    }

    public DataSet TestAnswer()
    {
        SqlParameter[] param = null;
        try
        {
            param = new SqlParameter[1];
            // param[0] = new SqlParameter("@TESTID", Testid);
            // param[1] = new SqlParameter("@SET", TestSet);
            param[0] = new SqlParameter("@QUESTIONID", QuestionId);
            return SqlHelper.ExecuteDataset(s_sqlcon, CommandType.StoredProcedure, "[dbo].[TESTANSWER]", param);
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            param = null;
        }
    }

    public SqlDataReader Gettestduration()
    {
        SqlParameter[] param = null;       
        try
        {
            param = new SqlParameter[1];
            param[0] = new SqlParameter("@TESTID", Testid);
            return  SqlHelper.ExecuteReader(s_sqlcon, CommandType.StoredProcedure, "[dbo].[GETTESTDURATION]", param);
          
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            param = null;
        }
    }

    public DataSet DisplayQuestionSet()
    {
        SqlParameter[] param = null;
        try
        {
            param = new SqlParameter[1];           
            param[0] = new SqlParameter("@TESTID", Testid);
            return SqlHelper.ExecuteDataset(s_sqlcon, CommandType.StoredProcedure, "[dbo].[DISPLAYQUESTIONSET]", param);
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            param = null;
        }
    }

    public string StudentAnswer()
    {
        SqlParameter[] param = null;
        try
        {
            param = new SqlParameter[4];
            param[0] = new SqlParameter("@STUDENTID", StudentId);
            param[1] = new SqlParameter("@TESTID", Testid);
            param[2] = new SqlParameter("@QUESTIONID", QuestionId);
            param[3] = new SqlParameter("@STUDENTANSWER", Studentanswer);
            return Convert.ToString(SqlHelper.ExecuteNonQuery(s_sqlcon, CommandType.StoredProcedure, "[dbo].[STUDENTANSWER]", param));
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            param = null;
        }
    }
}


public class ClsStudentDetail
{
    private static string s_sqlcon = System.Configuration.ConfigurationManager.ConnectionStrings["cn"].ConnectionString;

    private string _StudentId;
    public string StudentId
    {
        get { return _StudentId; }
        set { _StudentId = value; }
    }

    private string _CollegeId;
    public string CollegeId
    {
        get { return _CollegeId; }
        set { _CollegeId = value; }
    }

    private string _UserName;
    public string UserName
    {
        get { return _UserName; }
        set { _UserName = value; }
    }

    private string _Password;
    public string Password
    {
        get { return _Password; }
        set { _Password = value; }
    }

    private string _StudentName;
    public string StudentName
    {
        get { return _StudentName; }
        set { _StudentName = value; }
    }

    private string _FatherName;
    public string FatherName
    {
        get { return _FatherName; }
        set { _FatherName = value; }
    }

    private string _Qualification;
    public string Qualification
    {
        get { return _Qualification; }
        set { _Qualification = value; }
    }

    private string _PhoneNo;
    public string PhoneNo
    {
        get { return _PhoneNo; }
        set { _PhoneNo = value; }
    }

    private string _Email;
    public string Email
    {
        get { return _Email; }
        set { _Email = value; }
    }

    private DateTime _DateOfBirth;
    public DateTime DateOfBirth
    {
        get { return _DateOfBirth; }
        set { _DateOfBirth = value; }
    }

    private string _Sex;
    public string Sex
    {
        get { return _Sex; }
        set { _Sex = value; }
    }

    private string _SecurityQuestionid;
    public string SecurityQuestionid
    {
        get { return _SecurityQuestionid; }
        set { _SecurityQuestionid = value; }
    }

    private string _SecurityAnswer;
    public string SecurityAnswer
    {
        get { return _SecurityAnswer; }
        set { _SecurityAnswer = value; }
    }

    private string _Address;
    public string Address
    {
        get { return _Address; }
        set { _Address = value; }
    }

    private string _City;
    public string City
    {
        get { return _City; }
        set { _City = value; }
    }

    private string _State;
    public string State
    {
        get { return _State; }
        set { _State = value; }
    }

    private string _ZipCode;
    public string ZipCode
    {
        get { return _ZipCode; }
        set { _ZipCode = value; }
    }

    private string _Role;
    public string Role
    {
        get { return _Role; }
        set { _Role = value; }
    }

    private bool _Status;
    public bool Status
    {
        get { return _Status; }
        set { _Status = value; }
    }


    //**** LOGIN ****///

    public DataSet dropdown()
    {
        return SqlHelper.ExecuteDataset(s_sqlcon, CommandType.StoredProcedure, "DDLLIST");

    }

    public SqlDataReader CheckExistUser()
    {
        SqlParameter[] param = null;
        try
        {
            param = new SqlParameter[2];
            param[0] = new SqlParameter("@USERNAME", UserName);
            param[1] = new SqlParameter("@PASSWORD", Password);
            return SqlHelper.ExecuteReader(s_sqlcon, CommandType.StoredProcedure, "CHECKLOGIN", param);
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            param = null;
        }
    }

    public SqlDataReader CheckExistUser1()
    {
        SqlParameter[] param = null;
        try
        {
            param = new SqlParameter[2];
            param[0] = new SqlParameter("@USERNAME", UserName);
            param[1] = new SqlParameter("@PASSWORD", Password);
            return SqlHelper.ExecuteReader(s_sqlcon, CommandType.StoredProcedure, "CHECKLOGIN1", param);
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            param = null;
        }
    }


    public SqlDataReader SearchUser()
    {
        SqlParameter[] param = null;
        try
        {
            param = new SqlParameter[1];
            param[0] = new SqlParameter("@EMAIL", Email);
            return SqlHelper.ExecuteReader(s_sqlcon, CommandType.StoredProcedure, "SEARCHUSERFORPWDREC", param);
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            param = null;
        }
    }

    public bool PasswordRecovery(string email, string question, string ans)
    {
        SqlParameter[] param = null;
        SqlDataReader dr = null;
        try
        {
            param = new SqlParameter[3];
            param[0] = new SqlParameter("@EMAIL", email);
            param[1] = new SqlParameter("@SECURITYANSWER", ans);
            param[2] = new SqlParameter("@SECURITYQUESTIONID", question);

            dr = SqlHelper.ExecuteReader(s_sqlcon, CommandType.StoredProcedure, "PASSWORDRECOVERY", param);
            if (dr.HasRows)
            {
                dr.Read();
                return true;
            }
            else
            {
                return false;
            }


        }
        catch (Exception ex)
        {
            throw ex;

        }
        finally
        {
            param = null;
            dr.Dispose();
            dr.Close();
        }

    }



    public string UpdateChangePwd()
    {
        SqlParameter[] param = null;
        try
        {
            param = new SqlParameter[2];
            param[0] = new SqlParameter("@STUDENTID", StudentId);
            param[1] = new SqlParameter("@PASSWORD", Password);

            return Convert.ToString(SqlHelper.ExecuteScalar(s_sqlcon, CommandType.StoredProcedure, "[dbo].[UPDATECHANGEPWD]", param));
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            param = null;
        }
    }

    public SqlDataReader ChangePassword()
    {
        SqlParameter[] param = null;
        try
        {
            param = new SqlParameter[1];
            param[0] = new SqlParameter("@STUDENTID", StudentId);
            return SqlHelper.ExecuteReader(s_sqlcon, CommandType.StoredProcedure, "CHANGEPASSWORD", param);
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            param = null;
        }
    }


    public bool LoginCheck()
    {
        SqlParameter[] param = null;
        SqlDataReader dr = null;
        try
        {
            param = new SqlParameter[2];
            param[0] = new SqlParameter("@USERNAME", UserName);
            param[1] = new SqlParameter("@PASSWORD", Password);
           // param[2] = new SqlParameter("@ROLE", Role);

            dr = SqlHelper.ExecuteReader(s_sqlcon, CommandType.StoredProcedure, "LOGINSTUDENT", param);
            //string a = dr.ToString();
            if (dr.HasRows)
            {
                //if (a == "1")
                //{
                //    HttpContext.Current.Response.Redirect("~/EndTest.aspx");
                //}
                dr.Read();                
                HttpContext.Current.Session["StudentId"] = dr["STUDENTID"].ToString();
                HttpContext.Current.Session["UserName"] = dr["USERNAME"].ToString();
                //HttpContext.Current.Session["CollegeId"] = dr["COLLEGEID"].ToString();

                return true;
            }
            else
            {
                return false;
            }


        }
        catch (Exception ex)
        {
            throw ex;

        }
        finally
        {
            param = null;
            dr.Dispose();
            dr.Close();
        }

    }


    public string InsertStudentInfo()
    {
        SqlParameter[] param = null;
        try
        {
            param = new SqlParameter[18];
            param[0] = new SqlParameter("@COLLEGEID", CollegeId);
            param[1] = new SqlParameter("@USERNAME", UserName);
            param[2] = new SqlParameter("@PASSWORD", Password);
            param[3] = new SqlParameter("@STUDENTNAME", StudentName);
            param[4] = new SqlParameter("@FATHERNAME", FatherName);
            param[5] = new SqlParameter("@QUALIFICATION", Qualification);
            param[6] = new SqlParameter("@PHONENO", PhoneNo);
            param[7] = new SqlParameter("@EMAIL", Email);
            param[8] = new SqlParameter("@DATEOFBIRTH", DateOfBirth);
            param[9] = new SqlParameter("@SEX", Sex);
            param[10] = new SqlParameter("@SECURITYQUESTIONID", SecurityQuestionid);
            param[11] = new SqlParameter("@SECURITYANSWER", SecurityAnswer);
            param[12] = new SqlParameter("@ADDRESS", Address);
            param[13] = new SqlParameter("@CITY", City);
            param[14] = new SqlParameter("@STATE", State);
            param[15] = new SqlParameter("@ZIPCODE", ZipCode);
            param[16] = new SqlParameter("@ROLE", Role);
            param[17] = new SqlParameter("@STATUS", Status);
            return Convert.ToString(SqlHelper.ExecuteScalar(s_sqlcon, CommandType.StoredProcedure, "[dbo].[INSERTSTUDENTINFO]", param));
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            param = null;
        }

    }
    public DataSet ddlSecurityQuestion()
    {
        return SqlHelper.ExecuteDataset(s_sqlcon, CommandType.StoredProcedure, "DDLSECURITYQUESTION");
    }

    public DataSet DisplayGroup()
    {
        return SqlHelper.ExecuteDataset(s_sqlcon, CommandType.StoredProcedure, "DISPLAYGROUP");
    }

}
public class ClsResult
{
    private static string s_sqlcon = System.Configuration.ConfigurationManager.ConnectionStrings["cn"].ConnectionString;

    private string _StudentId;
    public string StudentId
    {
        get { return _StudentId; }
        set { _StudentId = value; }
    }

    private string _Testid;
    public string Testid
    {
        get
        {
            return _Testid;
        }
        set
        {
            _Testid = value;
        }
    }

    private int _Result;
    public int result
    {
        get
        {
            return _Result;
        }
        set
        {
            _Result = value;
        }
    }

    public DataSet Showtest()
    {
        SqlParameter[] param = null;
        try
        {
            param = new SqlParameter[1];
            param[0] = new SqlParameter("@STUDENTID", StudentId);
            return SqlHelper.ExecuteDataset(s_sqlcon, CommandType.StoredProcedure, "DISPLAYTESTBYSTUDENT", param);
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            param = null;
        }

    }

    public DataSet Result()
    {
        SqlParameter[] param = null;
        try
        {
            param = new SqlParameter[2];
            param[0] = new SqlParameter("@STUDENTID", StudentId);
            param[1] = new SqlParameter("@TESTID", Testid);

            return SqlHelper.ExecuteDataset(s_sqlcon, CommandType.StoredProcedure, "[dbo].[RESULT]", param);
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            param = null;
        }
    }

    public string InsertResult()
    {
        SqlParameter[] param = null;
        try
        {
            param = new SqlParameter[3];
            param[0] = new SqlParameter("@STUDENTID", StudentId);
            param[1] = new SqlParameter("@TESTID", Testid);
            param[2] = new SqlParameter("@RESULT",result);
            return Convert.ToString(SqlHelper.ExecuteScalar(s_sqlcon, CommandType.StoredProcedure, "[dbo].[INSERTRESULT]", param));
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            param = null;
        }
    }
}
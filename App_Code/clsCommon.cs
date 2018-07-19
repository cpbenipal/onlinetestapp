using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using System.Data;

   

    public class clsCommon
    {
        public static string GetListSelectValues(ListControl control)
        {
            string str = string.Empty;

            for (int i = 0; i < control.Items.Count; i++)
            {
                if (control.Items[i].Selected == true)
                {
                    str += control.Items[i].Value+",";
                }
            }
            str = str.Trim(',');
            return str;
        }

        public static void SelectValuesInList(CheckBoxList checkedListBox1, string strSelectedVal)
        {
            string[] strVal = strSelectedVal.Split(',');
            checkedListBox1.SelectedIndex = -1;
            for (int i = 0; i < strVal.Length; i++)
            {
               
               checkedListBox1.Items.FindByValue(strVal[i]).Selected = true;
               
            }
        }

       


        //*******IsNumeric**********//
        public static bool IsNumeric(string value)
        {
            int r = 0;
            try
            {
                r = Convert.ToInt32(value);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        // ddlgroup , ds , "groupname" , "groupID" , "Select group" , false
        public static void FillBoundControl(ListControl ddlObject, DataSet ds, string strText, string strValue, string strShowtext, bool blnShowOther)
        {

            ddlObject.DataSource = ds; //set the data source of the Object to dataset.
            //else return the english language as default.
            ddlObject.DataTextField = strText;
            ddlObject.DataValueField = strValue; //set the object value

            ddlObject.DataBind(); //Bind the Control.
            //Check if the Other text is to be shown
            if (strShowtext != "null") //if its not null
            {
                ddlObject.Items.Insert(0, new ListItem(strShowtext, "0")); //show the degault text of the Object and set value as "0-Zero"
            }
            if (blnShowOther == true)
            {
                //in case yes, insert a new item at the end of the list with value "O"
                ddlObject.Items.Insert(Convert.ToInt32(ddlObject.Items.Count), new ListItem("Other", "O")); //in case you want to show other item at last position of drop down items
            }
            ds.Dispose(); //dispose the dataset.
        }
 
    }

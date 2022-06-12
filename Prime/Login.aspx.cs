using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using MySql.Data.MySqlClient;

public partial class Login : System.Web.UI.Page
{
    dbcon objConn = new dbcon();
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!IsPostBack) { }
           
        }
        catch (Exception Err)
        {
            string ErrMsg = Err.Message.ToString().Replace("'", "");
            ScriptManager.RegisterClientScriptBlock(this, typeof(Page), "alert", "<script>alert('" + ErrMsg + "');</script>", false);
        }


    }
    protected void BtnLgn_Click(object sender, EventArgs e)
    {
        try
        {
            if (TxtEmail.Text.Trim() == "")
            {
                ScriptManager.RegisterClientScriptBlock(this, typeof(Page), "alert", "<script>alert('Please Enter Your Email')</script>", false);
            }
            else if (TxtPsw.Text.Trim() == "")
            {
                ScriptManager.RegisterClientScriptBlock(this, typeof(Page), "alert", "<script>alert('Please Enter Your Password')</script>", false);
            }
            else
            {
                objConn.conPGeKosh = new MySqlConnection(objConn.csPG);
                if (objConn.conPGeKosh.State == ConnectionState.Closed)
                {
                    objConn.conPGeKosh.Open();
                    //return;
                }
                string SltUsr = "select email, psw from reg where email='" + TxtEmail.Text.Trim() + "' and " + " psw='" + TxtPsw.Text.Trim() + "'";
                objConn.RetriveDS(SltUsr);
                if (objConn.dsCommon.Tables[0].Rows.Count != 0)
                {
                    Response.Redirect("~/Home.aspx");
                }
                else
                {

                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Email/Password is Incorrect');window.location ='Login.aspx';", true);
                }

            }
        }
        catch (Exception Err)
        {
            string ErrMsg = Err.Message.ToString().Replace("'", "");
            ScriptManager.RegisterClientScriptBlock(this, typeof(Page), "alert", "<script>alert('" + ErrMsg + "');</script>", false);
        }
    }
}
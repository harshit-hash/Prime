using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using MySql.Data.MySqlClient;

public partial class Registration : System.Web.UI.Page
{
    dbcon objConn = new dbcon();
    protected void Page_Load(object sender, EventArgs e)
    {
        try { if (!IsPostBack) { clearcontrol(); } }
        catch (Exception Err)
        {
            string ErrMsg = Err.Message.ToString().Replace("'", "");
            ScriptManager.RegisterClientScriptBlock(this, typeof(Page), "alert", "<script>alert('" + ErrMsg + "');</script>", false);
        }

    }
    protected void BtnReg_Click(object sender, EventArgs e)
    {
        try
        {
            if (TxtEmail.Text.Trim() == "")
            {
                ScriptManager.RegisterClientScriptBlock(this, typeof(Page), "alert", "<script>alert('Please Enter Your Email-Id')</script>", false);
            }
            else if (TxtName.Text.Trim() == "")
            {
                ScriptManager.RegisterClientScriptBlock(this, typeof(Page), "alert", "<script>alert('Please Enter Your Name')</script>", false);
            }
            else if (TxtPsw.Text.Trim() == "")
            {
                ScriptManager.RegisterClientScriptBlock(this, typeof(Page), "alert", "<script>alert('Please Enter Your Password')</script>", false);
            }
            else if (TxtConPsw.Text.Trim() == "")
            {
                ScriptManager.RegisterClientScriptBlock(this, typeof(Page), "alert", "<script>alert('Please Confirm Your Password')</script>", false);
            }
            else
            {
                objConn.conPGeKosh = new MySqlConnection(objConn.csPG);
                if (objConn.conPGeKosh.State == ConnectionState.Closed)
                {
                    objConn.conPGeKosh.Open();
                    //return;
                }
                string InsUsr = "insert into reg(name, email, psw) values(@name,@email,@psw) ";
                objConn.cmdPG = new MySqlCommand(InsUsr, objConn.conPGeKosh);
                objConn.cmdPG.Parameters.AddWithValue("name", TxtName.Text.Trim());
                objConn.cmdPG.Parameters.AddWithValue("email", TxtEmail.Text.Trim());
                objConn.cmdPG.Parameters.AddWithValue("psw", TxtPsw.Text.Trim());
                objConn.cmdPG.ExecuteNonQuery();
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('SuccessFull Register');window.location ='Login.aspx';",true);
                clearcontrol();

            }
        }
        catch (Exception Err)
        {
            string ErrMsg = Err.Message.ToString().Replace("'", "");
            ScriptManager.RegisterClientScriptBlock(this, typeof(Page), "alert", "<script>alert('" + ErrMsg + "');</script>", false);
        }
        finally {  }

    }
    public void clearcontrol()
    {
        TxtName.Text = "";
        TxtEmail.Text = "";
        TxtPsw.Text = "";
        TxtConPsw.Text = "";
    }
}
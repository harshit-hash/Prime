using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Home : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void BtnReg_Click(object sender, EventArgs e)
    {
        try
        {
            if (TxtNo1.Text.Trim() == "") { ScriptManager.RegisterClientScriptBlock(this, typeof(Page), "alert", "<script>alert('Please Enter First Number')</script>", false); }
            else if (TxtNo2.Text.Trim() == "") { ScriptManager.RegisterClientScriptBlock(this, typeof(Page), "alert", "<script>alert('Please Enter Second Number')</script>", false); }
            else if (TxtNo3.Text.Trim() == "") { ScriptManager.RegisterClientScriptBlock(this, typeof(Page), "alert", "<script>alert('Please Enter Third Number')</script>", false); }

            else
            {
                LblAns.Text = "";
                long n1, n2, n3, f1 = 0, f3 = 0, f2 = 0;
                n1 = Int64.Parse(TxtNo1.Text.Trim());
                n2 = Int64.Parse(TxtNo2.Text.Trim());
                n3 = Int64.Parse(TxtNo3.Text.Trim());
                if (TxtNo1.Text.Trim() == "0" || TxtNo1.Text.Trim() == "1")
                {
                    f1 = 1;
                }
                else
                {
                    for (int i = 2; i <= n1 / 2; i++)
                    {
                        if (n1 % i == 0)
                        {
                            f1 = 1;
                            break;
                        }
                    }
                }

                if (TxtNo2.Text.Trim() == "0" || TxtNo2.Text.Trim() == "1")
                {
                    f2 = 1;
                }
                else
                {
                    for (int i = 2; i <= n2 / 2; i++)
                    {
                        if (n2 % i == 0)
                        {
                            f2 = 1;
                            break;
                        }
                    }
                }
                if (TxtNo3.Text.Trim() == "0" || TxtNo3.Text.Trim() == "1")
                {
                    f3 = 1;
                }
                else
                {
                    for (int i = 2; i <= n3 / 2; i++)
                    {
                        if (n3 % i == 0)
                        {

                            f3 = 1;
                            break;
                        }
                    }
                }

                if (f1 == 0)
                {
                    if (f2 == 0 && f3 == 0) { LblAns.Text = "Prime No: " + n1.ToString() + ", " + n2.ToString() + ", " + n3.ToString(); }

                    else if (f3 == 0) { LblAns.Text = "Prime No: " + n1.ToString() + ", " + n3.ToString(); }
                    else if (f2 == 0)
                    {
                        LblAns.Text = "Prime No: " + n1.ToString() + ", " + n2.ToString();
                    }
                    else { LblAns.Text = "Prime No: " + n1.ToString(); }
                }
                else if (f2 == 0)
                {
                    if (f3 == 0)
                    {
                        LblAns.Text = "Prime No: " + n2.ToString() + ", " + n3.ToString();
                    }

                    else { LblAns.Text = "Prime No: " + n2.ToString(); }
                }
                else if (f3 == 0)
                {
                    LblAns.Text = "Prime No: " + n3.ToString();
                }
                else { LblAns.Text = "Given Numbers are not Prime"; }
            }
        }
        catch (Exception Err)
        {
            string ErrMsg = Err.Message.ToString().Replace("'", "");
            ScriptManager.RegisterClientScriptBlock(this, typeof(Page), "alert", "<script>alert('" + ErrMsg + "');</script>", false);
        }

    }
}
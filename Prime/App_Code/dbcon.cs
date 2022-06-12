using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using System.Data;
using System.Web.UI.WebControls;

using System.Web.UI;

//using System.Data.SqlClient;



/// <summary>
/// Summary description for dbcon
/// </summary>
public class dbcon
{

    public MySqlConnection conPGeKosh;
    public MySqlCommand cmdPG;
    public MySqlDataReader rdrPG;
    public MySqlTransaction TransPG;


    public MySqlDataAdapter daPG;
    public DataSet dsCommon;
    public DataSet dsQuery1;
    public MySqlDataAdapter daPGQuery1;

    public DataSet dsQuery2;
    public MySqlDataAdapter daPGQuery2;

    public DataSet dsQuery3;
    public MySqlDataAdapter daPGQuery3;

    public DataSet dsQuery4;
    public MySqlDataAdapter daPGQuery4;

    public DataSet dsBT;
    public MySqlDataAdapter daBT;

    public DataSet dsAG;
    public MySqlDataAdapter daAG;

    public DataSet dsGrid;
    public MySqlDataAdapter daGrid;


    public string csOracle = "";
    public string csSqlServer = "";
    public string csPG = "";
    public dbcon()
    {
        //csPG = "Server=localhost;Port=5432;username=postgres;Password=hrawan;Database=postgres;";
        csPG = "Server=localhost; Database = prime; User = root;Port=3306; Password = hrawan;";
        //csPG = "Server=MYSQL5033.site4now.net;Database=db_a7bc2a_sportcg;Uid=a7bc2a_sportcg;Pwd= hrawan";
        //csPG = "Server=MYSQL5045.site4now.net;Database=db_a78672_hrowan;Uid=a78672_hrowan;Pwd=Hemant@1101";

        //csPG = "Server=MYSQL5045.site4now.net;Database=db_a82558_ticket1;Uid=a82558_ticket1;Pwd=Smarter111";

    }


    //Insert Data
    public void Insert(string str)
    {

        using (conPGeKosh = new MySqlConnection(csPG))
        {
            using (cmdPG = new MySqlCommand(str, conPGeKosh))
            {
                conPGeKosh.Open();
                cmdPG.ExecuteNonQuery();
            }
        }

    }
    //Update Data
    public void Update(string str)
    {

        using (conPGeKosh = new MySqlConnection(csPG))
        {
            using (cmdPG = new MySqlCommand(str, conPGeKosh))
            {
                conPGeKosh.Open();
                cmdPG.ExecuteNonQuery();
            }
        }

    }
    //Delete Data
    public void Delete(string str)
    {

        using (conPGeKosh = new MySqlConnection(csPG))
        {
            using (cmdPG = new MySqlCommand(str, conPGeKosh))
            {
                conPGeKosh.Open();
                cmdPG.ExecuteNonQuery();
            }
        }

    }
    //Retrive Date by DataSet
    public void RetriveDS(string str)
    {
        dsCommon = new DataSet();

        using (conPGeKosh = new MySqlConnection(csPG))
        {
            using (daPG = new MySqlDataAdapter(str, conPGeKosh))
            {
                conPGeKosh.Open();
                dsCommon.Clear();
                daPG.Fill(dsCommon);
            }
        }

    }

    public void RetriveDSQuery1(string str)
    {
        dsQuery1 = new DataSet();

        using (conPGeKosh = new MySqlConnection(csPG))
        {
            using (daPGQuery1 = new MySqlDataAdapter(str, conPGeKosh))
            {
                conPGeKosh.Open();
                dsQuery1.Clear();
                daPGQuery1.Fill(dsQuery1);
            }
        }

    }

    public void RetriveDSQuery2(string str)
    {
        dsQuery2 = new DataSet();

        using (conPGeKosh = new MySqlConnection(csPG))
        {
            using (daPGQuery2 = new MySqlDataAdapter(str, conPGeKosh))
            {
                conPGeKosh.Open();
                dsQuery2.Clear();
                daPGQuery2.Fill(dsQuery2);
            }
        }

    }

    public void RetriveDSQuery3(string str)
    {
        dsQuery3 = new DataSet();

        using (conPGeKosh = new MySqlConnection(csPG))
        {
            using (daPGQuery3 = new MySqlDataAdapter(str, conPGeKosh))
            {
                conPGeKosh.Open();
                dsQuery3.Clear();
                daPGQuery3.Fill(dsQuery3);
            }
        }

    }

    public void RetriveDSQuery4(string str)
    {
        dsQuery4 = new DataSet();

        using (conPGeKosh = new MySqlConnection(csPG))
        {
            using (daPGQuery4 = new MySqlDataAdapter(str, conPGeKosh))
            {
                conPGeKosh.Open();
                dsQuery4.Clear();
                daPGQuery4.Fill(dsQuery4);
            }
        }

    }

    public void RetriveDSBT(string str)
    {
        dsCommon = new DataSet();

        using (conPGeKosh = new MySqlConnection(csPG))
        {
            using (daBT = new MySqlDataAdapter(str, conPGeKosh))
            {
                conPGeKosh.Open();
                dsBT.Clear();
                daBT.Fill(dsBT);
            }
        }

    }

    public void RetriveDSAG(string str)
    {
        dsCommon = new DataSet();

        using (conPGeKosh = new MySqlConnection(csPG))
        {
            using (daAG = new MySqlDataAdapter(str, conPGeKosh))
            {
                conPGeKosh.Open();
                dsAG.Clear();
                daAG.Fill(dsAG);
            }
        }

    }

    public void RetriveDSGrid(string str)
    {
        dsGrid = new DataSet();

        using (conPGeKosh = new MySqlConnection(csPG))
        {
            using (daGrid = new MySqlDataAdapter(str, conPGeKosh))
            {
                conPGeKosh.Open();
                dsGrid.Clear();
                daGrid.Fill(dsGrid);
            }
        }

    }

    public void FillDDL(string query, DropDownList list)
    {
        RetriveDS(query);
        list.DataValueField = dsCommon.Tables[0].Columns[0].ToString();
        list.DataTextField = dsCommon.Tables[0].Columns[1].ToString();
        list.DataSource = dsCommon.Tables[0];
        list.DataBind();
    }
}
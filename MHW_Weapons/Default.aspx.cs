using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MHW_Weapons
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

           // SqlCommand command = new SqlCommand("select * from Users");

        }

        protected SqlConnection GetSqlConnection()
        {
            try
            {
                //Using the Default Connection in the Web.Config File, establish an Oracle Connection
                var conString = System.Configuration.ConfigurationManager.ConnectionStrings["SQLConnection"];
                string strConnString = conString.ConnectionString;
                return new SqlConnection(strConnString);
            }

            catch (Exception ex)
            {
                Console.WriteLine("SQL Exception Message");
                Console.WriteLine("Exception Message: " + ex.Message);
                Console.WriteLine("Exception Source: " + ex.Source);
                return null;
            }
        }
    }
}